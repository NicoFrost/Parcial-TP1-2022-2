namespace SysAcademy2
{
    partial class MostrarDatos
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
            this.DG_ListaMaterias = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.C_Examen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_ExamenNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Correlativa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ListaMaterias)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_ListaMaterias
            // 
            this.DG_ListaMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ListaMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Examen,
            this.C_ExamenNota,
            this.C_Materia,
            this.C_Profesor,
            this.C_Correlativa});
            this.DG_ListaMaterias.Location = new System.Drawing.Point(12, 139);
            this.DG_ListaMaterias.Name = "DG_ListaMaterias";
            this.DG_ListaMaterias.ReadOnly = true;
            this.DG_ListaMaterias.RowTemplate.Height = 25;
            this.DG_ListaMaterias.Size = new System.Drawing.Size(776, 299);
            this.DG_ListaMaterias.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(479, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(198, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(683, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 23);
            this.textBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(239, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 23);
            this.comboBox2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "LISTA DE EXAMENES RENDIDOS";
            // 
            // C_Examen
            // 
            this.C_Examen.HeaderText = "Nombre Examen";
            this.C_Examen.Name = "C_Examen";
            this.C_Examen.ReadOnly = true;
            this.C_Examen.Width = 150;
            // 
            // C_ExamenNota
            // 
            this.C_ExamenNota.HeaderText = "Nota";
            this.C_ExamenNota.Name = "C_ExamenNota";
            this.C_ExamenNota.ReadOnly = true;
            this.C_ExamenNota.Width = 50;
            // 
            // C_Materia
            // 
            this.C_Materia.HeaderText = "Materia";
            this.C_Materia.Name = "C_Materia";
            this.C_Materia.ReadOnly = true;
            // 
            // C_Profesor
            // 
            this.C_Profesor.HeaderText = "Profesor";
            this.C_Profesor.Name = "C_Profesor";
            this.C_Profesor.ReadOnly = true;
            // 
            // C_Correlativa
            // 
            this.C_Correlativa.HeaderText = "Correlativa";
            this.C_Correlativa.Name = "C_Correlativa";
            this.C_Correlativa.ReadOnly = true;
            // 
            // MostrarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DG_ListaMaterias);
            this.Name = "MostrarDatos";
            this.Text = "MostrarDatos";
            this.Load += new System.EventHandler(this.MostrarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_ListaMaterias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView DG_ListaMaterias;
        private ComboBox comboBox1;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private Label label1;
        private DataGridViewTextBoxColumn C_Examen;
        private DataGridViewTextBoxColumn C_ExamenNota;
        private DataGridViewTextBoxColumn C_Materia;
        private DataGridViewTextBoxColumn C_Profesor;
        private DataGridViewTextBoxColumn C_Correlativa;
    }
}