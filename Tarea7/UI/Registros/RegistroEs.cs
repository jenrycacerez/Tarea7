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
    public partial class RegistroEs : Form
    {
        public RegistroEs()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            EstudianteIdNumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Estudiante tipo = new Estudiante();

            try
            {
                tipo = EstudianteBLL.Buscar((int)EstudianteIdNumericUpDown.Value);

                if (tipo != null)
                {
                    Limpiar();
                    LlenarCampos(tipo);
                }
                else
                {
                    MessageBox.Show("Asignatura no encontrado");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }

        private void LlenarCampos(Estudiante tipo)
        {
            EstudianteIdNumericUpDown.Value = tipo.EstudianteId;
            NombretextBox.Text = tipo.Nombre;
        }

        private Estudiante LlenarClase()
        {
            Estudiante tipo = new Estudiante();

            tipo.EstudianteId= (int)EstudianteIdNumericUpDown.Value;
            tipo.Nombre = NombretextBox.Text;

            return tipo;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Este campo no puede estar en blanco");
                paso = false;
            }


            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            Estudiante estudiante = new Estudiante();
            estudiante = LlenarClase();

            try
            {
                if (EstudianteBLL.Buscar((int)EstudianteIdNumericUpDown.Value) != null)
                {
                    EstudianteBLL.Modificar(estudiante);
                    MessageBox.Show("Modificado Correctamente");
                    Limpiar();
                }
                else
                {
                    if (EstudianteIdNumericUpDown.Value == 0)
                    {
                        if (!EstudianteBLL.Duplicado(NombretextBox.Text))
                        {
                            EstudianteBLL.Guardar(estudiante);
                            MessageBox.Show("Se guardo correctamente");
                            Limpiar();
                        }
                        else
                        {
                            errorProvider.SetError(NombretextBox, "Este Tipo ya existe");
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un erro");
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (EstudianteBLL.Buscar((int)EstudianteIdNumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede eliminar una Asignatura que no existe");
                }
                else
                {
                    EstudianteBLL.Eliminar((int)EstudianteIdNumericUpDown.Value);
                    MessageBox.Show("Eliminado correctamente");
                    Limpiar();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error");
            }
        }
    }
}
