using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Entidades;
using Negocios.NegociosLogin;


namespace GUI.Forms
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cls_neg_login negLog = new cls_neg_login();
            cl_ent_Usuario entUsuario = new cl_ent_Usuario();

            entUsuario._SCorreo=txtUsuario.Text.ToString();
            entUsuario._SContrasena = txtContra.Text.ToString();

            try
            {
                DataTable tablaUsuarios = new DataTable();
                tablaUsuarios = negLog.DatosLogin(entUsuario);

                if (negLog.DatosLogin(entUsuario)!=null)
                {
                    if (tablaUsuarios.Rows[0][0].ToString().Equals("Administrador"))
                    {
                        frm_administrador openAdmin = new frm_administrador(tablaUsuarios.Rows[0][1].ToString());
                        openAdmin.Show();
                        this.Hide();
                    }
                    else if(tablaUsuarios.Rows[0][0].ToString().Equals("Invitado"))
                    {
                        frm_usuarios openUser = new frm_usuarios(tablaUsuarios.Rows[0][1].ToString(), tablaUsuarios.Rows[0][0].ToString());
                        openUser.Show();
                        this.Hide();
                    }
                    else if(tablaUsuarios.Rows[0][0].ToString().Equals("Cliente"))
                    {
                        frm_usuarios openUser = new frm_usuarios(tablaUsuarios.Rows[0][1].ToString(), tablaUsuarios.Rows[0][0].ToString());
                        openUser.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña no corresponden!\n Intente de nuevo.", " Alerta",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido un error " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_registro registro = new frm_registro();
            registro.Show();
            this.Hide();
        }

        private void lk_Invitado_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_usuarios usuario = new frm_usuarios("Invitado", "Invitado");
            usuario.Show();
            this.Hide();
        }
    }
}
