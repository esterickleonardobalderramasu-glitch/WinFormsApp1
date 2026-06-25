using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PROYECTO_PROGRA
{
    public partial class FormENTRALM : Form
    {
        string cadenaConexion =
        "Server=localhost;Port=3306;Database=new_schema1;Uid=root;Pwd=26080405;";

        int idAlumno;

        // Constructor parameterless necesario para el diseñador
        public FormENTRALM()
        {
            InitializeComponent();
        }

        // Constructor usado en tiempo de ejecución para recibir idAlumno
        public FormENTRALM(int idAlumnoRecibido) : this()
        {
            idAlumno = idAlumnoRecibido;
        }

        private void FormENTRALM_Load(object sender, EventArgs e)
        {
            // Evitar ejecución en tiempo de diseño
            if (System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime)
                return;

            // Asignar recursos de imagen en tiempo de ejecución
            try
            {
                this.BackgroundImage = Properties.Resources.descarga_img_3;
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch { }

            CargarEntrevistas();
        }

        private void CargarEntrevistas()
        {
            using (MySqlConnection conexion =
                new MySqlConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string consulta = @"
                    SELECT
                    Titulo,
                    Descripcion,
                    Fecha
                    FROM entrevistas
                    WHERE IdAlumno = @idAlumno";

                    MySqlCommand cmd =
                        new MySqlCommand(consulta, conexion);

                    cmd.Parameters.AddWithValue(
                        "@idAlumno",
                        idAlumno);
                    MessageBox.Show(idAlumno.ToString());
                    MySqlDataAdapter da =
                        new MySqlDataAdapter(cmd);

                    DataTable dt =
                        new DataTable();

                    da.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FormAlumno ventana = new FormAlumno();
            ventana.Show();
            this.Hide();

        }
    }
}