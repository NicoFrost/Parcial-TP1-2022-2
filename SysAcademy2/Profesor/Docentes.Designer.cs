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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Docentes));
            this.fcal_Eleccion = new System.Windows.Forms.MonthCalendar();
            this.lb_Examenes = new System.Windows.Forms.ListBox();
            this.btn_CExamen = new System.Windows.Forms.Button();
            this.txt_NombreExamen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_Materia = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // fcal_Eleccion
            // 
            this.fcal_Eleccion.BackColor = System.Drawing.Color.LightCoral;
            this.fcal_Eleccion.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.fcal_Eleccion.Location = new System.Drawing.Point(19, 62);
            this.fcal_Eleccion.Margin = new System.Windows.Forms.Padding(10);
            this.fcal_Eleccion.Name = "fcal_Eleccion";
            this.fcal_Eleccion.TabIndex = 0;
            this.fcal_Eleccion.TitleBackColor = System.Drawing.SystemColors.Highlight;
            // 
            // lb_Examenes
            // 
            this.lb_Examenes.FormattingEnabled = true;
            this.lb_Examenes.ItemHeight = 15;
            this.lb_Examenes.Items.AddRange(new object[] {
            ""});
            this.lb_Examenes.Location = new System.Drawing.Point(533, 62);
            this.lb_Examenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_Examenes.Name = "lb_Examenes";
            this.lb_Examenes.Size = new System.Drawing.Size(268, 244);
            this.lb_Examenes.TabIndex = 2;
            this.lb_Examenes.Click += new System.EventHandler(this.lb_Examenes_Click);
            this.lb_Examenes.SelectedIndexChanged += new System.EventHandler(this.lb_Examenes_SelectedIndexChanged);
            // 
            // btn_CExamen
            // 
            this.btn_CExamen.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_CExamen.Location = new System.Drawing.Point(533, 314);
            this.btn_CExamen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CExamen.Name = "btn_CExamen";
            this.btn_CExamen.Size = new System.Drawing.Size(268, 57);
            this.btn_CExamen.TabIndex = 3;
            this.btn_CExamen.Text = "Crear Examen";
            this.btn_CExamen.UseVisualStyleBackColor = true;
            this.btn_CExamen.Click += new System.EventHandler(this.btn_CExamen_Click);
            // 
            // txt_NombreExamen
            // 
            this.txt_NombreExamen.Location = new System.Drawing.Point(19, 26);
            this.txt_NombreExamen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_NombreExamen.Name = "txt_NombreExamen";
            this.txt_NombreExamen.Size = new System.Drawing.Size(181, 23);
            this.txt_NombreExamen.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre del Examen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lista de Examenes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Materia:";
            // 
            // cb_Materia
            // 
            this.cb_Materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Materia.FormattingEnabled = true;
            this.cb_Materia.Location = new System.Drawing.Point(207, 26);
            this.cb_Materia.Name = "cb_Materia";
            this.cb_Materia.Size = new System.Drawing.Size(181, 23);
            this.cb_Materia.TabIndex = 9;
            // 
            // Docentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(814, 391);
            this.Controls.Add(this.cb_Materia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_NombreExamen);
            this.Controls.Add(this.btn_CExamen);
            this.Controls.Add(this.lb_Examenes);
            this.Controls.Add(this.fcal_Eleccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Docentes";
            this.Text = "Docentes";
            this.Load += new System.EventHandler(this.Docentes_Load);
            this.Shown += new System.EventHandler(this.Docentes_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar fcal_Eleccion;
        private System.Windows.Forms.TextBox txt_NombreExamen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public Button btn_CExamen;
        public ListBox lb_Examenes;
        private Label label3;
        private ComboBox cb_Materia;
    }
}