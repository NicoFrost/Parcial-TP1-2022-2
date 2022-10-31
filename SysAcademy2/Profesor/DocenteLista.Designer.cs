namespace SysAcademy2
{
    partial class DocenteLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocenteLista));
            this.lb_Examenes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Fecha = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.btn_Modify = new System.Windows.Forms.Button();
            this.btn_Revisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Profesor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Examenes
            // 
            this.lb_Examenes.FormattingEnabled = true;
            this.lb_Examenes.ItemHeight = 15;
            this.lb_Examenes.Items.AddRange(new object[] {
            ""});
            this.lb_Examenes.Location = new System.Drawing.Point(13, 11);
            this.lb_Examenes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lb_Examenes.Name = "lb_Examenes";
            this.lb_Examenes.Size = new System.Drawing.Size(181, 229);
            this.lb_Examenes.TabIndex = 3;
            this.lb_Examenes.Click += new System.EventHandler(this.lb_Examenes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(223, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha";
            // 
            // lbl_Fecha
            // 
            this.lbl_Fecha.AutoSize = true;
            this.lbl_Fecha.Location = new System.Drawing.Point(383, 61);
            this.lbl_Fecha.Name = "lbl_Fecha";
            this.lbl_Fecha.Size = new System.Drawing.Size(38, 15);
            this.lbl_Fecha.TabIndex = 10;
            this.lbl_Fecha.Text = "label7";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(383, 26);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(38, 15);
            this.lbl_Nombre.TabIndex = 11;
            this.lbl_Nombre.Text = "label8";
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(223, 196);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(75, 44);
            this.btn_Modify.TabIndex = 12;
            this.btn_Modify.Text = "Modificar";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // btn_Revisar
            // 
            this.btn_Revisar.Location = new System.Drawing.Point(404, 196);
            this.btn_Revisar.Name = "btn_Revisar";
            this.btn_Revisar.Size = new System.Drawing.Size(75, 44);
            this.btn_Revisar.TabIndex = 13;
            this.btn_Revisar.Text = "Revisar Examen";
            this.btn_Revisar.UseVisualStyleBackColor = true;
            this.btn_Revisar.Click += new System.EventHandler(this.btn_Revisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(223, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Profesor Asignador:";
            // 
            // lbl_Profesor
            // 
            this.lbl_Profesor.AutoSize = true;
            this.lbl_Profesor.Location = new System.Drawing.Point(383, 96);
            this.lbl_Profesor.Name = "lbl_Profesor";
            this.lbl_Profesor.Size = new System.Drawing.Size(51, 15);
            this.lbl_Profesor.TabIndex = 15;
            this.lbl_Profesor.Text = "Profesor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Materia: ";
            // 
            // lbl_Materia
            // 
            this.lbl_Materia.AutoSize = true;
            this.lbl_Materia.Location = new System.Drawing.Point(383, 131);
            this.lbl_Materia.Name = "lbl_Materia";
            this.lbl_Materia.Size = new System.Drawing.Size(47, 15);
            this.lbl_Materia.TabIndex = 17;
            this.lbl_Materia.Text = "Materia";
            // 
            // DocenteLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Goldenrod;
            this.ClientSize = new System.Drawing.Size(491, 252);
            this.Controls.Add(this.lbl_Materia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Profesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Revisar);
            this.Controls.Add(this.btn_Modify);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.lbl_Fecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Examenes);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(507, 291);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(507, 291);
            this.Name = "DocenteLista";
            this.Text = "DocenteLista";
            this.Load += new System.EventHandler(this.DocenteLista_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_Examenes;
        private Label label1;
        private Label label4;
        private Label lbl_Fecha;
        private Label lbl_Nombre;
        private Button btn_Modify;
        private Button btn_Revisar;
        private Label label2;
        private Label lbl_Profesor;
        private Label label3;
        private Label lbl_Materia;
    }
}