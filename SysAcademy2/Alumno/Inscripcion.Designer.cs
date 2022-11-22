namespace SysAcademy2
{
    partial class Inscripcion
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
            this.btnc_InsBaja = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lb_TotMaterias = new System.Windows.Forms.ListBox();
            this.lb_Horarios = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Correlativas = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnc_InsBaja
            // 
            this.btnc_InsBaja.Location = new System.Drawing.Point(267, 248);
            this.btnc_InsBaja.Name = "btnc_InsBaja";
            this.btnc_InsBaja.Size = new System.Drawing.Size(95, 23);
            this.btnc_InsBaja.TabIndex = 0;
            this.btnc_InsBaja.Text = "Inscribirte";
            this.btnc_InsBaja.UseVisualStyleBackColor = true;
            this.btnc_InsBaja.Click += new System.EventHandler(this.btnc_InsBaja_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 248);
            this.btn_cancel.MaximumSize = new System.Drawing.Size(95, 23);
            this.btn_cancel.MinimumSize = new System.Drawing.Size(95, 23);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lb_TotMaterias
            // 
            this.lb_TotMaterias.FormattingEnabled = true;
            this.lb_TotMaterias.ItemHeight = 15;
            this.lb_TotMaterias.Location = new System.Drawing.Point(12, 12);
            this.lb_TotMaterias.Name = "lb_TotMaterias";
            this.lb_TotMaterias.Size = new System.Drawing.Size(224, 229);
            this.lb_TotMaterias.TabIndex = 2;
            this.lb_TotMaterias.Click += new System.EventHandler(this.lb_TotMaterias_Click);
            this.lb_TotMaterias.SelectedIndexChanged += new System.EventHandler(this.lb_TotMaterias_SelectedIndexChanged);
            // 
            // lb_Horarios
            // 
            this.lb_Horarios.FormattingEnabled = true;
            this.lb_Horarios.ItemHeight = 15;
            this.lb_Horarios.Location = new System.Drawing.Point(242, 132);
            this.lb_Horarios.Name = "lb_Horarios";
            this.lb_Horarios.Size = new System.Drawing.Size(120, 109);
            this.lb_Horarios.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Horarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Correlativas";
            // 
            // lb_Correlativas
            // 
            this.lb_Correlativas.FormattingEnabled = true;
            this.lb_Correlativas.ItemHeight = 15;
            this.lb_Correlativas.Location = new System.Drawing.Point(242, 30);
            this.lb_Correlativas.Name = "lb_Correlativas";
            this.lb_Correlativas.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb_Correlativas.Size = new System.Drawing.Size(120, 79);
            this.lb_Correlativas.TabIndex = 7;
            // 
            // Inscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(374, 283);
            this.Controls.Add(this.lb_Correlativas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Horarios);
            this.Controls.Add(this.lb_TotMaterias);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btnc_InsBaja);
            this.Name = "Inscripcion";
            this.Text = "Inscripcion";
            this.Load += new System.EventHandler(this.Inscripcion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnc_InsBaja;
        private Button btn_cancel;
        private ListBox lb_TotMaterias;
        private ListBox lb_Horarios;
        private Label label1;
        private Label label3;
        private ListBox lb_Correlativas;
    }
}