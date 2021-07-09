using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios.NegociosRol;
using Negocios.NegociosUsuario;
using Negocios.NegociosParqueo;
using Entidades.Entidades;

namespace GUI.Forms
{
    public partial class frm_administrador : Form
    {
        #region instancias
        cl_neg_Rol negRol = new cl_neg_Rol();
        cl_neg_Usuario negUser = new cl_neg_Usuario();
        cl_ent_Usuario entUser = new cl_ent_Usuario();
        cl_ent_Parqueo entPar = new cl_ent_Parqueo();
        cl_neg_Parqueo negPar = new cl_neg_Parqueo();
        #endregion

        #region constructor
            public frm_administrador(String nombre)
            {
                InitializeComponent();
                this.Text = "Bienvenido: " + nombre;
                CargarCMB();
            }
            public void CargarCMB()
            {
                cmbRolNuevo.DataSource = negRol.cargarComboBox();
                cmbRolNuevo.DisplayMember = "v_nombreRol";
                cmbRolNuevo.ValueMember = "v_idRol";

                cmRolEditar.DataSource = negRol.cargarComboBox();
                cmRolEditar.DisplayMember = "v_nombreRol";
                cmRolEditar.ValueMember = "v_idRol";

                cmbCargarParqueos.DataSource = negPar.consultarPark();
                cmbCargarParqueos.DisplayMember = "v_nombre";
                cmbCargarParqueos.ValueMember = "v_CedulaJuridicaParqueo";
             }
        #endregion

        #region Salir
        private void EmpleadosTab_Click(object sender, EventArgs e)
        {
            if (EmpleadosTab.SelectedTab == tabCerrarSesion)
            {
                if (MessageBox.Show("Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    frm_login log = new frm_login();
                    log.Show();
                }
            }
        }
        #endregion

        #region modUsuarios
        private void btnConsultarNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridConsultaUsuario.DataSource = negUser.consultarUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error." + ex.Message);
            }
        }
        public Boolean ValidarCamposNuevoUsuario()
        {
            bool estado = true;
            if (txtCedNuevo.Text.Equals(" -    -") ||
            txtContraNuevo.Text.Equals("") ||
            txtEmailNuevo.Text.Equals("") ||
            txtNomNuevo.Text.Equals("") ||
            txtTelNuevo.Text.Equals("    -"))
                estado = false;
            return estado;
        }
        public void LimpiarNuevoUser()
        {
            txtCedNuevo.Text = "";
            txtContraNuevo.Text = "";
            txtEmailNuevo.Text = "";
            txtNomNuevo.Text = "";
            txtTelNuevo.Text = "";
            cmbRolNuevo.SelectedIndex = 0;
        }
        private void btnGuardarNuevoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposNuevoUsuario())
                {
                    entUser._SCedulaUsuario = txtCedNuevo.Text;
                    entUser._SNombre = txtNomNuevo.Text;
                    entUser._STelefono = txtTelNuevo.Text;
                    entUser._SCorreo = txtEmailNuevo.Text;
                    entUser._SContrasena = txtContraNuevo.Text;
                    entUser._IIdRol = Convert.ToInt32(cmbRolNuevo.SelectedValue);

                    if (negUser.NuevoUser(entUser))
                    {
                        dataGridConsultaUsuario.DataSource = negUser.consultarUser();
                        MessageBox.Show("Se ha ingresado correctamente", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarNuevoUser();
                    }
                    else
                        MessageBox.Show("No se ha ingresado correctamente", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe ingresar toda la información solicitada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("se ha producido un error " + ex.Message, "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnLimpiarNuevoUsuario_Click(object sender, EventArgs e)
        {
            LimpiarNuevoUser();
        }
        public DataTable buscaCliente(String cedula)
        {
            DataTable taTempo = new DataTable();
            try
            {
                taTempo = negUser.BuscarUser(cedula);
                if (taTempo == null)
                    MessageBox.Show("No se han encontrado resultado ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error, " + ex.Message);
            }
            return taTempo;
        }
        private void btnBuscarEspecifica_Click(object sender, EventArgs e)
        {
            dataGridBuscarCliente.DataSource= buscaCliente(txtCeduBuscar.Text);
        }
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridBuscarCliente.DataSource != null)
            {
                try
                {
                    SubEmpleados.SelectedIndex = 2;
                    txtNomEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[1].Value.ToString();
                    txtCedEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[0].Value.ToString();
                    txtEmailEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[2].Value.ToString();
                    txtTelEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[3].Value.ToString();
                    txtContraEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[4].Value.ToString();
                    cmRolEditar.Text = dataGridBuscarCliente.CurrentRow.Cells[5].Value.ToString();
                    btnModificaUsuario.Enabled = true;
                    dataGridBuscarCliente.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Aún no hay información cargada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public Boolean ValidarCamposEditarUsuario()
        {
            bool estado = true;
            if (txtCedEditar.Text.Equals(" -    -") ||
            txtContraEditar.Text.Equals("") ||
            txtEmailEditar.Text.Equals("") ||
            txtNomEditar.Text.Equals("") ||
            txtTelEditar.Text.Equals("    -"))
                estado = false;
            return estado;
        }
        public void LimpiarEditarUsuarios()
        {
            txtContraEditar.Text = "";
            txtEmailEditar.Text = "";
            txtNomEditar.Text = "";
            txtTelEditar.Text = "";
            cmRolEditar.SelectedIndex = 0;
        }
        private void btnModificaUsuario_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEditarUsuario())
            {
                try
                {
                    entUser._SCedulaUsuario = txtCedEditar.Text;
                    entUser._SNombre = txtNomEditar.Text;
                    entUser._STelefono = txtTelEditar.Text;
                    entUser._SCorreo = txtEmailEditar.Text;
                    entUser._SContrasena = txtContraEditar.Text;
                    entUser._IIdRol = Convert.ToInt32(cmRolEditar.SelectedValue);


                    if (negUser.EditarEmpleado(entUser))
                    {
                        dataGridEditar.DataSource = negUser.BuscarUser(txtCedEditar.Text);
                        MessageBox.Show("Se ha modificado correctamente", "Editar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarEditarUsuarios();
                        txtCedEditar.Text = "";
                        btnModificaUsuario.Enabled = false;
                    }
                    else
                        MessageBox.Show("No se ha modificado correctamente", "Editar usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar toda la información solicitada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnLimpiarEditarUsuario_Click(object sender, EventArgs e)
        {
            LimpiarEditarUsuarios();
        }
        #endregion

        #region modRolres

        #endregion

        #region modParqueo
        public Boolean ValidarNuevoParqueo()
        {
            bool estado = true;
            if (mtb_CedulaJuridica.Text.Equals(" -   -") ||
            txt_NombreParqueo.Text.Equals("") ||
            mtb_Provincia.Text.Equals("") ||
            txt_Canton.Text.Equals("") ||
            txt_Distrito.Text.Equals("") ||
            txtCamposDisponiblesParqueo.Text.Equals("")||
            txt_Calle.Text.Equals("") ||
            txtTelParqueo.Text.Equals("    -"))
                estado = false;
            return estado;
        }
        public void LimpiarNuevoParqueo()
        {
            mtb_CedulaJuridica.Text = "";
            txt_NombreParqueo.Text = "";
            mtb_Provincia.Text = "";
            txt_Canton.Text = "";
            txt_Distrito.Text = "";
            txt_Calle.Text = "";
            txtTelParqueo.Text = "";
            txtCamposDisponiblesParqueo.Text = "";
        }

        private void btn_GuardarParqueo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarNuevoParqueo())
                {
                    entPar._SCedJuParqueo = mtb_CedulaJuridica.Text;
                    entPar._SNombre = txt_NombreParqueo.Text;
                    entPar._SProvincia = mtb_Provincia.Text;
                    entPar._SCanton = txt_Canton.Text;
                    entPar._SDistrito = txt_Distrito.Text;
                    entPar._SCalle = txt_Calle.Text;
                    entPar._STelefono = txtTelParqueo.Text;
                    entPar._ICamposDisponibles = Convert.ToInt32( txtCamposDisponiblesParqueo.Text);

                    if (negPar.NuevoParqueo(entPar))
                    {
                        dataGridConsultarParqueo.DataSource = negPar.consultarPark();
                        MessageBox.Show("Se ha ingresado correctamente", "Nuevo el Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarNuevoParqueo();
                    }
                    else
                        MessageBox.Show("No se ha ingresado correctamente", "Nuevo Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Debe ingresar toda la información solicitada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("se ha producido un error " + ex.Message, "Nuevo Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscaParqueo_Click(object sender, EventArgs e)
        {
            DataTable taTempo = new DataTable();
            try
            {
                taTempo = negPar.BuscarParqueo(txtCedBuscarParqueo.Text.ToString());
                if (taTempo != null)
                    dataGridBuscaParqueo.DataSource = taTempo;
                else
                    MessageBox.Show("No se han encontrado resultado ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error, " + ex.Message);
            }
        }

        private void btnModificarParqueo_Click(object sender, EventArgs e)
        {
            if (dataGridBuscaParqueo.DataSource != null)
            {
                try
                {
                    tabSubParqueo.SelectedIndex = 7;
                    txtEditParqueoCedula.Text = dataGridBuscaParqueo.CurrentRow.Cells[0].Value.ToString();
                    txtEditParqueoNombre.Text = dataGridBuscaParqueo.CurrentRow.Cells[1].Value.ToString();
                    txtEditParqueoProvincia.Text = dataGridBuscaParqueo.CurrentRow.Cells[2].Value.ToString();
                    txtEditParqueoCanton.Text = dataGridBuscaParqueo.CurrentRow.Cells[3].Value.ToString();
                    txtEditParqueoDistrito.Text = dataGridBuscaParqueo.CurrentRow.Cells[4].Value.ToString();
                    txtEditParqueoCalle.Text = dataGridBuscaParqueo.CurrentRow.Cells[5].Value.ToString();
                    txtEditParqueoTelefono.Text = dataGridBuscaParqueo.CurrentRow.Cells[6].Value.ToString();
                    txtCamposDispEditarParqueo.Text = dataGridBuscaParqueo.CurrentRow.Cells[7].Value.ToString();
                    btnModificaUsuario.Enabled = true;
                    dataGridBuscaParqueo.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Aún no hay información cargada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        public Boolean ValidarCamposEditarParqueo()
        {
            bool estado = true;
            if (txtEditParqueoCedula.Text.Equals(" -   -") ||
            txtEditParqueoNombre.Text.Equals("") ||
            txtEditParqueoProvincia.Text.Equals("") ||
            txtEditParqueoCanton.Text.Equals("") ||
            txtEditParqueoDistrito.Text.Equals("") ||
            txtCamposDispEditarParqueo.Text.Equals("") ||
            txtEditParqueoCalle.Text.Equals("") ||
            txtEditParqueoTelefono.Text.Equals("    -"))
                estado = false;
            return estado;
        }
        public void LimpiarCamposEditarParqueo()
        {
            txtEditParqueoNombre.Text = "";
            txtEditParqueoProvincia.Text = "";
            txtEditParqueoCanton.Text = "";
            txtEditParqueoDistrito.Text = "";
            txtEditParqueoCalle.Text = "";
            txtEditParqueoTelefono.Text = "";
            txtCamposDispEditarParqueo.Text = "";
        }

        private void btnModificaParqueo_Click(object sender, EventArgs e)
        {
            if (ValidarCamposEditarParqueo())
            {
                try
                {
                    entPar._SCedJuParqueo = txtEditParqueoCedula.Text;
                    entPar._SNombre = txtEditParqueoNombre.Text;
                    entPar._SProvincia = txtEditParqueoProvincia.Text;
                    entPar._SCanton = txtEditParqueoCanton.Text;
                    entPar._SDistrito = txtEditParqueoDistrito.Text;
                    entPar._SCalle = txtEditParqueoCalle.Text;
                    entPar._STelefono = txtEditParqueoTelefono.Text;
                    entPar._ICamposDisponibles = Convert.ToInt32(txtCamposDispEditarParqueo.Text);


                    if (negPar.EditarParqueo(entPar))
                    {
                        dataGridEditaParqueo.DataSource = negPar.BuscarParqueo(txtEditParqueoCedula.Text);
                        MessageBox.Show("Se ha modificado correctamente", "Editar parqueo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCamposEditarParqueo();
                        txtEditParqueoCedula.Text = "";
                        btnModificaParqueo.Enabled = false;
                    }
                    else
                        MessageBox.Show("No se ha modificado correctamente", "Editar parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Se ha producido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Debe ingresar toda la información solicitada!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnConsultarParqueos_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridConsultarParqueo.DataSource = negPar.consultarPark();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error." + ex.Message);
            }
        }

        private void rdbTipoUsuarioCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTipoUsuarioCliente.Checked)
            {
                gBoxClientes.Enabled = true;
                gBoxInvitados.Enabled = false;
            }
            else
            {
                gBoxClientes.Enabled = false;
                gBoxInvitados.Enabled = true;
            }
        }

        private void btnBuscaClienteGuardaVehiculo_Click(object sender, EventArgs e)
        {
            DataTable cliente = new DataTable();
            cliente = buscaCliente(txtCedBuscaGuardaVehiculo.Text);
            if (cliente != null)
            {
                foreach (DataRow row in cliente.Rows)
                {
                    //Rol administrador
                    if (row["Rol"].ToString().Equals("Administrador"))
                        MessageBox.Show("No se puede agregar un administrador");
                    else
                    {
                        txtGuardaVehiculoNombre.Text = row["v_nombreCompleto"].ToString();
                    
                    }
                }
            }
        }

        private void cmbCargarParqueos_SelectedValueChanged(object sender, EventArgs e)
        {
            DataTable taTempo = new DataTable();
            try
            {
                taTempo = negPar.BuscarParqueo(cmbCargarParqueos.SelectedValue.ToString());
                if (taTempo != null)
                {
                    foreach (DataRow row in taTempo.Rows)
                    {
                        lbCantidadDisponible.Text = row["v_CantidadCampos"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error, " + ex.Message);
            }
        }


        #endregion

        private void btn_LimpiarParqueo_Click(object sender, EventArgs e)
        {
            txt_NombreParqueo.Text = "";
            mtb_CedulaJuridica.Text = "";
            txtCamposDisponiblesParqueo.Text = "";
            txtTelParqueo.Text = "";
            mtb_Provincia.Text = "";
            txt_Canton.Text = "";
            txt_Distrito.Text = "";
            txt_Calle.Text = "";
        }

        private void btnLimpiarBusquedaParqueo_Click(object sender, EventArgs e)
        {
            txtCedBuscarParqueo.Text = "";
        }

        private void btnLimpiarModificar_Click(object sender, EventArgs e)
        {
            txtEditParqueoNombre.Text = "";
            txtEditParqueoProvincia.Text = "";
            txtEditParqueoCanton.Text = "";
            txtEditParqueoDistrito.Text = "";
            txtEditParqueoCalle.Text = "";
            txtEditParqueoTelefono.Text = "";
            txtCamposDispEditarParqueo.Text = "";
        }

        private void btn_ConsultarParqueoModificar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridEditaParqueo.DataSource = negPar.consultarPark();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error." + ex.Message);
            }
        }

        private void dataGridEditaParqueo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                txtEditParqueoNombre.Text = dataGridEditaParqueo.Rows[n].Cells[1].Value.ToString();
                txtEditParqueoCedula.Text = dataGridEditaParqueo.Rows[n].Cells[0].Value.ToString();
                txtCamposDispEditarParqueo.Text = dataGridEditaParqueo.Rows[n].Cells[7].Value.ToString();
                txtEditParqueoTelefono.Text = dataGridEditaParqueo.Rows[n].Cells[6].Value.ToString();
                txtEditParqueoProvincia.Text = dataGridEditaParqueo.Rows[n].Cells[2].Value.ToString();
                txtEditParqueoCanton.Text = dataGridEditaParqueo.Rows[n].Cells[3].Value.ToString();
                txtEditParqueoDistrito.Text = dataGridEditaParqueo.Rows[n].Cells[4].Value.ToString();
                txtEditParqueoCalle.Text = dataGridEditaParqueo.Rows[n].Cells[5].Value.ToString();
            }
        }
    }
}
