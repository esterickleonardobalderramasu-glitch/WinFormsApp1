using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class Formhorariocs : Form
    {
        public Formhorariocs()
        {
            InitializeComponent();
        }

        public Formhorariocs(int idAlumno)
        {
            InitializeComponent();
            // si hace falta, guarda idAlumno
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtHorario.Text =
        "Hora      Lunes          Martes         Miércoles      Jueves         Viernes\r\n" +
        "-----------------------------------------------------------------------------\r\n" +
        "08:00     Matemáticas    Lenguaje       Matemáticas    Física         Inglés\r\n" +
        "09:00     Física         Matemáticas    Historia        Matemáticas    Computación\r\n" +
        "10:00     Historia       Inglés         Lenguaje        Biología       Matemáticas\r\n" +
        "11:00     Recreo         Recreo         Recreo          Recreo         Recreo\r\n" +
        "11:30     Computación    Física         Inglés          Historia       Lenguaje\r\n" +
        "12:30     Educación F.   Biología       Computación     Inglés         Tutoría";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAlumno ventana = new FormAlumno();
            ventana.Show();
            this.Hide();
        }
    }
}
