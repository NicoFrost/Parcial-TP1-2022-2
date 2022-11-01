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
            System.Windows.Forms.Button btn_Create;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            btn_Sesion = new System.Windows.Forms.Button();
            btn_Create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Sesion
            // 
            btn_Sesion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Sesion.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_Sesion.Location = new System.Drawing.Point(309, 112);
            btn_Sesion.Name = "btn_Sesion";
            btn_Sesion.Size = new System.Drawing.Size(79, 23);
            btn_Sesion.TabIndex = 0;
            btn_Sesion.Text = "Iniciar Sesion";
            btn_Sesion.UseVisualStyleBackColor = false;
            btn_Sesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Create
            // 
            btn_Create.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btn_Create.ForeColor = System.Drawing.SystemColors.ControlText;
            btn_Create.Location = new System.Drawing.Point(224, 112);
            btn_Create.Name = "btn_Create";
            btn_Create.Size = new System.Drawing.Size(79, 23);
            btn_Create.TabIndex = 6;
            btn_Create.Text = "Crear Usuario";
            btn_Create.UseVisualStyleBackColor = false;
            btn_Create.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Constraseña :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(84, 39);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(216, 20);
            this.txt_name.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.HideSelection = false;
            this.txt_password.Location = new System.Drawing.Point(84, 72);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(216, 20);
            this.txt_password.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::SysAcademy.Properties.Resources.Screenshot_2;
            this.ClientSize = new System.Drawing.Size(400, 147);
            this.Controls.Add(btn_Create);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(btn_Sesion);
            this.Name = "Form1";
            this.Text = "Ingreso UTN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_password;
    }
}

