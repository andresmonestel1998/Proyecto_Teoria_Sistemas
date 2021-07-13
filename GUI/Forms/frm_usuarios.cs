using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios.NegociosParqueo;
using Negocios.NegociosUsuario;
using GUI.Forms;

namespace GUI.Forms
{
    public partial class frm_usuarios : Form
    {
        #region Instancias
        cl_neg_Parqueo negPar = new cl_neg_Parqueo();
        cl_neg_Usuario negUser = new cl_neg_Usuario();
        #endregion

        #region Armazon
        public frm_usuarios(String nombre, string tipoUser,string cedula)
        {
            InitializeComponent();
            txtCedulaCliente.Text = cedula;
            if(tipoUser != "Invitado")
            { CargarDatosCliente(); }
            cmbCargarParqueoCliente.DataSource = negPar.consultarPark();
            cmbCargarParqueoCliente.DisplayMember = "v_nombre";
            cmbCargarParqueoCliente.ValueMember = "v_CedulaJuridicaParqueo";
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
        #endregion

        #region Salir
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
        #endregion

        #region LimpiarAparcarCliente
        private void btn_LimpiarAparcharCliente_Click(object sender, EventArgs e)
        {
            
            txtPlacaVehiculoCliente.Text = "";
            txtMarcaVehiculoCliente.Text = "";
            txtModeloVehiculoCliente.Text = "";
        }

        #endregion

        #region AparcarVehiculoCliente
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
        public void CargarDatosCliente()
        {
            DataTable usuario = new DataTable();
            usuario = buscaCliente(txtCedulaCliente.Text);
            if (usuario.Rows.Count != 0)
            {
                txtNombreCliente.Text = usuario.Rows[0][1].ToString();
                txtCorreoCliente.Text = usuario.Rows[0][2].ToString();
                txtTelefonoCliente.Text = usuario.Rows[0][3].ToString();

            }
            else
                MessageBox.Show("Aún no hay información cargada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        #endregion

        private void btn_AparcarCliente_Click(object sender, EventArgs e)
        {
            
        }


    }
}
