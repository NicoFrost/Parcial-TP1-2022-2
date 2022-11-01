namespace SysAcademy
{
    partial class Docentes
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
            this.fcal_Eleccion = new System.Windows.Forms.MonthCalendar();
            this.btn_RExamen = new System.Windows.Forms.Button();
            this.lb_Examenes = new System.Windows.Forms.ListBox();
            this.btn_CExamen = new System.Windows.Forms.Button();
            this.txt_NombreExamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fcal_Eleccion
            // 
            this.fcal_Eleccion.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.fcal_Eleccion.Location = new System.Drawing.Point(18, 18);
            this.fcal_Eleccion.Name = "fcal_Eleccion";
            this.fcal_Eleccion.TabIndex = 0;
            // 
            // btn_RExamen
            // 
            this.btn_RExamen.Location = new System.Drawing.Point(530, 280);
            this.btn_RExamen.Name = "btn_RExamen";
            this.btn_RExamen.Size = new System.Drawing.Size(75, 47);
            this.btn_RExamen.TabIndex = 1;
            this.btn_RExamen.Text = "Revisar Examen";
            this.btn_RExamen.UseVisualStyleBackColor = true;
            this.btn_RExamen.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Examenes
            // 
            this.lb_Examenes.FormattingEnabled = true;
            this.lb_Examenes.Items.AddRange(new object[] {
            ""});
            this.lb_Examenes.Location = new System.Drawing.Point(530, 75);
            this.lb_Examenes.Name = "lb_Examenes";
            this.lb_Examenes.Size = new System.Drawing.Size(156, 199);
            this.lb_Examenes.TabIndex = 2;
            this.lb_Examenes.Click += new System.EventHandler(this.lb_Examenes_Click);
            // 
            // btn_CExamen
            // 
            this.btn_CExamen.Location = new System.Drawing.Point(611, 280);
            this.btn_CExamen.Name = "btn_CExamen";
            this.btn_CExamen.Size = new System.Drawing.Size(75, 49);
            this.btn_CExamen.TabIndex = 3;
            this.btn_CExamen.Text = "Crear Examen";
            this.btn_CExamen.UseVisualStyleBackColor = true;
            this.btn_CExamen.Click += new System.EventHandler(this.btn_CExamen_Click);
            // 
            // txt_NombreExamen
            // 
            this.txt_NombreExamen.Location = new System.Drawing.Point(530, 34);
            this.txt_NombreExamen.Name = "txt_NombreExamen";
            this.txt_NombreExamen.Size = new System.Drawing.Size(156, 20);
            this.txt_NombreExamen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Examenes";
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 339);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreExamen);
            this.Controls.Add(this.btn_CExamen);
            this.Controls.Add(this.lb_Examenes);
            this.Controls.Add(this.btn_RExamen);
            this.Controls.Add(this.fcal_Eleccion);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar fcal_Eleccion;
        private System.Windows.Forms.Button btn_RExamen;
        private System.Windows.Forms.ListBox lb_Examenes;
        private System.Windows.Forms.Button btn_CExamen;
        private System.Windows.Forms.TextBox txt_NombreExamen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}