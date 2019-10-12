using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea7.BLL;
using Tarea7.Entidades;

namespace Tarea7.UI.Registros
{
    public partial class RegristroAs : Form
    {
        List<AsistenciaDetalle> Detalles;
        public RegristroAs()
        {
            InitializeComponent();
            this.Detalles = new List<AsistenciaDetalle>();
            this.DetallesdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LLenaComboboxEstudiante();
            LlenaComboboxAsignatura();

        }

        private void LLenaComboboxEstudiante()
        { 
            List<Estudiante> Lista = new List<Estudiante>();
            Lista = EstudianteBLL.GetList(p => true);
            EstudianteComboBox.DataSource = null;
            EstudianteComboBox.DataSource = Lista;
            EstudianteComboBox.ValueMember = "EstudianteId";
            EstudianteComboBox.DisplayMember = "Nombre";
        }

        private void LlenaComboboxAsignatura()
        {
            List<Asignaturas> Lista = new List<Asignaturas>();
            Lista = AsignaturasBLL.GetList(p => true);
            AsignaturaComboBox.DataSource = null;
            AsignaturaComboBox.DataSource = Lista;
            AsignaturaComboBox.ValueMember = "AsignaturaId";
            AsignaturaComboBox.DisplayMember = "Nombre";

        }



        private void Button4_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void NuevoRegbutton_Click(object sender, EventArgs e)
        {
            RegistroEs registroEs = new RegistroEs();
            
            registroEs.ShowDialog();
            LLenaComboboxEstudiante();

        }
        private void CargarGrip()
        {
            DetallesdataGridView.DataSource = null;
           
            DetallesdataGridView.DataSource =  this.Detalles;
            CantidadtextBox.Text = this.Detalles.Count.ToString();

        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            FechaDateTimePicker.Value = DateTime.Now;
           
            Detalles = new List<AsistenciaDetalle>();
            CargarGrip();
        }

        private int VerificarCheckBox()
        {
            int paso;
            if (PresenteCheckBox.Checked == true)
                return paso = 1;
            else
                return paso = 0;
        }

        private void LlenarCampos(Asistencias asistencias)
        {
          
            IdnumericUpDown.Value = asistencias.AsistenciaId;
            FechaDateTimePicker.Value = asistencias.Fecha;
            CantidadtextBox.Text = Convert.ToString(asistencias.Cantidad);
            AsignaturaComboBox.SelectedValue  = asistencias.AsignaturaId;
            this.Detalles = asistencias.Detalles;
            CargarGrip();

        }

        private Asistencias LlenarClase()
        {
            Asistencias asistencias = new Asistencias();

            asistencias.AsistenciaId = Convert.ToInt32(IdnumericUpDown.Value);
            asistencias.Fecha = FechaDateTimePicker.Value;
            asistencias.Cantidad = Convert.ToInt32(CantidadtextBox.Text);
            asistencias.AsignaturaId = Convert.ToInt32(AsignaturaComboBox.SelectedValue);
            asistencias.Detalles = this.Detalles;

            return asistencias;
        }
        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();



            if (AsignaturaComboBox.Text == "")
            {
                errorProvider.SetError(AsignaturaComboBox, "Elige una Asignatura");
                paso = false;
               
            }

            if (EstudianteComboBox.SelectedIndex == -1)
            {
                errorProvider.SetError(EstudianteComboBox, "Elige un estudiante");
                paso = false;
            }
            if (this.Detalles.Count == 0)
            {
                errorProvider.SetError(NuevoRegbutton, "Agrega un Estudiante");
                Nuevobutton.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(CantidadtextBox.Text))
            {
                errorProvider.SetError(CantidadtextBox, "El campo No Puede estar Vasio");
                paso = false;
            }
            else
            {
                try
                {
                    int cantidad = Convert.ToInt32(CantidadtextBox.Text);
                }
                catch (Exception)
                {
                    errorProvider.SetError(CantidadtextBox, "la catidad debe ser Numerica Entera");
                    paso = false;
                }
            }
            return paso;
        }
        private bool Existe()
        {
            Asistencias asistencias = AsistenciasBLL.Buscar((int)IdnumericUpDown.Value);
            return (asistencias != null);

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            Asistencias asistencias = new Asistencias();

            asistencias = LlenarClase();

            try
            {
                if (!AsistenciasBLL.Exist(asistencias.AsistenciaId))
                {
                    MessageBox.Show("No se puede eliminar por que no existe");
                }
                else
                {

                    AsistenciasBLL.Eliminar(asistencias.AsistenciaId);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error al intentar eliminar");
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
           
            int id = Convert.ToInt32(IdnumericUpDown.Value);
            Asistencias asistencias;
         

            asistencias = AsistenciasBLL.Buscar(id);

            DetallesdataGridView.AutoGenerateColumns = false;
        
            if (asistencias != null)
            {
                Limpiar();
                LlenarCampos(asistencias);
            }
            else
            {
                MessageBox.Show("No se encontro el Asistencia");
            }



        }

        private void AsistenciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            bool paso;
            Asistencias asistencias = new Asistencias();
            asistencias = LlenarClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = AsistenciasBLL.Guardar(asistencias);

            }
            else
            {
                if (!Existe())
                {

                    MessageBox.Show("Guardado correctamente");
                    return;

                    //Limpiar();
                }
                paso = AsistenciasBLL.Modificar(asistencias);
            }

            if (paso)
            {
                MessageBox.Show("Guardado!!");
            }
            else
            {
                MessageBox.Show("No Fue Posible Guardar", "fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void AgregarAsignaturaButton_Click(object sender, EventArgs e)
        {
            RegistroAsig registroAsig = new RegistroAsig();
            
            registroAsig.ShowDialog();

            LlenaComboboxAsignatura();


        }

        private void PresenteCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
           
                Detalles.RemoveAt(DetallesdataGridView.CurrentRow.Index);
                CargarGrip();
            
        }

        private void DetallesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        
        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            Detalles = new List<AsistenciaDetalle>();

            if (DetallesdataGridView.DataSource != null)
            
                this.Detalles = (List<AsistenciaDetalle>)DetallesdataGridView.DataSource;

            
            AsistenciaDetalle aDetalle = new AsistenciaDetalle();
            aDetalle.DetalleAsistenciasId = 0;
            aDetalle.EstudianteId = (int)EstudianteComboBox.SelectedValue;
            aDetalle.Asistencia = PresenteCheckBox.Checked;
            aDetalle.AsistenciaId = Convert.ToInt32 (IdnumericUpDown.Value);
            aDetalle.Nombre = EstudianteComboBox.Text;

            DetallesdataGridView.AutoGenerateColumns = false;
                
         

            Detalles.Add(aDetalle);


            CargarGrip();
            errorProvider.Clear();
            PresenteCheckBox.Checked = false;
            EstudianteComboBox.Text = string.Empty;
            
        }
        
        
    }

}

