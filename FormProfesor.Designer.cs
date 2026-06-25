namespace PROYECTO_PROGRA
{
    partial class FormProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfesor));
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            label2 = new Label();
            txt_loginregress = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel4 = new Panel();
            button7 = new Button();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(337, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 74);
            label1.TabIndex = 0;
            label1.Text = "materias";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateBlue;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_loginregress);
            panel1.Dock = DockStyle.Left;
            panel1.ForeColor = Color.DarkSlateBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 450);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(61, 268);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 9;
            button1.Text = "📝 notas";
            button1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(3, 418);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 8;
            button5.Text = "↩️  Salir";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(61, 189);
            button4.Name = "button4";
            button4.Size = new Size(125, 37);
            button4.TabIndex = 7;
            button4.Text = "👥  Entrevistas";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Location = new Point(61, 121);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 6;
            button2.Text = "📅  Calendario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Transparent;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 5;
            label2.Text = "☰  Menú ";
            // 
            // txt_loginregress
            // 
            txt_loginregress.ImageAlign = ContentAlignment.MiddleLeft;
            txt_loginregress.Location = new Point(61, 54);
            txt_loginregress.Name = "txt_loginregress";
            txt_loginregress.Size = new Size(125, 29);
            txt_loginregress.TabIndex = 1;
            txt_loginregress.Text = "🏠 Inicio";
            txt_loginregress.TextImageRelation = TextImageRelation.ImageBeforeText;
            txt_loginregress.UseVisualStyleBackColor = true;
            txt_loginregress.Click += txt_loginregress_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.Transparent;
            flowLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(250, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(758, 450);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox3);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(291, 149);
            panel4.TabIndex = 5;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = (Image)resources.GetObject("button7.BackgroundImage");
            button7.Location = new Point(0, 65);
            button7.Name = "button7";
            button7.Size = new Size(273, 81);
            button7.TabIndex = 3;
            button7.Text = "ENTRAR";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SimSun", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(86, 45);
            label7.Name = "label7";
            label7.Size = new Size(161, 17);
            label7.TabIndex = 2;
            label7.Text = "Profesor: Ivanoff";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(67, 62);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Emoji", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Transparent;
            label8.Location = new Point(48, 6);
            label8.Name = "label8";
            label8.Size = new Size(238, 31);
            label8.TabIndex = 1;
            label8.Text = "  💻 Programacion 6B";
            // 
            // FormProfesor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1008, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormProfesor";
            Text = "FormProfesor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button txt_loginregress;
        private Label label2;
        private Button button2;
        private Button button4;
        private Button button1;
        private Button button5;
        private Panel panel4;
        private Button button7;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
    }
}