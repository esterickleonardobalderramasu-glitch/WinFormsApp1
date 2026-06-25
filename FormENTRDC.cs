using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class FormENTRDC : Form
    {

        string cadenaConexion =
        "Server=localhost;Port=3306;Database=new_schema1;Uid=root;Pwd=26080405;";

        public FormENTRDC()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion =
                new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string consulta = @"
                    INSERT INTO entrevistas
                    (IdAlumno, Titulo, Descripcion, Fecha)
                    VALUES
                    (@idAlumno, @titulo, @descripcion, @fecha)";

                    MySqlCommand cmd =
                        new MySqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue(
                        "@idAlumno",
                        int.Parse(txt_idALM.Text));

                    cmd.Parameters.AddWithValue(
                        "@titulo",
                        txt_titulo.Text);

                    cmd.Parameters.AddWithValue(
                        "@descripcion",
                        RTX_nota.Text);

                    cmd.Parameters.AddWithValue(
                        "@fecha",
                        dateTimePicker1.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show(
                        "Entrevista enviada correctamente");


                    txt_idALM.Clear();
                    txt_titulo.Clear();
                    RTX_nota.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txt_idALM.Clear();
            txt_titulo.Clear();
            RTX_nota.Clear();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            FormProfesor ventana = new FormProfesor();
            ventana.Show();
            this.Hide();
        }

        private void RTX_nota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
