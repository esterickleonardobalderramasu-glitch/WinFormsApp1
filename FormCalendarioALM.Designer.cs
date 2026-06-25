namespace PROYECTO_PROGRA
{
    partial class FormCalendarioALM
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
            monthCalendar1 = new MonthCalendar();
            btn_calendarioregres = new Button();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.CalendarDimensions = new Size(3, 2);
            monthCalendar1.Location = new Point(0, 4);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // btn_calendarioregres
            // 
            btn_calendarioregres.Location = new Point(669, 369);
            btn_calendarioregres.Name = "btn_calendarioregres";
            btn_calendarioregres.Size = new Size(119, 29);
            btn_calendarioregres.TabIndex = 1;
            btn_calendarioregres.Text = "↩️  Regresar";
            btn_calendarioregres.UseVisualStyleBackColor = true;
            btn_calendarioregres.Click += btn_calendarioregres_Click;
            // 
            // FormCalendario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 399);
            Controls.Add(btn_calendarioregres);
            Controls.Add(monthCalendar1);
            Name = "FormCalendario";
            Text = "FormCalendario";
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Button btn_calendarioregres;
    }
}