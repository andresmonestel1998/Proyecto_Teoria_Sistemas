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
    }
}
