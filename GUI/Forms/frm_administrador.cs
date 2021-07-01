using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class frm_administrador : Form
    {
        public frm_administrador(String nombre, String apellidos)
        {
            
            InitializeComponent();
            this.Text = "Bienvenido: " + nombre + " " + apellidos;
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
