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
using Entidades.Entidades;

namespace GUI.Forms
{
    public partial class frm_administrador : Form
    {
        #region instancias
        cl_neg_Rol negRol = new cl_neg_Rol();
        cl_neg_Usuario negUser = new cl_neg_Usuario();
        cl_ent_Usuario entUser = new cl_ent_Usuario();
        #endregion

        #region constructor
            public frm_administrador(String nombre)
            {
                InitializeComponent();
                this.Text = "Bienvenido: " + nombre;
                txtIdRol.Text = negRol.cargarIDRol();
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
            }
        #endregion

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
        public Boolean ValidarCamposNuevo()
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
                if (ValidarCamposNuevo())
                {
                    entUser._SCedulaUsuario=txtCedNuevo.Text;
                    entUser._SNombre=txtNomNuevo.Text;
                    entUser._STelefono = txtTelNuevo.Text;
                    entUser._SCorreo= txtEmailNuevo.Text;
                    entUser._SContrasena= txtContraNuevo.Text;
                    entUser._IIdRol=Convert.ToInt32(cmbRolNuevo.SelectedValue);

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

        private void btnBuscarEspecifica_Click(object sender, EventArgs e)
        {
            DataTable taTempo = new DataTable();
            try
            {
                taTempo = negUser.BuscarUser(txtCeduBuscar.Text.ToString());
                if (taTempo != null)
                    dataGridBuscar.DataSource = taTempo;
                else
                    MessageBox.Show("No se han encontrado resultado ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error, " + ex.Message);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridBuscar.DataSource != null)
            {
                try
                {
                    SubEmpleados.SelectedIndex = 2;
                    txtNomEditar.Text = dataGridBuscar.CurrentRow.Cells[1].Value.ToString();
                    txtCedEditar.Text = dataGridBuscar.CurrentRow.Cells[0].Value.ToString();
                    txtEmailEditar.Text = dataGridBuscar.CurrentRow.Cells[2].Value.ToString();
                    txtTelEditar.Text = dataGridBuscar.CurrentRow.Cells[3].Value.ToString();
                    txtContraEditar.Text = dataGridBuscar.CurrentRow.Cells[4].Value.ToString();
                    cmRolEditar.Text = dataGridBuscar.CurrentRow.Cells[5].Value.ToString();
                    btnModificaUsuario.Enabled = true;
                    dataGridBuscar.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error " + ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Aún no hay información cargada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public Boolean ValidarCamposEditar()
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
            if (ValidarCamposEditar())
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
    }
}
