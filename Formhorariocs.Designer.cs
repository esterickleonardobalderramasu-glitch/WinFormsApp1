namespace PROYECTO_PROGRA
{
    partial class Formhorariocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtHorario = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtHorario
            // 
            txtHorario.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtHorario.Location = new Point(1, 6);
            txtHorario.Multiline = true;
            txtHorario.Name = "txtHorario";
            txtHorario.ScrollBars = ScrollBars.Vertical;
            txtHorario.Size = new Size(787, 442);
            txtHorario.TabIndex = 0;
            txtHorario.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(669, 419);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "↩️  regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Formhorariocs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtHorario);
            Name = "Formhorariocs";
            Text = "Formhorariocs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHorario;
        private Button button1;
    }
}