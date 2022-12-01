namespace SysAcademy
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Mensaje = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cerrarSesionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.examenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadosAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionProfesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pb_asistencias = new System.Windows.Forms.PictureBox();
            this.class1 = new System.Windows.Forms.PictureBox();
            this.pb_Inscripcion = new System.Windows.Forms.PictureBox();
            this.class2 = new System.Windows.Forms.PictureBox();
            this.class3 = new System.Windows.Forms.PictureBox();
            this.class4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_asistencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inscripcion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class4)).BeginInit();
            this.SuspendLayout();
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mensaje.Location = new System.Drawing.Point(14, 43);
            this.Mensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(132, 26);
            this.Mensaje.TabIndex = 0;
            this.Mensaje.Text = "Bienvenido, ";
            this.Mensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesionToolStripMenuItem1,
            this.examenesToolStripMenuItem,
            this.administradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cerrarSesionToolStripMenuItem1
            // 
            this.cerrarSesionToolStripMenuItem1.Name = "cerrarSesionToolStripMenuItem1";
            this.cerrarSesionToolStripMenuItem1.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem1.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem1.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem1_Click);
            // 
            // examenesToolStripMenuItem
            // 
            this.examenesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaToolStripMenuItem1,
            this.crearToolStripMenuItem});
            this.examenesToolStripMenuItem.Enabled = false;
            this.examenesToolStripMenuItem.Name = "examenesToolStripMenuItem";
            this.examenesToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.examenesToolStripMenuItem.Text = "Examenes";
            // 
            // listaToolStripMenuItem1
            // 
            this.listaToolStripMenuItem1.Enabled = false;
            this.listaToolStripMenuItem1.Name = "listaToolStripMenuItem1";
            this.listaToolStripMenuItem1.Size = new System.Drawing.Size(102, 22);
            this.listaToolStripMenuItem1.Text = "Lista";
            this.listaToolStripMenuItem1.Click += new System.EventHandler(this.listaToolStripMenuItem1_Click);
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Enabled = false;
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.crearToolStripMenuItem.Text = "Crear";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // administradorToolStripMenuItem
            // 
            this.administradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadosMateriasToolStripMenuItem,
            this.nuevoUsuarioToolStripMenuItem});
            this.administradorToolStripMenuItem.Enabled = false;
            this.administradorToolStripMenuItem.Name = "administradorToolStripMenuItem";
            this.administradorToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.administradorToolStripMenuItem.Text = "Administrador";
            this.administradorToolStripMenuItem.Click += new System.EventHandler(this.administradorToolStripMenuItem_Click);
            // 
            // estadosMateriasToolStripMenuItem
            // 
            this.estadosMateriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadosAlumnosToolStripMenuItem,
            this.asignacionProfesToolStripMenuItem,
            this.nuevaMateriaToolStripMenuItem});
            this.estadosMateriasToolStripMenuItem.Enabled = false;
            this.estadosMateriasToolStripMenuItem.Name = "estadosMateriasToolStripMenuItem";
            this.estadosMateriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estadosMateriasToolStripMenuItem.Text = "Materias";
            this.estadosMateriasToolStripMenuItem.Click += new System.EventHandler(this.estadosMateriasToolStripMenuItem_Click);
            // 
            // estadosAlumnosToolStripMenuItem
            // 
            this.estadosAlumnosToolStripMenuItem.Enabled = false;
            this.estadosAlumnosToolStripMenuItem.Name = "estadosAlumnosToolStripMenuItem";
            this.estadosAlumnosToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.estadosAlumnosToolStripMenuItem.Text = "Estado materia para alumnos";
            this.estadosAlumnosToolStripMenuItem.Click += new System.EventHandler(this.estadosAlumnosToolStripMenuItem_Click);
            // 
            // asignacionProfesToolStripMenuItem
            // 
            this.asignacionProfesToolStripMenuItem.Enabled = false;
            this.asignacionProfesToolStripMenuItem.Name = "asignacionProfesToolStripMenuItem";
            this.asignacionProfesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.asignacionProfesToolStripMenuItem.Text = "Asignacion Profes";
            this.asignacionProfesToolStripMenuItem.Click += new System.EventHandler(this.asignacionProfesToolStripMenuItem_Click);
            // 
            // nuevaMateriaToolStripMenuItem
            // 
            this.nuevaMateriaToolStripMenuItem.Enabled = false;
            this.nuevaMateriaToolStripMenuItem.Name = "nuevaMateriaToolStripMenuItem";
            this.nuevaMateriaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.nuevaMateriaToolStripMenuItem.Text = "Nueva Materia";
            this.nuevaMateriaToolStripMenuItem.Click += new System.EventHandler(this.nuevaMateriaToolStripMenuItem_Click);
            // 
            // nuevoUsuarioToolStripMenuItem
            // 
            this.nuevoUsuarioToolStripMenuItem.Enabled = false;
            this.nuevoUsuarioToolStripMenuItem.Name = "nuevoUsuarioToolStripMenuItem";
            this.nuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario";
            this.nuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.nuevoUsuarioToolStripMenuItem_Click);
            // 
            // pb_asistencias
            // 
            this.pb_asistencias.BackColor = System.Drawing.Color.Blue;
            this.pb_asistencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_asistencias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_asistencias.Enabled = false;
            this.pb_asistencias.Image = ((System.Drawing.Image)(resources.GetObject("pb_asistencias.Image")));
            this.pb_asistencias.Location = new System.Drawing.Point(12, 129);
            this.pb_asistencias.Name = "pb_asistencias";
            this.pb_asistencias.Size = new System.Drawing.Size(153, 72);
            this.pb_asistencias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_asistencias.TabIndex = 5;
            this.pb_asistencias.TabStop = false;
            this.pb_asistencias.Click += new System.EventHandler(this.pb_asistencias_Click);
            // 
            // class1
            // 
            this.class1.BackColor = System.Drawing.Color.Yellow;
            this.class1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.class1.Enabled = false;
            this.class1.Image = ((System.Drawing.Image)(resources.GetObject("class1.Image")));
            this.class1.Location = new System.Drawing.Point(12, 221);
            this.class1.Name = "class1";
            this.class1.Size = new System.Drawing.Size(153, 97);
            this.class1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class1.TabIndex = 6;
            this.class1.TabStop = false;
            // 
            // pb_Inscripcion
            // 
            this.pb_Inscripcion.BackColor = System.Drawing.Color.Transparent;
            this.pb_Inscripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Inscripcion.Enabled = false;
            this.pb_Inscripcion.Image = ((System.Drawing.Image)(resources.GetObject("pb_Inscripcion.Image")));
            this.pb_Inscripcion.Location = new System.Drawing.Point(199, 129);
            this.pb_Inscripcion.Name = "pb_Inscripcion";
            this.pb_Inscripcion.Size = new System.Drawing.Size(153, 72);
            this.pb_Inscripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Inscripcion.TabIndex = 7;
            this.pb_Inscripcion.TabStop = false;
            this.pb_Inscripcion.Click += new System.EventHandler(this.pb_Inscripcion_Click);
            // 
            // class2
            // 
            this.class2.BackColor = System.Drawing.SystemColors.WindowText;
            this.class2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.class2.Enabled = false;
            this.class2.Image = ((System.Drawing.Image)(resources.GetObject("class2.Image")));
            this.class2.Location = new System.Drawing.Point(199, 221);
            this.class2.Name = "class2";
            this.class2.Size = new System.Drawing.Size(153, 97);
            this.class2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class2.TabIndex = 8;
            this.class2.TabStop = false;
            // 
            // class3
            // 
            this.class3.BackColor = System.Drawing.Color.Yellow;
            this.class3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.class3.Enabled = false;
            this.class3.Image = ((System.Drawing.Image)(resources.GetObject("class3.Image")));
            this.class3.Location = new System.Drawing.Point(12, 337);
            this.class3.Name = "class3";
            this.class3.Size = new System.Drawing.Size(153, 97);
            this.class3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class3.TabIndex = 9;
            this.class3.TabStop = false;
            // 
            // class4
            // 
            this.class4.BackColor = System.Drawing.Color.Yellow;
            this.class4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.class4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.class4.Enabled = false;
            this.class4.Image = ((System.Drawing.Image)(resources.GetObject("class4.Image")));
            this.class4.Location = new System.Drawing.Point(199, 337);
            this.class4.Name = "class4";
            this.class4.Size = new System.Drawing.Size(153, 97);
            this.class4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.class4.TabIndex = 10;
            this.class4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(12, 88);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Registro de Carrera";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(364, 446);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.class4);
            this.Controls.Add(this.class3);
            this.Controls.Add(this.class2);
            this.Controls.Add(this.pb_Inscripcion);
            this.Controls.Add(this.class1);
            this.Controls.Add(this.pb_asistencias);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(380, 485);
            this.Name = "Main";
            this.Text = "Menu Principal";
            this.TransparencyKey = System.Drawing.Color.Snow;
            this.Activated += new System.EventHandler(this.Main_Activated);
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_asistencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Inscripcion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private ToolStripMenuItem examenesToolStripMenuItem;
        private ToolStripMenuItem administradorToolStripMenuItem;
        private ToolStripMenuItem listaToolStripMenuItem1;
        private ToolStripMenuItem crearToolStripMenuItem;
        private ToolStripMenuItem nuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem estadosMateriasToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem1;
        private ToolStripMenuItem estadosAlumnosToolStripMenuItem;
        private ToolStripMenuItem asignacionProfesToolStripMenuItem;
        private ToolStripMenuItem nuevaMateriaToolStripMenuItem;
        private PictureBox pb_asistencias;
        private PictureBox class1;
        private PictureBox pb_Inscripcion;
        private PictureBox class2;
        private PictureBox class3;
        private PictureBox class4;
        private Button button1;
    }
}