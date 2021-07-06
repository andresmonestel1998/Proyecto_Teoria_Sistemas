
namespace GUI.Forms
{
    partial class frm_usuarios
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
            this.tbControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabReservar = new System.Windows.Forms.TabPage();
            this.tabCancelar = new System.Windows.Forms.TabPage();
            this.tabSalir = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbControlUsuarios.SuspendLayout();
            this.tabCancelar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlUsuarios
            // 
            this.tbControlUsuarios.Controls.Add(this.tabReservar);
            this.tbControlUsuarios.Controls.Add(this.tabCancelar);
            this.tbControlUsuarios.Controls.Add(this.tabSalir);
            this.tbControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbControlUsuarios.Name = "tbControlUsuarios";
            this.tbControlUsuarios.SelectedIndex = 0;
            this.tbControlUsuarios.Size = new System.Drawing.Size(1054, 644);
            this.tbControlUsuarios.TabIndex = 0;
            this.tbControlUsuarios.Click += new System.EventHandler(this.tbControlUsuarios_Click);
            // 
            // tabReservar
            // 
            this.tabReservar.Location = new System.Drawing.Point(4, 25);
            this.tabReservar.Name = "tabReservar";
            this.tabReservar.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservar.Size = new System.Drawing.Size(1046, 615);
            this.tabReservar.TabIndex = 0;
            this.tabReservar.Text = "Reservar";
            this.tabReservar.UseVisualStyleBackColor = true;
            // 
            // tabCancelar
            // 
            this.tabCancelar.Controls.Add(this.label2);
            this.tabCancelar.Controls.Add(this.label1);
            this.tabCancelar.Location = new System.Drawing.Point(4, 25);
            this.tabCancelar.Name = "tabCancelar";
            this.tabCancelar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCancelar.Size = new System.Drawing.Size(1046, 615);
            this.tabCancelar.TabIndex = 1;
            this.tabCancelar.Text = "Cancelar reservaciones";
            this.tabCancelar.UseVisualStyleBackColor = true;
            // 
            // tabSalir
            // 
            this.tabSalir.Location = new System.Drawing.Point(4, 25);
            this.tabSalir.Name = "tabSalir";
            this.tabSalir.Size = new System.Drawing.Size(1046, 615);
            this.tabSalir.TabIndex = 2;
            this.tabSalir.Text = "Salir";
            this.tabSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 644);
            this.Controls.Add(this.tbControlUsuarios);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_usuarios";
            this.tbControlUsuarios.ResumeLayout(false);
            this.tabCancelar.ResumeLayout(false);
            this.tabCancelar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlUsuarios;
        private System.Windows.Forms.TabPage tabReservar;
        private System.Windows.Forms.TabPage tabCancelar;
        private System.Windows.Forms.TabPage tabSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}