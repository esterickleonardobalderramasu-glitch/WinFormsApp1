namespace PROYECTO_PROGRA
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txt_correo = new TextBox();
            txt_contraseña = new TextBox();
            btn_login = new Button();
            button2 = new Button();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.DarkGray;
            label1.Location = new Point(207, 111);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese su correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(178, 149);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 1;
            label2.Text = "Ingrese su contraseña";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(337, 104);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(183, 27);
            txt_correo.TabIndex = 2;
            txt_correo.TextChanged += txt_correo_TextChanged;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(337, 142);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.PasswordChar = '*';
            txt_contraseña.Size = new Size(183, 27);
            txt_contraseña.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Navy;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(235, 237);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(94, 29);
            btn_login.TabIndex = 4;
            btn_login.Text = "Ingresar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.White;
            button2.Location = new Point(426, 237);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(286, 33);
            label3.Name = "label3";
            label3.Size = new Size(234, 41);
            label3.TabIndex = 6;
            label3.Text = "Inicio de sesión";
            // 
            // button1
            // 
            button1.BackColor = Color.Navy;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(645, 409);
            button1.Name = "button1";
            button1.Size = new Size(143, 29);
            button1.TabIndex = 7;
            button1.Text = "salir del programa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(btn_login);
            Controls.Add(txt_contraseña);
            Controls.Add(txt_correo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "S";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_correo;
        private TextBox txt_contraseña;
        private Button btn_login;
        private Button button2;
        private Label label3;
        private Button button1;
    }
}
