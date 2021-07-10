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
    public partial class frm_registro : Form
    {
        #region instancias
        cl_neg_Rol negRol = new cl_neg_Rol();
        cl_neg_Usuario negUser = new cl_neg_Usuario();
        cl_ent_Usuario entUser = new cl_ent_Usuario();
        #endregion

        public frm_registro()
        {
            InitializeComponent();
            cmbRolNuevo.SelectedIndex = 0;
            
        }
        private void tabRegistro_Click(object sender, EventArgs e)
        {
            if (tabRegistro.SelectedTab == tabSalir)
            {
                if (MessageBox.Show("Desea cerrar sesión?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                    frm_login log = new frm_login();
                    log.Show();
                }
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
                    entUser._SCedulaUsuario = txtCedNuevo.Text;
                    entUser._SNombre = txtNomNuevo.Text;
                    entUser._STelefono = txtTelNuevo.Text;
                    entUser._SCorreo = txtEmailNuevo.Text;
                    entUser._SContrasena = txtContraNuevo.Text;
                    entUser._IIdRol = Convert.ToInt32(cmbRolNuevo.SelectedValue)+1;

                    if (negUser.NuevoUser(entUser))
                    {
                        dataGridConsultaUsuario.DataSource = negUser.BuscarUser(txtCedNuevo.Text);
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
            txtNomNuevo.Text = "";
            txtCedNuevo.Text = "";
            txtTelNuevo.Text = "";
            txtEmailNuevo.Text = "";
            txtContraNuevo.Text = "";
        }
    }
}
