namespace Tarea7
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsistenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroAsignaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroAsistenciaToolStripMenuItem,
            this.registroEstudianteToolStripMenuItem,
            this.registroAsignaturaToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.registrosToolStripMenuItem.Text = "Registros ";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // registroAsistenciaToolStripMenuItem
            // 
            this.registroAsistenciaToolStripMenuItem.Name = "registroAsistenciaToolStripMenuItem";
            this.registroAsistenciaToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.registroAsistenciaToolStripMenuItem.Text = "Registro Asistencia";
            this.registroAsistenciaToolStripMenuItem.Click += new System.EventHandler(this.RegistroAsistenciaToolStripMenuItem_Click);
            // 
            // registroEstudianteToolStripMenuItem
            // 
            this.registroEstudianteToolStripMenuItem.Name = "registroEstudianteToolStripMenuItem";
            this.registroEstudianteToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.registroEstudianteToolStripMenuItem.Text = "Registro Estudiante";
            this.registroEstudianteToolStripMenuItem.Click += new System.EventHandler(this.RegistroEstudianteToolStripMenuItem_Click);
            // 
            // registroAsignaturaToolStripMenuItem
            // 
            this.registroAsignaturaToolStripMenuItem.Name = "registroAsignaturaToolStripMenuItem";
            this.registroAsignaturaToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.registroAsignaturaToolStripMenuItem.Text = "Registro Asignatura ";
            this.registroAsignaturaToolStripMenuItem.Click += new System.EventHandler(this.RegistroAsignaturaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsistenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEstudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroAsignaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    }
}

