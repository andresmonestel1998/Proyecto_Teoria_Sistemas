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

namespace GUI.Forms
{
    public partial class frm_administrador : Form
    {
        #region instancias
            cl_neg_Rol negRol = new cl_neg_Rol();
            cl_neg_Usuario negUser = new cl_neg_Usuario();
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
    }
}
