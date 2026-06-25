namespace PROYECTO_PROGRA
{
    partial class FormENTRDC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormENTRDC));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ID_alumno = new Label();
            label2 = new Label();
            txt_idALM = new TextBox();
            txt_titulo = new TextBox();
            RTX_nota = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(703, 419);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = " 📤 Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(363, 419);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "\U0001f9f9 limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(0, 419);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "⬅️ Regresar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ID_alumno
            // 
            ID_alumno.AutoSize = true;
            ID_alumno.BackColor = Color.Transparent;
            ID_alumno.ForeColor = Color.White;
            ID_alumno.Location = new Point(186, 73);
            ID_alumno.Name = "ID_alumno";
            ID_alumno.Size = new Size(171, 20);
            ID_alumno.TabIndex = 3;
            ID_alumno.Text = "ingrese el ID del alumno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(310, 130);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Titulo";
            // 
            // txt_idALM
            // 
            txt_idALM.Location = new Point(363, 66);
            txt_idALM.Name = "txt_idALM";
            txt_idALM.Size = new Size(125, 27);
            txt_idALM.TabIndex = 5;
            // 
            // txt_titulo
            // 
            txt_titulo.Location = new Point(363, 130);
            txt_titulo.Name = "txt_titulo";
            txt_titulo.Size = new Size(125, 27);
            txt_titulo.TabIndex = 6;
            // 
            // RTX_nota
            // 
            RTX_nota.Location = new Point(280, 209);
            RTX_nota.Name = "RTX_nota";
            RTX_nota.Size = new Size(254, 191);
            RTX_nota.TabIndex = 7;
            RTX_nota.Text = "";
            RTX_nota.TextChanged += RTX_nota_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(280, 163);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // FormENTRDC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker1);
            Controls.Add(RTX_nota);
            Controls.Add(txt_titulo);
            Controls.Add(txt_idALM);
            Controls.Add(label2);
            Controls.Add(ID_alumno);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormENTRDC";
            Text = "FormENTRDC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label ID_alumno;
        private Label label2;
        private TextBox txt_idALM;
        private TextBox txt_titulo;
        private RichTextBox RTX_nota;
        private DateTimePicker dateTimePicker1;
    }
}