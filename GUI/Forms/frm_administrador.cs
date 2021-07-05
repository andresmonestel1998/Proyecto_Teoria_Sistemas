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

namespace GUI.Forms
{
    public partial class frm_administrador : Form
    {
        cl_neg_Rol negRol = new cl_neg_Rol();
        public frm_administrador(String nombre, String apellidos)
        {
            InitializeComponent();
            this.Text = "Bienvenido: " + nombre + " " + apellidos;
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
    }
}
