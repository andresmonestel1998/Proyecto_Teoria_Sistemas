
namespace GUI.Forms
{
    partial class frm_registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabRegistro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridConsultaUsuario = new System.Windows.Forms.DataGridView();
            this.btnLimpiarNuevoUsuario = new System.Windows.Forms.Button();
            this.btnGuardarNuevoUsuario = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbRolNuevo = new System.Windows.Forms.ComboBox();
            this.txtContraNuevo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelNuevo = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCedNuevo = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmailNuevo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNomNuevo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabSalir = new System.Windows.Forms.TabPage();
            this.tabRegistro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaUsuario)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabRegistro
            // 
            this.tabRegistro.Controls.Add(this.tabPage1);
            this.tabRegistro.Controls.Add(this.tabSalir);
            this.tabRegistro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabRegistro.Location = new System.Drawing.Point(0, 0);
            this.tabRegistro.Name = "tabRegistro";
            this.tabRegistro.SelectedIndex = 0;
            this.tabRegistro.Size = new System.Drawing.Size(1487, 638);
            this.tabRegistro.TabIndex = 0;
            this.tabRegistro.Click += new System.EventHandler(this.tabRegistro_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridConsultaUsuario);
            this.tabPage1.Controls.Add(this.btnLimpiarNuevoUsuario);
            this.tabPage1.Controls.Add(this.btnGuardarNuevoUsuario);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1479, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Crear Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridConsultaUsuario
            // 
            this.dataGridConsultaUsuario.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridConsultaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConsultaUsuario.Location = new System.Drawing.Point(526, 30);
            this.dataGridConsultaUsuario.Name = "dataGridConsultaUsuario";
            this.dataGridConsultaUsuario.ReadOnly = true;
            this.dataGridConsultaUsuario.RowHeadersWidth = 51;
            this.dataGridConsultaUsuario.RowTemplate.Height = 24;
            this.dataGridConsultaUsuario.Size = new System.Drawing.Size(847, 424);
            this.dataGridConsultaUsuario.TabIndex = 37;
            // 
            // btnLimpiarNuevoUsuario
            // 
            this.btnLimpiarNuevoUsuario.Location = new System.Drawing.Point(142, 471);
            this.btnLimpiarNuevoUsuario.Name = "btnLimpiarNuevoUsuario";
            this.btnLimpiarNuevoUsuario.Size = new System.Drawing.Size(90, 34);
            this.btnLimpiarNuevoUsuario.TabIndex = 33;
            this.btnLimpiarNuevoUsuario.Text = "Limpiar";
            this.btnLimpiarNuevoUsuario.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNuevoUsuario
            // 
            this.btnGuardarNuevoUsuario.Location = new System.Drawing.Point(23, 471);
            this.btnGuardarNuevoUsuario.Name = "btnGuardarNuevoUsuario";
            this.btnGuardarNuevoUsuario.Size = new System.Drawing.Size(103, 34);
            this.btnGuardarNuevoUsuario.TabIndex = 32;
            this.btnGuardarNuevoUsuario.Text = "Guardar";
            this.btnGuardarNuevoUsuario.UseVisualStyleBackColor = true;
            this.btnGuardarNuevoUsuario.Click += new System.EventHandler(this.btnGuardarNuevoUsuario_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbRolNuevo);
            this.groupBox2.Controls.Add(this.txtContraNuevo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTelNuevo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtCedNuevo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtEmailNuevo);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtNomNuevo);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(19, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 373);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // cmbRolNuevo
            // 
            this.cmbRolNuevo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRolNuevo.FormattingEnabled = true;
            this.cmbRolNuevo.Items.AddRange(new object[] {
            "Cliente"});
            this.cmbRolNuevo.Location = new System.Drawing.Point(106, 309);
            this.cmbRolNuevo.Name = "cmbRolNuevo";
            this.cmbRolNuevo.Size = new System.Drawing.Size(205, 24);
            this.cmbRolNuevo.TabIndex = 6;
            // 
            // txtContraNuevo
            // 
            this.txtContraNuevo.Location = new System.Drawing.Point(106, 252);
            this.txtContraNuevo.Name = "txtContraNuevo";
            this.txtContraNuevo.Size = new System.Drawing.Size(205, 22);
            this.txtContraNuevo.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Rol:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Nombre completo:";
            // 
            // txtTelNuevo
            // 
            this.txtTelNuevo.Location = new System.Drawing.Point(106, 146);
            this.txtTelNuevo.Mask = "9999-9999";
            this.txtTelNuevo.Name = "txtTelNuevo";
            this.txtTelNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtTelNuevo.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Cédula:";
            // 
            // txtCedNuevo
            // 
            this.txtCedNuevo.Location = new System.Drawing.Point(106, 92);
            this.txtCedNuevo.Mask = "9-9999-9999";
            this.txtCedNuevo.Name = "txtCedNuevo";
            this.txtCedNuevo.Size = new System.Drawing.Size(100, 22);
            this.txtCedNuevo.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Teléfono:";
            // 
            // txtEmailNuevo
            // 
            this.txtEmailNuevo.Location = new System.Drawing.Point(106, 200);
            this.txtEmailNuevo.Name = "txtEmailNuevo";
            this.txtEmailNuevo.Size = new System.Drawing.Size(205, 22);
            this.txtEmailNuevo.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "Email:";
            // 
            // txtNomNuevo
            // 
            this.txtNomNuevo.Location = new System.Drawing.Point(172, 43);
            this.txtNomNuevo.Name = "txtNomNuevo";
            this.txtNomNuevo.Size = new System.Drawing.Size(281, 22);
            this.txtNomNuevo.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 257);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Contraseña:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(158, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 25);
            this.label14.TabIndex = 35;
            this.label14.Text = "Nuevo Usuario";
            // 
            // tabSalir
            // 
            this.tabSalir.Location = new System.Drawing.Point(4, 25);
            this.tabSalir.Name = "tabSalir";
            this.tabSalir.Padding = new System.Windows.Forms.Padding(3);
            this.tabSalir.Size = new System.Drawing.Size(1479, 609);
            this.tabSalir.TabIndex = 1;
            this.tabSalir.Text = "Salir";
            this.tabSalir.UseVisualStyleBackColor = true;
            // 
            // frm_registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 638);
            this.Controls.Add(this.tabRegistro);
            this.Name = "frm_registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registro";
            this.tabRegistro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConsultaUsuario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabRegistro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabSalir;
        private System.Windows.Forms.DataGridView dataGridConsultaUsuario;
        private System.Windows.Forms.Button btnLimpiarNuevoUsuario;
        private System.Windows.Forms.Button btnGuardarNuevoUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbRolNuevo;
        private System.Windows.Forms.TextBox txtContraNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtTelNuevo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtCedNuevo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmailNuevo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNomNuevo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}