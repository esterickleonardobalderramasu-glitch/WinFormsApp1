using PROYECTO_PROGRA.Fomr1.cs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class FormAlumno : Form
    {
        int idAlumno;

        public FormAlumno()
        {
            InitializeComponent();
        }

        public FormAlumno(int idAlumnoRecibido)
        {
            InitializeComponent();
            idAlumno = idAlumnoRecibido;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_loginregress_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCalendarioALM ventana = new FormCalendarioALM(idAlumno);
            ventana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Formhorariocs ventana = new Formhorariocs(idAlumno);
            ventana.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormENTRALM ventana = new FormENTRALM(idAlumno);
            ventana.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Formmateria1 ventana = new Formmateria1();
            ventana.Show();
            this.Hide();
         }
    }
}