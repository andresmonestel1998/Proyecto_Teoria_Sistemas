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
        public frm_usuarios(String nombre, string tipoUser)
        {
            InitializeComponent();
            this.Text = "Bienvenido: " + nombre;

            if (tipoUser.Equals("Invitado"))
            {
                tbControlUsuarios.TabPages.Remove(tabCancelar);
                tbControlUsuarios.TabPages.Remove(tabAparcarCliente);
                tbControlUsuarios.TabPages.Remove(tabReservar);
            }
            else
            {
                tbControlUsuarios.TabPages.Remove(tabAparcarInvitado);
            }
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
