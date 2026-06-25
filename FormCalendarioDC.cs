using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class FormCalendarioDC : Form
    {
        public FormCalendarioDC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormProfesor ventana = new FormProfesor();
            ventana.Show();
            this.Hide();
        }
    }
}
