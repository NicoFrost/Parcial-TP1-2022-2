namespace SysAcademy2
{
    partial class CrearMaterias
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbx_Profesores = new System.Windows.Forms.ComboBox();
            this.cb_correlativas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_AddCorrelativas = new System.Windows.Forms.Button();
            this.lb_correlativasAdded = new System.Windows.Forms.ListBox();
            this.btn_RemoveCorrelativa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 186);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(92, 30);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(114, 186);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(92, 30);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Crear";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.AcceptsReturn = true;
            this.txt_Nombre.Location = new System.Drawing.Point(133, 12);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(245, 23);
            this.txt_Nombre.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre Materia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Profesor Asignado:";
            // 
            // Cbx_Profesores
            // 
            this.Cbx_Profesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cbx_Profesores.FormattingEnabled = true;
            this.Cbx_Profesores.Items.AddRange(new object[] {
            ""});
            this.Cbx_Profesores.Location = new System.Drawing.Point(133, 41);
            this.Cbx_Profesores.Name = "Cbx_Profesores";
            this.Cbx_Profesores.Size = new System.Drawing.Size(245, 23);
            this.Cbx_Profesores.TabIndex = 6;
            // 
            // cb_correlativas
            // 
            this.cb_correlativas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_correlativas.FormattingEnabled = true;
            this.cb_correlativas.Items.AddRange(new object[] {
            ""});
            this.cb_correlativas.Location = new System.Drawing.Point(133, 70);
            this.cb_correlativas.Name = "cb_correlativas";
            this.cb_correlativas.Size = new System.Drawing.Size(245, 23);
            this.cb_correlativas.TabIndex = 7;
            this.cb_correlativas.SelectedIndexChanged += new System.EventHandler(this.cb_correlativas_SelectedIndexChanged);
            this.cb_correlativas.Click += new System.EventHandler(this.cb_correlativas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Correlativas:";
            // 
            // btn_AddCorrelativas
            // 
            this.btn_AddCorrelativas.Enabled = false;
            this.btn_AddCorrelativas.Location = new System.Drawing.Point(384, 70);
            this.btn_AddCorrelativas.Name = "btn_AddCorrelativas";
            this.btn_AddCorrelativas.Size = new System.Drawing.Size(78, 25);
            this.btn_AddCorrelativas.TabIndex = 9;
            this.btn_AddCorrelativas.Text = "Agregar...";
            this.btn_AddCorrelativas.UseVisualStyleBackColor = true;
            this.btn_AddCorrelativas.Click += new System.EventHandler(this.btn_AddCorrelativas_Click);
            // 
            // lb_correlativasAdded
            // 
            this.lb_correlativasAdded.FormattingEnabled = true;
            this.lb_correlativasAdded.ItemHeight = 15;
            this.lb_correlativasAdded.Items.AddRange(new object[] {
            ""});
            this.lb_correlativasAdded.Location = new System.Drawing.Point(133, 99);
            this.lb_correlativasAdded.Name = "lb_correlativasAdded";
            this.lb_correlativasAdded.Size = new System.Drawing.Size(245, 64);
            this.lb_correlativasAdded.TabIndex = 10;
            this.lb_correlativasAdded.SelectedIndexChanged += new System.EventHandler(this.lb_correlativasAdded_SelectedIndexChanged);
            // 
            // btn_RemoveCorrelativa
            // 
            this.btn_RemoveCorrelativa.Enabled = false;
            this.btn_RemoveCorrelativa.Location = new System.Drawing.Point(384, 101);
            this.btn_RemoveCorrelativa.Name = "btn_RemoveCorrelativa";
            this.btn_RemoveCorrelativa.Size = new System.Drawing.Size(78, 25);
            this.btn_RemoveCorrelativa.TabIndex = 11;
            this.btn_RemoveCorrelativa.Text = "Quitar...";
            this.btn_RemoveCorrelativa.UseVisualStyleBackColor = true;
            this.btn_RemoveCorrelativa.Click += new System.EventHandler(this.btn_RemoveCorrelativa_Click);
            // 
            // CrearMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 228);
            this.Controls.Add(this.btn_RemoveCorrelativa);
            this.Controls.Add(this.lb_correlativasAdded);
            this.Controls.Add(this.btn_AddCorrelativas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_correlativas);
            this.Controls.Add(this.Cbx_Profesores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Name = "CrearMaterias";
            this.Text = "CrearMaterias";
            this.Load += new System.EventHandler(this.CrearMaterias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_cancel;
        private Button btn_ok;
        private TextBox txt_Nombre;
        private Label label1;
        private Label label2;
        private ComboBox Cbx_Profesores;
        private ComboBox cb_correlativas;
        private Label label3;
        private Button btn_AddCorrelativas;
        private ListBox lb_correlativasAdded;
        private Button btn_RemoveCorrelativa;
    }
}