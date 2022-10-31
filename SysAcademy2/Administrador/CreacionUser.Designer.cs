namespace SysAcademy
{
    partial class CreacionUser
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
            this.btn_Create = new System.Windows.Forms.Button();
            this.txtB_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB_User = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.rb_Admin = new System.Windows.Forms.RadioButton();
            this.rb_Profesor = new System.Windows.Forms.RadioButton();
            this.rb_Alumno = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btn_Create
            // 
            this.btn_Create.Location = new System.Drawing.Point(344, 175);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Crear";
            this.btn_Create.UseVisualStyleBackColor = true;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // txtB_Password
            // 
            this.txtB_Password.Location = new System.Drawing.Point(122, 48);
            this.txtB_Password.Name = "txtB_Password";
            this.txtB_Password.Size = new System.Drawing.Size(297, 20);
            this.txtB_Password.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Permisos : ";
            // 
            // txtB_User
            // 
            this.txtB_User.Location = new System.Drawing.Point(122, 12);
            this.txtB_User.Name = "txtB_User";
            this.txtB_User.Size = new System.Drawing.Size(297, 20);
            this.txtB_User.TabIndex = 7;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(263, 175);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "Cancelar";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // rb_Admin
            // 
            this.rb_Admin.AutoSize = true;
            this.rb_Admin.BackColor = System.Drawing.Color.Transparent;
            this.rb_Admin.Location = new System.Drawing.Point(122, 89);
            this.rb_Admin.Name = "rb_Admin";
            this.rb_Admin.Size = new System.Drawing.Size(88, 17);
            this.rb_Admin.TabIndex = 10;
            this.rb_Admin.Text = "Administrador";
            this.rb_Admin.UseVisualStyleBackColor = false;
            // 
            // rb_Profesor
            // 
            this.rb_Profesor.AutoSize = true;
            this.rb_Profesor.BackColor = System.Drawing.Color.Transparent;
            this.rb_Profesor.Location = new System.Drawing.Point(216, 89);
            this.rb_Profesor.Name = "rb_Profesor";
            this.rb_Profesor.Size = new System.Drawing.Size(64, 17);
            this.rb_Profesor.TabIndex = 11;
            this.rb_Profesor.TabStop = true;
            this.rb_Profesor.Text = "Profesor";
            this.rb_Profesor.UseVisualStyleBackColor = false;
            // 
            // rb_Alumno
            // 
            this.rb_Alumno.AutoSize = true;
            this.rb_Alumno.BackColor = System.Drawing.Color.Transparent;
            this.rb_Alumno.Location = new System.Drawing.Point(286, 89);
            this.rb_Alumno.Name = "rb_Alumno";
            this.rb_Alumno.Size = new System.Drawing.Size(60, 17);
            this.rb_Alumno.TabIndex = 12;
            this.rb_Alumno.TabStop = true;
            this.rb_Alumno.Text = "Alumno";
            this.rb_Alumno.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 210);
            this.Controls.Add(this.rb_Alumno);
            this.Controls.Add(this.rb_Profesor);
            this.Controls.Add(this.rb_Admin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.txtB_User);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB_Password);
            this.Controls.Add(this.btn_Create);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TextBox txtB_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB_User;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton rb_Admin;
        private System.Windows.Forms.RadioButton rb_Profesor;
        private System.Windows.Forms.RadioButton rb_Alumno;
    }
}