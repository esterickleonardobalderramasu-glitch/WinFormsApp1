using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private Estudiante estudianteActivo;
        private List<Asignatura> materiasDisponibles;

        public Form1()
        {
            InitializeComponent();
            InicializarComponentesEspeciales();
            EstilizarPantalla();
        }

        private void InicializarComponentesEspeciales()
        {
            estudianteActivo = new Estudiante("2026-001", "Ana Flores");

            materiasDisponibles = new List<Asignatura>
            {
                new Asignatura("ING1", "Ingles"),
                new Asignatura("MATE1", "Álgebra"),
                new Asignatura("FISC1", "Física")
            };

            cmbMaterias.DataSource = materiasDisponibles;
            cmbMaterias.DisplayMember = "Nombre";
            cmbMaterias.ValueMember = "Codigo";

            if (materiasDisponibles.Count > 0)
            {
                RenderizarDatosMateria(materiasDisponibles[0].Codigo);
            }
        }

        private void EstilizarPantalla()
        {
            this.BackColor = Color.FromArgb(243, 244, 246);
            this.Font = new Font("Segoe UI", 10F);
            this.Text = $"Gestión Académica - {estudianteActivo.Nombre}";

            lblTitulo.ForeColor = Color.FromArgb(17, 24, 39);

            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.BackColor = Color.FromArgb(37, 99, 235);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAgregar.Cursor = Cursors.Hand;

            dgvNotas.BackgroundColor = Color.White;
            dgvNotas.BorderStyle = BorderStyle.None;
            dgvNotas.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvNotas.GridColor = Color.FromArgb(229, 231, 235);
            dgvNotas.RowHeadersVisible = false;
            dgvNotas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotas.RowTemplate.Height = 35;

            dgvNotas.EnableHeadersVisualStyles = false;
            dgvNotas.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(31, 41, 55);
            dgvNotas.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvNotas.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvNotas.ColumnHeadersHeight = 38;

            lblPromedio.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            numNota.Minimum = 0;
            numNota.Maximum = 100;

            numPorcentaje.Minimum = 1;
            numPorcentaje.Maximum = 100;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Asignatura materia = (Asignatura)cmbMaterias.SelectedItem;
                if (materia == null) return;

                double nota = (double)numNota.Value;
                double peso = (double)numPorcentaje.Value / 100;

                estudianteActivo.AgregarNota(materia, nota, peso);

                RenderizarDatosMateria(materia.Codigo);

                numNota.Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMaterias.SelectedItem is Asignatura materia)
            {
                RenderizarDatosMateria(materia.Codigo);
            }
        }

        private void RenderizarDatosMateria(string codigoMateria)
        {
            var notasGrid = estudianteActivo.Notas
                .Where(n => n.Materia.Codigo.Trim().ToUpper() == codigoMateria.Trim().ToUpper())
                .Select(n => new {
                    Materia = n.Materia.Nombre,
                    Nota = n.Valor,
                    Peso = $"{n.Porcentaje * 100}%"
                }).ToList();

            dgvNotas.DataSource = null;
            dgvNotas.DataSource = notasGrid;

            if (notasGrid.Any())
            {
                double sumaPonderada = estudianteActivo.Notas
                    .Where(n => n.Materia.Codigo.Trim().ToUpper() == codigoMateria.Trim().ToUpper())
                    .Sum(n => n.Valor * n.Porcentaje);

                double sumaPorcentajes = estudianteActivo.Notas
                    .Where(n => n.Materia.Codigo.Trim().ToUpper() == codigoMateria.Trim().ToUpper())
                    .Sum(n => n.Porcentaje);

                double promedio = sumaPonderada / (sumaPorcentajes > 0 ? sumaPorcentajes : 1);

                if (promedio >= 61)
                {
                    lblPromedio.Text = $"Promedio Final: {promedio:F2}  [ APROBADO ]";
                    lblPromedio.ForeColor = Color.FromArgb(22, 163, 74);
                }
                else
                {
                    lblPromedio.Text = $"Promedio Final: {promedio:F2}  [ REPROBADO ]";
                    lblPromedio.ForeColor = Color.FromArgb(220, 38, 38);
                }
            }
            else
            {
                lblPromedio.Text = "Promedio Final: 0.00  [ SIN NOTAS ]";
                lblPromedio.ForeColor = Color.FromArgb(107, 114, 128);
            }
        }
    }

    public class Asignatura
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public Asignatura(string codigo, string nombre) { Codigo = codigo; Nombre = nombre; }
    }

    public class Calificacion
    {
        public Asignatura Materia { get; set; }
        public double Valor { get; set; }
        public double Porcentaje { get; set; }

        public Calificacion(Asignatura materia, double valor, double porcentaje)
        {
            if (valor < 0 || valor > 100) throw new ArgumentException("La nota debe estar entre 0 y 100.");
            Materia = materia;
            Valor = valor;
            Porcentaje = porcentaje;
        }
    }

    public class Estudiante
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public List<Calificacion> Notas { get; private set; }

        public Estudiante(string id, string nombre)
        {
            Id = id;
            Nombre = nombre;
            Notas = new List<Calificacion>();
        }

        public void AgregarNota(Asignatura materia, double valor, double porcentaje)
        {
            double acumulado = Notas.Where(n => n.Materia.Codigo == materia.Codigo).Sum(n => n.Porcentaje);

            if (acumulado + porcentaje > 1.0)
                throw new InvalidOperationException($"Operación denegada: Las notas existentes para esta materia ya suman el {acumulado * 100}%. No puedes exceder el 100%.");

            Notas.Add(new Calificacion(materia, valor, porcentaje));
        }

        public double CalcularPromedioPorMateria(string codigoMateria)
        {
            var notasMateria = Notas.Where(n => n.Materia.Codigo == codigoMateria).ToList();
            if (!notasMateria.Any()) return 0;

            double sumaPonderada = notasMateria.Sum(n => n.Valor * n.Porcentaje);
            double sumaPorcentajes = notasMateria.Sum(n => n.Porcentaje);

            return sumaPonderada / (sumaPorcentajes > 0 ? sumaPorcentajes : 1);
        }
    }
}