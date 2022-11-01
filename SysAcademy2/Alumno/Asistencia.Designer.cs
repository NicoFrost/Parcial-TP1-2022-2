namespace SysAcademy2
{
    partial class Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.FCal_diaAsistencia = new System.Windows.Forms.MonthCalendar();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FCal_diaAsistencia
            // 
            this.FCal_diaAsistencia.Location = new System.Drawing.Point(29, 18);
            this.FCal_diaAsistencia.MaximumSize = new System.Drawing.Size(248, 162);
            this.FCal_diaAsistencia.MinimumSize = new System.Drawing.Size(248, 162);
            this.FCal_diaAsistencia.Name = "FCal_diaAsistencia";
            this.FCal_diaAsistencia.TabIndex = 0;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(200, 197);
            this.btn_Aceptar.MaximumSize = new System.Drawing.Size(95, 23);
            this.btn_Aceptar.MinimumSize = new System.Drawing.Size(95, 23);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(95, 23);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Asistencia
            // 
            this.AcceptButton = this.btn_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(307, 232);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.FCal_diaAsistencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(323, 271);
            this.MinimumSize = new System.Drawing.Size(323, 271);
            this.Name = "Asistencia";
            this.Text = "Seleccionar fechca de asistencia";
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar FCal_diaAsistencia;
        private Button btn_cancel;
        private Button btn_Aceptar;
    }
}