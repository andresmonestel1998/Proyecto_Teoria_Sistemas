
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabSalir = new System.Windows.Forms.TabPage();
            this.tabAparcarCliente = new System.Windows.Forms.TabPage();
            this.tabRetirarVehiculo = new System.Windows.Forms.TabPage();
            this.gBoxClientes = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.tabAparcarInvitado = new System.Windows.Forms.TabPage();
            this.gBoxInvitados = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label61 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbControlUsuarios.SuspendLayout();
            this.tabCancelar.SuspendLayout();
            this.tabAparcarCliente.SuspendLayout();
            this.gBoxClientes.SuspendLayout();
            this.tabAparcarInvitado.SuspendLayout();
            this.gBoxInvitados.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlUsuarios
            // 
            this.tbControlUsuarios.Controls.Add(this.tabReservar);
            this.tbControlUsuarios.Controls.Add(this.tabCancelar);
            this.tbControlUsuarios.Controls.Add(this.tabAparcarCliente);
            this.tbControlUsuarios.Controls.Add(this.tabAparcarInvitado);
            this.tbControlUsuarios.Controls.Add(this.tabRetirarVehiculo);
            this.tbControlUsuarios.Controls.Add(this.tabSalir);
            this.tbControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbControlUsuarios.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlUsuarios.Location = new System.Drawing.Point(0, 0);
            this.tbControlUsuarios.Name = "tbControlUsuarios";
            this.tbControlUsuarios.SelectedIndex = 0;
            this.tbControlUsuarios.Size = new System.Drawing.Size(1259, 815);
            this.tbControlUsuarios.TabIndex = 0;
            this.tbControlUsuarios.Click += new System.EventHandler(this.tbControlUsuarios_Click);
            // 
            // tabReservar
            // 
            this.tabReservar.Location = new System.Drawing.Point(4, 32);
            this.tabReservar.Name = "tabReservar";
            this.tabReservar.Padding = new System.Windows.Forms.Padding(3);
            this.tabReservar.Size = new System.Drawing.Size(1163, 779);
            this.tabReservar.TabIndex = 0;
            this.tabReservar.Text = "Reservar campos";
            this.tabReservar.UseVisualStyleBackColor = true;
            // 
            // tabCancelar
            // 
            this.tabCancelar.Controls.Add(this.label2);
            this.tabCancelar.Controls.Add(this.label1);
            this.tabCancelar.Location = new System.Drawing.Point(4, 32);
            this.tabCancelar.Name = "tabCancelar";
            this.tabCancelar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCancelar.Size = new System.Drawing.Size(1163, 779);
            this.tabCancelar.TabIndex = 1;
            this.tabCancelar.Text = "Cancelar reservaciones";
            this.tabCancelar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // tabSalir
            // 
            this.tabSalir.Location = new System.Drawing.Point(4, 32);
            this.tabSalir.Name = "tabSalir";
            this.tabSalir.Size = new System.Drawing.Size(1163, 779);
            this.tabSalir.TabIndex = 2;
            this.tabSalir.Text = "Salir";
            this.tabSalir.UseVisualStyleBackColor = true;
            // 
            // tabAparcarCliente
            // 
            this.tabAparcarCliente.Controls.Add(this.label5);
            this.tabAparcarCliente.Controls.Add(this.label6);
            this.tabAparcarCliente.Controls.Add(this.gBoxClientes);
            this.tabAparcarCliente.Location = new System.Drawing.Point(4, 32);
            this.tabAparcarCliente.Name = "tabAparcarCliente";
            this.tabAparcarCliente.Size = new System.Drawing.Size(1251, 779);
            this.tabAparcarCliente.TabIndex = 3;
            this.tabAparcarCliente.Text = "Aparcar vehículo cliente";
            this.tabAparcarCliente.UseVisualStyleBackColor = true;
            // 
            // tabRetirarVehiculo
            // 
            this.tabRetirarVehiculo.Location = new System.Drawing.Point(4, 32);
            this.tabRetirarVehiculo.Name = "tabRetirarVehiculo";
            this.tabRetirarVehiculo.Size = new System.Drawing.Size(1163, 779);
            this.tabRetirarVehiculo.TabIndex = 4;
            this.tabRetirarVehiculo.Text = "Retirar vehículo";
            this.tabRetirarVehiculo.UseVisualStyleBackColor = true;
            // 
            // gBoxClientes
            // 
            this.gBoxClientes.Controls.Add(this.dateTimePicker1);
            this.gBoxClientes.Controls.Add(this.textBox10);
            this.gBoxClientes.Controls.Add(this.textBox9);
            this.gBoxClientes.Controls.Add(this.label59);
            this.gBoxClientes.Controls.Add(this.label58);
            this.gBoxClientes.Controls.Add(this.label50);
            this.gBoxClientes.Controls.Add(this.textBox4);
            this.gBoxClientes.Controls.Add(this.radioButton2);
            this.gBoxClientes.Controls.Add(this.radioButton1);
            this.gBoxClientes.Controls.Add(this.label48);
            this.gBoxClientes.Controls.Add(this.label49);
            this.gBoxClientes.Controls.Add(this.button5);
            this.gBoxClientes.Controls.Add(this.button4);
            this.gBoxClientes.Controls.Add(this.textBox3);
            this.gBoxClientes.Controls.Add(this.textBox2);
            this.gBoxClientes.Controls.Add(this.textBox1);
            this.gBoxClientes.Controls.Add(this.button1);
            this.gBoxClientes.Controls.Add(this.maskedTextBox2);
            this.gBoxClientes.Controls.Add(this.label47);
            this.gBoxClientes.Controls.Add(this.label46);
            this.gBoxClientes.Controls.Add(this.label45);
            this.gBoxClientes.Controls.Add(this.label44);
            this.gBoxClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxClientes.Location = new System.Drawing.Point(3, 3);
            this.gBoxClientes.Name = "gBoxClientes";
            this.gBoxClientes.Size = new System.Drawing.Size(689, 723);
            this.gBoxClientes.TabIndex = 1;
            this.gBoxClientes.TabStop = false;
            this.gBoxClientes.Text = "Clientes";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "HH:mm:ss tt";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 511);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(175, 28);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(102, 441);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(141, 28);
            this.textBox10.TabIndex = 23;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(102, 377);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(141, 28);
            this.textBox9.TabIndex = 22;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(19, 444);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(79, 24);
            this.label59.TabIndex = 21;
            this.label59.Text = "Modelo:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(19, 383);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(67, 24);
            this.label58.TabIndex = 20;
            this.label58.Text = "Marca:";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(19, 515);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(136, 24);
            this.label50.TabIndex = 19;
            this.label50.Text = "Fecha Ingresa:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(102, 315);
            this.textBox4.MaxLength = 6;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(105, 28);
            this.textBox4.TabIndex = 18;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(230, 255);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 28);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Carro";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(361, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(126, 28);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.Text = "Motocicleta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(19, 259);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(129, 24);
            this.label48.TabIndex = 13;
            this.label48.Text = "Tipo vehículo:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(19, 321);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(61, 24);
            this.label49.TabIndex = 12;
            this.label49.Text = "Placa:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(515, 658);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 49);
            this.button5.TabIndex = 11;
            this.button5.Text = "Limpiar datos";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 658);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Aparcar vehículo";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(176, 201);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(311, 28);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(176, 152);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(311, 28);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(230, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 28);
            this.textBox1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar cliente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(287, 52);
            this.maskedTextBox2.Mask = "9-9999-9999";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 28);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(19, 56);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(250, 24);
            this.label47.TabIndex = 4;
            this.label47.Text = "Ingrese la cédula del cliente:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(19, 158);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(73, 24);
            this.label46.TabIndex = 3;
            this.label46.Text = "Correo:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(19, 207);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(90, 24);
            this.label45.TabIndex = 2;
            this.label45.Text = "Telefono:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(19, 110);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(175, 24);
            this.label44.TabIndex = 1;
            this.label44.Text = "Nombre del cliente:";
            // 
            // tabAparcarInvitado
            // 
            this.tabAparcarInvitado.Controls.Add(this.label4);
            this.tabAparcarInvitado.Controls.Add(this.label3);
            this.tabAparcarInvitado.Controls.Add(this.gBoxInvitados);
            this.tabAparcarInvitado.Location = new System.Drawing.Point(4, 32);
            this.tabAparcarInvitado.Name = "tabAparcarInvitado";
            this.tabAparcarInvitado.Padding = new System.Windows.Forms.Padding(3);
            this.tabAparcarInvitado.Size = new System.Drawing.Size(1251, 779);
            this.tabAparcarInvitado.TabIndex = 5;
            this.tabAparcarInvitado.Text = "Aparcar vehículo Invitado";
            this.tabAparcarInvitado.UseVisualStyleBackColor = true;
            // 
            // gBoxInvitados
            // 
            this.gBoxInvitados.Controls.Add(this.button8);
            this.gBoxInvitados.Controls.Add(this.button9);
            this.gBoxInvitados.Controls.Add(this.dateTimePicker2);
            this.gBoxInvitados.Controls.Add(this.textBox11);
            this.gBoxInvitados.Controls.Add(this.label51);
            this.gBoxInvitados.Controls.Add(this.textBox12);
            this.gBoxInvitados.Controls.Add(this.textBox5);
            this.gBoxInvitados.Controls.Add(this.label60);
            this.gBoxInvitados.Controls.Add(this.radioButton3);
            this.gBoxInvitados.Controls.Add(this.label61);
            this.gBoxInvitados.Controls.Add(this.radioButton4);
            this.gBoxInvitados.Controls.Add(this.label52);
            this.gBoxInvitados.Controls.Add(this.label53);
            this.gBoxInvitados.Controls.Add(this.textBox6);
            this.gBoxInvitados.Controls.Add(this.textBox7);
            this.gBoxInvitados.Controls.Add(this.textBox8);
            this.gBoxInvitados.Controls.Add(this.maskedTextBox3);
            this.gBoxInvitados.Controls.Add(this.label54);
            this.gBoxInvitados.Controls.Add(this.label55);
            this.gBoxInvitados.Controls.Add(this.label56);
            this.gBoxInvitados.Controls.Add(this.label57);
            this.gBoxInvitados.Enabled = false;
            this.gBoxInvitados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxInvitados.Location = new System.Drawing.Point(3, 0);
            this.gBoxInvitados.Name = "gBoxInvitados";
            this.gBoxInvitados.Size = new System.Drawing.Size(735, 723);
            this.gBoxInvitados.TabIndex = 21;
            this.gBoxInvitados.TabStop = false;
            this.gBoxInvitados.Text = "Invitados";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(560, 658);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(158, 49);
            this.button8.TabIndex = 26;
            this.button8.Text = "Limpiar datos";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(377, 658);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(167, 49);
            this.button9.TabIndex = 25;
            this.button9.Text = "Aparcar vehículo";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(183, 510);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(352, 28);
            this.dateTimePicker2.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(105, 440);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(141, 28);
            this.textBox11.TabIndex = 27;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(19, 515);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(136, 24);
            this.label51.TabIndex = 19;
            this.label51.Text = "Fecha Ingresa:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(105, 383);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(141, 28);
            this.textBox12.TabIndex = 26;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 321);
            this.textBox5.MaxLength = 6;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(105, 28);
            this.textBox5.TabIndex = 18;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(19, 444);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(79, 24);
            this.label60.TabIndex = 25;
            this.label60.Text = "Modelo:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(214, 255);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 28);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Carro";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(19, 383);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(67, 24);
            this.label61.TabIndex = 24;
            this.label61.Text = "Marca:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(345, 256);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(126, 28);
            this.radioButton4.TabIndex = 16;
            this.radioButton4.Text = "Motocicleta";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(19, 259);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(129, 24);
            this.label52.TabIndex = 13;
            this.label52.Text = "Tipo vehículo:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(19, 321);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(61, 24);
            this.label53.TabIndex = 12;
            this.label53.Text = "Placa:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(160, 202);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(311, 28);
            this.textBox6.TabIndex = 9;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(160, 153);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(311, 28);
            this.textBox7.TabIndex = 8;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(214, 104);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(257, 28);
            this.textBox8.TabIndex = 7;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(293, 51);
            this.maskedTextBox3.Mask = "9-9999-9999";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(100, 28);
            this.maskedTextBox3.TabIndex = 5;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(19, 56);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(250, 24);
            this.label54.TabIndex = 4;
            this.label54.Text = "Ingrese la cédula del cliente:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(19, 158);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(73, 24);
            this.label55.TabIndex = 3;
            this.label55.Text = "Correo:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(19, 207);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(90, 24);
            this.label56.TabIndex = 2;
            this.label56.Text = "Telefono:";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(19, 110);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(175, 24);
            this.label57.TabIndex = 1;
            this.label57.Text = "Nombre del cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(777, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(416, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Cantidad de espacios disponibles en el parqueo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(928, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(894, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(743, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cantidad de espacios disponibles en el parqueo:";
            // 
            // frm_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 815);
            this.Controls.Add(this.tbControlUsuarios);
            this.Name = "frm_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_usuarios";
            this.tbControlUsuarios.ResumeLayout(false);
            this.tabCancelar.ResumeLayout(false);
            this.tabCancelar.PerformLayout();
            this.tabAparcarCliente.ResumeLayout(false);
            this.tabAparcarCliente.PerformLayout();
            this.gBoxClientes.ResumeLayout(false);
            this.gBoxClientes.PerformLayout();
            this.tabAparcarInvitado.ResumeLayout(false);
            this.tabAparcarInvitado.PerformLayout();
            this.gBoxInvitados.ResumeLayout(false);
            this.gBoxInvitados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlUsuarios;
        private System.Windows.Forms.TabPage tabReservar;
        private System.Windows.Forms.TabPage tabCancelar;
        private System.Windows.Forms.TabPage tabSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabAparcarCliente;
        private System.Windows.Forms.TabPage tabRetirarVehiculo;
        private System.Windows.Forms.GroupBox gBoxClientes;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TabPage tabAparcarInvitado;
        private System.Windows.Forms.GroupBox gBoxInvitados;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}