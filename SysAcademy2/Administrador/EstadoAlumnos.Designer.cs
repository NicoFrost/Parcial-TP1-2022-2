namespace SysAcademy2
{
    partial class EstadoAlumnos
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
            this.btn_Modify = new System.Windows.Forms.Button();
            this.rbtn_Regular = new System.Windows.Forms.RadioButton();
            this.rbtn_Libre = new System.Windows.Forms.RadioButton();
            this.lb_Alumnos = new System.Windows.Forms.ListBox();
            this.lb_materias = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Modify
            // 
            this.btn_Modify.Location = new System.Drawing.Point(364, 347);
            this.btn_Modify.Name = "btn_Modify";
            this.btn_Modify.Size = new System.Drawing.Size(70, 26);
            this.btn_Modify.TabIndex = 0;
            this.btn_Modify.Text = "Modificar";
            this.btn_Modify.UseVisualStyleBackColor = true;
            this.btn_Modify.Click += new System.EventHandler(this.btn_Modify_Click);
            // 
            // rbtn_Regular
            // 
            this.rbtn_Regular.AutoSize = true;
            this.rbtn_Regular.Location = new System.Drawing.Point(12, 351);
            this.rbtn_Regular.Name = "rbtn_Regular";
            this.rbtn_Regular.Size = new System.Drawing.Size(65, 19);
            this.rbtn_Regular.TabIndex = 1;
            this.rbtn_Regular.Text = "Regular";
            this.rbtn_Regular.UseVisualStyleBackColor = true;
            // 
            // rbtn_Libre
            // 
            this.rbtn_Libre.AutoSize = true;
            this.rbtn_Libre.Location = new System.Drawing.Point(112, 351);
            this.rbtn_Libre.Name = "rbtn_Libre";
            this.rbtn_Libre.Size = new System.Drawing.Size(51, 19);
            this.rbtn_Libre.TabIndex = 2;
            this.rbtn_Libre.Text = "Libre";
            this.rbtn_Libre.UseVisualStyleBackColor = true;
            // 
            // lb_Alumnos
            // 
            this.lb_Alumnos.FormattingEnabled = true;
            this.lb_Alumnos.ItemHeight = 15;
            this.lb_Alumnos.Location = new System.Drawing.Point(12, 172);
            this.lb_Alumnos.Name = "lb_Alumnos";
            this.lb_Alumnos.Size = new System.Drawing.Size(422, 169);
            this.lb_Alumnos.TabIndex = 3;
            // 
            // lb_materias
            // 
            this.lb_materias.FormattingEnabled = true;
            this.lb_materias.ItemHeight = 15;
            this.lb_materias.Location = new System.Drawing.Point(12, 12);
            this.lb_materias.Name = "lb_materias";
            this.lb_materias.Size = new System.Drawing.Size(422, 154);
            this.lb_materias.TabIndex = 4;
            this.lb_materias.SelectedIndexChanged += new System.EventHandler(this.lb_materias_SelectedIndexChanged);
            // 
            // EstadoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(446, 386);
            this.Controls.Add(this.lb_materias);
            this.Controls.Add(this.lb_Alumnos);
            this.Controls.Add(this.rbtn_Libre);
            this.Controls.Add(this.rbtn_Regular);
            this.Controls.Add(this.btn_Modify);
            this.Name = "EstadoAlumnos";
            this.Text = "EstadoAlumnos";
            this.Load += new System.EventHandler(this.EstadoAlumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Modify;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ListBox lb_Alumnos;
        private ListBox lb_materias;
        private RadioButton rbtn_Regular;
        private RadioButton rbtn_Libre;
    }
}