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
using Negocios.NegociosAparcar;

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
        cl_neg_Aparcar negApar = new cl_neg_Aparcar();
        cl_ent_aparcar entApar = new cl_ent_aparcar();
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

                cmbInformeParqueo.DataSource = negPar.consultarPark();
                cmbInformeParqueo.DisplayMember = "v_nombre";
                cmbInformeParqueo.ValueMember = "v_CedulaJuridicaParqueo";

                cmbParqueoParaRetirarCarro.DataSource = negPar.consultarPark();
                cmbParqueoParaRetirarCarro.DisplayMember = "v_nombre";
                cmbParqueoParaRetirarCarro.ValueMember = "v_CedulaJuridicaParqueo";
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
                        txtGuardaVehiculoCorreo.Text = row["v_correo"].ToString();
                        txtGuardaVehiculoTelefono.Text = row["v_telefono"].ToString();
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

        #region  LimpiarParqueo
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
        #endregion

        #region LimpiarBusquedaParqueo
        private void btnLimpiarBusquedaParqueo_Click(object sender, EventArgs e)
        {
            txtCedBuscarParqueo.Text = "";
        }
        #endregion

        #region LimpiarModificarParqueo
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
        #endregion

        #region ConsularParqueoModificar
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
        #endregion

        #region EditarParqueoGridView
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
        #endregion

        #region LimpiarBusquedaUsuario
        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtCeduBuscar.Text = "";
        }
        #endregion

        #region LimpiarVehiculoCliente
        private void btnLimpiarVehiculoCliente_Click(object sender, EventArgs e)
        {
            txtCedBuscaGuardaVehiculo.Text = "";
            txtGuardaVehiculoNombre.Text = "";
            txtGuardaVehiculoCorreo.Text = "";
            txtGuardaVehiculoTelefono.Text = "";
            txtGuardaVehiculoPlaca.Text = "";
            txtGuardaVehiculoMarca.Text = "";
            txtGuardaVehiculoModelo.Text = "";
        }
        #endregion

        #region LimpiarVehiculoInvitado
        private void btnLimpiarVehiculoInvitado_Click(object sender, EventArgs e)
        {
            txtCedInvitadoGuardaVehiculo.Text = "";
            txtInvitadoVehiculoNombre.Text = "";
            txtInvitadoVehiculoCorreo.Text = "";
            txtInvitadoVehiculoTelefono.Text = "";
            txtInvitadoVehiculoPlaca.Text = "";
            txtInvitadoVehiculoMarca.Text = "";
            txtInvitadoVehiculoModelo.Text = "";
        }

        #endregion

        private void TimerHoraIngresa_Tick(object sender, EventArgs e)
        {
            lbFechaIngresa.Text = Convert.ToString(DateTime.Now.ToString("ddd, dd MMM yyy"));
            lbHoraIngresa.Text = Convert.ToString(DateTime.Now.ToString("hh:mm:ss tt"));
            lbFechaSaleRetiraVehiculo.Text = Convert.ToString(DateTime.Now);
        }

        private void btnAparcarVehiculo_Click(object sender, EventArgs e)
        {
            if(rdbTipoUsuarioCliente.Checked)
            {
                AparcarCliente();
            }
            else
            {
                AparcarInvitado();
            }
            CargarCMB();
        }
        public void AparcarCliente()
        {
            try
            {
                entApar._SCedJuParqueo = cmbCargarParqueos.SelectedValue.ToString();
                entApar._SCedulaUsuario = txtCedBuscaGuardaVehiculo.Text;
                if (rbTipoCarro.Checked)
                    entApar._STipoVehiculo = "Carro";    
                else
                    entApar._STipoVehiculo = "Moto";

                entApar._SPlacaVehiculo = txtGuardaVehiculoPlaca.Text;
                entApar._SMarca = txtGuardaVehiculoMarca.Text;
                entApar._SModelo = txtGuardaVehiculoModelo.Text;
                entApar._DtFechaEntrada = DateTime.Now;

                if (negApar.NuevoAparcado(entApar))
                {
                    MessageBox.Show("Se ha ingresado correctamente al parqueo", "Nuevo Aparcado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("No se ha ingresado correctamente", "Nuevo Aparcado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", "Ingreso Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AparcarInvitado()
        {

        }

        private void frm_administrador_Load(object sender, EventArgs e)
        {
            CargarInformeAparcados();
        }
        public void CargarInformeAparcados()
        {
            this.aparcadosEntreFechasTableAdapter.Fill(this.dataSetCN.AparcadosEntreFechas, dtFechaInicioInforme.Value, dtFechaFinReporte.Value, cmbInformeParqueo.SelectedValue.ToString());
            this.repoAparcados.RefreshReport();
        }

        private void btnInformeFechas_Click(object sender, EventArgs e)
        {
            CargarInformeAparcados();
        }

        private void btnBuscarPlacaRetiraVehiculo_Click(object sender, EventArgs e)
        {
            CargaVehiculosEnParqueo();
        }

        public void CargaVehiculosEnParqueo()
        {
            try
            {
                DataTable dt = new DataTable();
                entApar._SCedJuParqueo = cmbParqueoParaRetirarCarro.SelectedValue.ToString();
                entApar._SPlacaVehiculo = txtPlacaRetiraVehiculo.Text;
                if (rdTipoRetiraCarro.Checked)
                    entApar._STipoVehiculo = "Carro";
                else
                    entApar._STipoVehiculo = "Moto";
                entApar._BEstadVehiculo = true;

                dt = negApar.BuscarCarroSalirParqueo(entApar);
                if (dt != null)
                {
                    try
                    {
                        foreach(DataRow row in dt.Rows)
                        {
                            txtMarcaRetiraVehiculo.Text = row["v_marca"].ToString();
                            txtModeloRetiraVehiculo.Text = row["v_modelo"].ToString();
                            txtNombreClienteRetira.Text = row["v_nombreCompleto"].ToString(); 
                            txtCedClienteRetira.Text = row["v_CedulaUsuario"].ToString(); 
                            txtCorreoClienteRetira.Text = row["v_correo"].ToString(); 
                            txtTelefonoClienteRetira.Text = row["v_telefono"].ToString(); 
                            lbFechaIngresaRetiraVehiculo.Text = row["v_FechaHoraEntrada"].ToString();
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Esta placa no se encuentra en el parqueo activa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", "Ingreso Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbParqueoParaRetirarCarro_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridvehiculosActivos.DataSource = null;
            try
            {
                entApar._SCedJuParqueo = cmbParqueoParaRetirarCarro.SelectedValue.ToString();

                if (negApar.CargarCarrosActivosParqueos(entApar) != null)
                {
                    dataGridvehiculosActivos.DataSource = negApar.CargarCarrosActivosParqueos(entApar);
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Se ha producido un error", "Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private void dataGridvehiculosActivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPlacaRetiraVehiculo.Text = dataGridvehiculosActivos.CurrentRow.Cells[0].Value.ToString();
            txtMarcaRetiraVehiculo.Text = dataGridvehiculosActivos.CurrentRow.Cells[1].Value.ToString();
            txtModeloRetiraVehiculo.Text = dataGridvehiculosActivos.CurrentRow.Cells[2].Value.ToString();
            txtNombreClienteRetira.Text = dataGridvehiculosActivos.CurrentRow.Cells[3].Value.ToString();
            txtCedClienteRetira.Text = dataGridvehiculosActivos.CurrentRow.Cells[4].Value.ToString();
            txtCorreoClienteRetira.Text = dataGridvehiculosActivos.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoClienteRetira.Text = dataGridvehiculosActivos.CurrentRow.Cells[6].Value.ToString();
            lbFechaIngresaRetiraVehiculo.Text = dataGridvehiculosActivos.CurrentRow.Cells[7].Value.ToString();

            if (dataGridvehiculosActivos.CurrentRow.Cells[8].Value.ToString().Equals("Carro"))
                rdTipoRetiraCarro.Checked=true;
            else
                rdTipoRetiraMoto.Checked= true;

        }

        private void btnRetirarVehiculo_Click(object sender, EventArgs e)
        {
            RetirarVehiculo();
        }

        public void RetirarVehiculo()
        {
            try
            {
                entApar._SCedJuParqueo = cmbParqueoParaRetirarCarro.SelectedValue.ToString();
                entApar._SCedulaUsuario = txtCedClienteRetira.Text;
                if (rdTipoRetiraCarro.Checked)
                    entApar._STipoVehiculo = "Carro";
                else
                    entApar._STipoVehiculo = "Moto";

                entApar._SPlacaVehiculo = txtPlacaRetiraVehiculo.Text;
                entApar._DtFechaHoraSalida = DateTime.Now;
                entApar._BEstadVehiculo = true;

                if (negApar.SalirAparcado(entApar))
                {
                    MessageBox.Show("Se ha liberado correctamente el vehiculo del parqueo", "Aparcado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("No se ha liberado correctamente", "Aparcado", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error", "Ingreso Parqueo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
