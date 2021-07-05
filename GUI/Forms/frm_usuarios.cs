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
    public partial class frm_usuarios : Form
    {
        public frm_usuarios(String nombre, String apellidos)
        {
            InitializeComponent();
            this.Text = "Bienvenido: " + nombre + " " + apellidos;
        }

        private void tbControlUsuarios_Click(object sender, EventArgs e)
        {
            if (tbControlUsuarios.SelectedTab == tabSalir)
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
