namespace Tarea7.UI.Registros
{
    partial class RegristroAs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegristroAs));
            this.label1 = new System.Windows.Forms.Label();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.DetallesdataGridView = new System.Windows.Forms.DataGridView();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.PresenteCheckBox = new System.Windows.Forms.CheckBox();
            this.NuevoRegbutton = new System.Windows.Forms.Button();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CantidadtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AgregarAsignaturaButton = new System.Windows.Forms.Button();
            this.EstudianteId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(119, 36);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(79, 26);
            this.IdnumericUpDown.TabIndex = 1;
            this.IdnumericUpDown.ValueChanged += new System.EventHandler(this.AsistenciaNumericUpDown_ValueChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.Location = new System.Drawing.Point(228, 29);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(54, 54);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.UseVisualStyleBackColor = false;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(379, 40);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(142, 26);
            this.FechaDateTimePicker.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asignatura";
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(125, 118);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(331, 28);
            this.AsignaturaComboBox.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(this.DetallesdataGridView);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.PresenteCheckBox);
            this.groupBox1.Controls.Add(this.NuevoRegbutton);
            this.groupBox1.Controls.Add(this.EstudianteComboBox);
            this.groupBox1.Location = new System.Drawing.Point(37, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 350);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            // 
            // Removerbutton
            // 
            this.Removerbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Removerbutton.Image = ((System.Drawing.Image)(resources.GetObject("Removerbutton.Image")));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(251, 281);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(226, 63);
            this.Removerbutton.TabIndex = 13;
            this.Removerbutton.Text = "   --Remover Fila";
            this.Removerbutton.UseVisualStyleBackColor = false;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // DetallesdataGridView
            // 
            this.DetallesdataGridView.AllowUserToAddRows = false;
            this.DetallesdataGridView.AllowUserToDeleteRows = false;
            this.DetallesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetallesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstudianteId,
            this.Nombre,
            this.Asistencia});
            this.DetallesdataGridView.Location = new System.Drawing.Point(6, 67);
            this.DetallesdataGridView.Name = "DetallesdataGridView";
            this.DetallesdataGridView.ReadOnly = true;
            this.DetallesdataGridView.RowHeadersWidth = 62;
            this.DetallesdataGridView.RowTemplate.Height = 28;
            this.DetallesdataGridView.Size = new System.Drawing.Size(471, 208);
            this.DetallesdataGridView.TabIndex = 4;
            this.DetallesdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetallesdataGridView_CellContentClick);
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Agregarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Agregarbutton.Image")));
            this.Agregarbutton.Location = new System.Drawing.Point(425, 15);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(53, 46);
            this.Agregarbutton.TabIndex = 3;
            this.Agregarbutton.UseVisualStyleBackColor = false;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // PresenteCheckBox
            // 
            this.PresenteCheckBox.AutoSize = true;
            this.PresenteCheckBox.Location = new System.Drawing.Point(320, 26);
            this.PresenteCheckBox.Name = "PresenteCheckBox";
            this.PresenteCheckBox.Size = new System.Drawing.Size(99, 24);
            this.PresenteCheckBox.TabIndex = 2;
            this.PresenteCheckBox.Text = "Presente";
            this.PresenteCheckBox.UseVisualStyleBackColor = true;
            this.PresenteCheckBox.CheckedChanged += new System.EventHandler(this.PresenteCheckBox_CheckedChanged);
            // 
            // NuevoRegbutton
            // 
            this.NuevoRegbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuevoRegbutton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoRegbutton.Image")));
            this.NuevoRegbutton.Location = new System.Drawing.Point(251, 15);
            this.NuevoRegbutton.Name = "NuevoRegbutton";
            this.NuevoRegbutton.Size = new System.Drawing.Size(49, 46);
            this.NuevoRegbutton.TabIndex = 1;
            this.NuevoRegbutton.UseVisualStyleBackColor = false;
            this.NuevoRegbutton.Click += new System.EventHandler(this.NuevoRegbutton_Click);
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(7, 26);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(238, 28);
            this.EstudianteComboBox.TabIndex = 0;
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Nuevobutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Nuevobutton.Image = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.Image")));
            this.Nuevobutton.Location = new System.Drawing.Point(37, 562);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(131, 89);
            this.Nuevobutton.TabIndex = 8;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.UseVisualStyleBackColor = false;
            this.Nuevobutton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Guardarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.Image")));
            this.Guardarbutton.Location = new System.Drawing.Point(206, 562);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(131, 89);
            this.Guardarbutton.TabIndex = 9;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.UseVisualStyleBackColor = false;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Eliminarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.Image")));
            this.Eliminarbutton.Location = new System.Drawing.Point(378, 562);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(136, 89);
            this.Eliminarbutton.TabIndex = 10;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // CantidadtextBox
            // 
            this.CantidadtextBox.Location = new System.Drawing.Point(119, 521);
            this.CantidadtextBox.Name = "CantidadtextBox";
            this.CantidadtextBox.ReadOnly = true;
            this.CantidadtextBox.Size = new System.Drawing.Size(100, 26);
            this.CantidadtextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cantidad";
            // 
            // AgregarAsignaturaButton
            // 
            this.AgregarAsignaturaButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarAsignaturaButton.Image = ((System.Drawing.Image)(resources.GetObject("AgregarAsignaturaButton.Image")));
            this.AgregarAsignaturaButton.Location = new System.Drawing.Point(462, 113);
            this.AgregarAsignaturaButton.Name = "AgregarAsignaturaButton";
            this.AgregarAsignaturaButton.Size = new System.Drawing.Size(59, 46);
            this.AgregarAsignaturaButton.TabIndex = 12;
            this.AgregarAsignaturaButton.UseVisualStyleBackColor = false;
            this.AgregarAsignaturaButton.Click += new System.EventHandler(this.AgregarAsignaturaButton_Click);
            // 
            // EstudianteId
            // 
            this.EstudianteId.DataPropertyName = "EstudianteId";
            this.EstudianteId.HeaderText = "EstudianteId";
            this.EstudianteId.MinimumWidth = 8;
            this.EstudianteId.Name = "EstudianteId";
            this.EstudianteId.ReadOnly = true;
            this.EstudianteId.Width = 150;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 150;
            // 
            // Asistencia
            // 
            this.Asistencia.DataPropertyName = "Asistencia";
            this.Asistencia.HeaderText = "Asistencia";
            this.Asistencia.MinimumWidth = 8;
            this.Asistencia.Name = "Asistencia";
            this.Asistencia.ReadOnly = true;
            this.Asistencia.Width = 150;
            // 
            // RegristroAs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 663);
            this.Controls.Add(this.AgregarAsignaturaButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CantidadtextBox);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "RegristroAs";
            this.Text = "RegristroAs";
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DetallesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DetallesdataGridView;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.CheckBox PresenteCheckBox;
        private System.Windows.Forms.Button NuevoRegbutton;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CantidadtextBox;
        private System.Windows.Forms.Button AgregarAsignaturaButton;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstudianteId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Asistencia;
    }
}