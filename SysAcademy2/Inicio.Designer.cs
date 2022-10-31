namespace SysAcademy
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btn_Sesion;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            this.btn_Profe = new System.Windows.Forms.Button();
            this.btn_Alum = new System.Windows.Forms.Button();
            btn_Sesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sesion
            // 
            btn_Sesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Sesion.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_Sesion.Location = new System.Drawing.Point(360, 129);
            btn_Sesion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btn_Sesion.Name = "btn_Sesion";
            btn_Sesion.Size = new System.Drawing.Size(92, 27);
            btn_Sesion.TabIndex = 0;
            btn_Sesion.Text = "Iniciar Sesion";
            btn_Sesion.UseVisualStyleBackColor = false;
            btn_Sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constraseña :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(98, 45);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(251, 23);
            this.txt_name.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.HideSelection = false;
            this.txt_password.Location = new System.Drawing.Point(98, 83);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(251, 23);
            this.txt_password.TabIndex = 5;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(12, 135);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(20, 23);
            this.btn_Admin.TabIndex = 7;
            this.btn_Admin.Text = "A";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // btn_Profe
            // 
            this.btn_Profe.Location = new System.Drawing.Point(38, 135);
            this.btn_Profe.Name = "btn_Profe";
            this.btn_Profe.Size = new System.Drawing.Size(20, 23);
            this.btn_Profe.TabIndex = 8;
            this.btn_Profe.Text = "P";
            this.btn_Profe.UseVisualStyleBackColor = true;
            this.btn_Profe.Click += new System.EventHandler(this.btn_Profe_Click);
            // 
            // btn_Alum
            // 
            this.btn_Alum.Location = new System.Drawing.Point(64, 135);
            this.btn_Alum.Name = "btn_Alum";
            this.btn_Alum.Size = new System.Drawing.Size(28, 23);
            this.btn_Alum.TabIndex = 9;
            this.btn_Alum.Text = "Al";
            this.btn_Alum.UseVisualStyleBackColor = true;
            this.btn_Alum.Click += new System.EventHandler(this.btn_Alum_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(467, 170);
            this.Controls.Add(this.btn_Alum);
            this.Controls.Add(this.btn_Profe);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btn_Sesion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(483, 209);
            this.MinimumSize = new System.Drawing.Size(483, 209);
            this.Name = "Inicio";
            this.Text = "Ingreso UTN";
            this.Activated += new System.EventHandler(this.Inicio_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
        private Button btn_Admin;
        private Button btn_Profe;
        private Button btn_Alum;
    }
}

