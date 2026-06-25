using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class FormCalendarioALM : Form
    {
        public FormCalendarioALM()
        {
            InitializeComponent();
        }

        // Sobrecarga que acepta idAlumno
        public FormCalendarioALM(int idAlumno)
        {
            InitializeComponent();
            // Si necesitas usar idAlumno, almacénalo en un campo
        }

        private void btn_calendarioregres_Click(object sender, EventArgs e)
        {
            FormAlumno ventana = new FormAlumno();
            ventana.Show();
            this.Hide();
        }
    }
}
