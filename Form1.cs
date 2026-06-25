using MySql.Data.MySqlClient;

using System;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class Form1 : Form
    {

        string cadenaConexion = "Server=localhost;Port=3306;Database=new_schema1;Uid=root;Pwd=26080405;";

        public Form1()
        {
            InitializeComponent();
        }

        //CARGA EL FORMULARIO
        private void Form1_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    MessageBox.Show(
                        "Conexión exitosa a MySQL",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al conectar: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion =
                new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    // CONSULTA SQL
                    string consulta = @"
            SELECT u.Id, c.correo
            FROM usuarios u
            INNER JOIN correos c
            ON u.Id = c.IdUsuario
            WHERE c.correo = @correo
            AND u.Contraseña = @pass";

                    MySqlCommand cmd =
                        new MySqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue(
                        "@correo",
                        txt_correo.Text.Trim());

                    cmd.Parameters.AddWithValue(
                        "@pass",
                        int.Parse(txt_contraseña.Text));

                    MySqlDataReader reader =
                        cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        // ID DEL USUARIO
                        int idUsuario =
                            reader.GetInt32("id");

                        // CORREO
                        string correo =
                            reader.GetString("correo");

                        // SI ES ALUMNO
                        if (correo.ToUpper().Contains("ALM"))
                        {
                            FormAlumno alumno =
                                new FormAlumno(idUsuario);

                            alumno.Show();
                            this.Hide();
                        }

                        // SI ES DOCENTE
                        else if (correo.ToLower().Contains("dc"))
                        {
                            FormProfesor profesor =
                                new FormProfesor();

                            profesor.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            "Correo o contraseña incorrectos",
                            "ERROR",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "La contraseña debe ser numérica",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        ex.Message,
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txt_correo.Clear();
            txt_contraseña.Clear();

            txt_correo.Focus();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_correo_TextChanged(object sender, EventArgs e)
        {


        }
       
    }
}