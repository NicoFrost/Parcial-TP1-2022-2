namespace SysAcademy2.Administrador
{
    partial class pathImportar
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_path = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_direccion = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_path
            // 
            this.txt_path.Enabled = false;
            this.txt_path.Location = new System.Drawing.Point(12, 24);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(258, 23);
            this.txt_path.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_path
            // 
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(12, 6);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(94, 15);
            this.lbl_path.TabIndex = 2;
            this.lbl_path.Text = "Ruta del Archivo";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(12, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(258, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre del archivo";
            // 
            // cbx_direccion
            // 
            this.cbx_direccion.AutoSize = true;
            this.cbx_direccion.Location = new System.Drawing.Point(276, 26);
            this.cbx_direccion.Name = "cbx_direccion";
            this.cbx_direccion.Size = new System.Drawing.Size(116, 19);
            this.cbx_direccion.TabIndex = 5;
            this.cbx_direccion.Text = "Diferente carpeta";
            this.cbx_direccion.UseVisualStyleBackColor = true;
            this.cbx_direccion.CheckedChanged += new System.EventHandler(this.cbx_direccion_CheckedChanged);
            // 
            // pathImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 108);
            this.Controls.Add(this.cbx_direccion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_path);
            this.Name = "pathImportar";
            this.Text = "pathImportar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Label lbl_path;
        internal TextBox txt_path;
        internal TextBox txt_nombre;
        private Label label1;
        private CheckBox cbx_direccion;
    }
}