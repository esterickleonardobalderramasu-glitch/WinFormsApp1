namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            label1 = new Label();
            cmbMaterias = new ComboBox();
            label2 = new Label();
            numNota = new NumericUpDown();
            label3 = new Label();
            numPorcentaje = new NumericUpDown();
            btnAgregar = new Button();
            dgvNotas = new DataGridView();
            lblPromedio = new Label();
            ((System.ComponentModel.ISupportInitialize)numNota).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(376, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PANEL DE CALIFICACIONES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 69);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 1;
            label1.Text = "Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(115, 66);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(151, 28);
            cmbMaterias.TabIndex = 2;
            cmbMaterias.SelectedIndexChanged += cmbMaterias_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 97);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "Nota(0-100)";
            // 
            // numNota
            // 
            numNota.Location = new Point(115, 120);
            numNota.Name = "numNota";
            numNota.Size = new Size(150, 27);
            numNota.TabIndex = 4;
            numNota.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(141, 160);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 5;
            label3.Text = "Porcentaje%";
            // 
            // numPorcentaje
            // 
            numPorcentaje.Location = new Point(116, 183);
            numPorcentaje.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numPorcentaje.Name = "numPorcentaje";
            numPorcentaje.Size = new Size(150, 27);
            numPorcentaje.TabIndex = 6;
            numPorcentaje.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(116, 255);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(150, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar Nota";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvNotas
            // 
            dgvNotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotas.Location = new Point(384, 12);
            dgvNotas.Name = "dgvNotas";
            dgvNotas.RowHeadersWidth = 51;
            dgvNotas.Size = new Size(628, 319);
            dgvNotas.TabIndex = 8;
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(399, 296);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(102, 20);
            lblPromedio.TabIndex = 9;
            lblPromedio.Text = "promedio0.00";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 343);
            Controls.Add(lblPromedio);
            Controls.Add(dgvNotas);
            Controls.Add(btnAgregar);
            Controls.Add(numPorcentaje);
            Controls.Add(label3);
            Controls.Add(numNota);
            Controls.Add(label2);
            Controls.Add(cmbMaterias);
            Controls.Add(label1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numNota).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPorcentaje).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvNotas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label label1;
        private ComboBox cmbMaterias;
        private Label label2;
        private NumericUpDown numNota;
        private Label label3;
        private NumericUpDown numPorcentaje;
        private Button btnAgregar;
        private DataGridView dgvNotas;
        private Label lblPromedio;
    }
}
