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
            this.Mensaje = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeMateriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.correlatividadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesosEspecialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mensaje
            // 
            this.Mensaje.AutoSize = true;
            this.Mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mensaje.Location = new System.Drawing.Point(12, 37);
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(132, 26);
            this.Mensaje.TabIndex = 0;
            this.Mensaje.Text = "Bienvenido, ";
            this.Mensaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 549);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 66);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(436, 224);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(460, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.materiasToolStripMenuItem,
            this.accesosEspecialesToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeMateriasToolStripMenuItem,
            this.correlatividadesToolStripMenuItem1,
            this.estadoDeAlumnoToolStripMenuItem});
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // listaDeMateriasToolStripMenuItem
            // 
            this.listaDeMateriasToolStripMenuItem.Name = "listaDeMateriasToolStripMenuItem";
            this.listaDeMateriasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.listaDeMateriasToolStripMenuItem.Text = "Lista de Materias";
            // 
            // correlatividadesToolStripMenuItem1
            // 
            this.correlatividadesToolStripMenuItem1.Name = "correlatividadesToolStripMenuItem1";
            this.correlatividadesToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.correlatividadesToolStripMenuItem1.Text = "Correlatividades";
            // 
            // estadoDeAlumnoToolStripMenuItem
            // 
            this.estadoDeAlumnoToolStripMenuItem.Name = "estadoDeAlumnoToolStripMenuItem";
            this.estadoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.estadoDeAlumnoToolStripMenuItem.Text = "Estado de alumno";
            // 
            // accesosEspecialesToolStripMenuItem
            // 
            this.accesosEspecialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accesoDocenteToolStripMenuItem,
            this.accesoAdministradorToolStripMenuItem});
            this.accesosEspecialesToolStripMenuItem.Name = "accesosEspecialesToolStripMenuItem";
            this.accesosEspecialesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.accesosEspecialesToolStripMenuItem.Text = "Accesos especiales";
            // 
            // accesoDocenteToolStripMenuItem
            // 
            this.accesoDocenteToolStripMenuItem.Name = "accesoDocenteToolStripMenuItem";
            this.accesoDocenteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.accesoDocenteToolStripMenuItem.Text = "Acceso Docente";
            this.accesoDocenteToolStripMenuItem.Click += new System.EventHandler(this.accesoDocenteToolStripMenuItem_Click);
            // 
            // accesoAdministradorToolStripMenuItem
            // 
            this.accesoAdministradorToolStripMenuItem.Name = "accesoAdministradorToolStripMenuItem";
            this.accesoAdministradorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.accesoAdministradorToolStripMenuItem.Text = "Acceso Administrador";
            this.accesoAdministradorToolStripMenuItem.Click += new System.EventHandler(this.accesoAdministradorToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 584);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Mensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeMateriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem correlatividadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estadoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesosEspecialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
    }
}