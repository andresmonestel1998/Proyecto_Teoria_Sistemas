﻿using System;
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
            txt_Calle.Text.Equals("") ||
            txtTelParuqeo.Text.Equals("    -"))
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
            txtTelParuqeo.Text = "";
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
                    entPar._STelefono = txtTelParuqeo.Text;

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
                    tabSubParqueo.SelectedIndex = 2;
                    txtEditParqueoCedula.Text = dataGridBuscaParqueo.CurrentRow.Cells[0].Value.ToString();
                    txtEditParqueoNombre.Text = dataGridBuscaParqueo.CurrentRow.Cells[1].Value.ToString();
                    txtEditParqueoProvincia.Text = dataGridBuscaParqueo.CurrentRow.Cells[2].Value.ToString();
                    txtEditParqueoCanton.Text = dataGridBuscaParqueo.CurrentRow.Cells[3].Value.ToString();
                    txtEditParqueoDistrito.Text = dataGridBuscaParqueo.CurrentRow.Cells[4].Value.ToString();
                    txtEditParqueoCalle.Text = dataGridBuscaParqueo.CurrentRow.Cells[5].Value.ToString();
                    txtEditParqueoTelefono.Text = dataGridBuscaParqueo.CurrentRow.Cells[6].Value.ToString();
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

        #endregion


    }
}
