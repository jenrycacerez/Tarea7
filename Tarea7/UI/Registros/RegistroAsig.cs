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
    public partial class RegistroAsig : Form
    {
        public RegistroAsig()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar()
        {
            IdAsignaturaNumericUpDown.Value = 0;
            NombreAsignaturaTextBox.Text = string.Empty;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            Asignaturas tipo = new Asignaturas();

            try
            {
                tipo = AsignaturasBLL.Buscar((int)IdAsignaturaNumericUpDown.Value);

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

        private void LlenarCampos(Asignaturas tipo)
        {
            IdAsignaturaNumericUpDown.Value = tipo.AsignaturaId;
            NombreAsignaturaTextBox.Text = tipo.Nombre;
        }

        private Asignaturas LlenarClase()
        {
            Asignaturas tipo = new Asignaturas();

            tipo.AsignaturaId = (int)IdAsignaturaNumericUpDown.Value;
            tipo.Nombre = NombreAsignaturaTextBox.Text;

            return tipo;
        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombreAsignaturaTextBox.Text))
            {
                errorProvider.SetError(NombreAsignaturaTextBox, "Este campo no puede estar en blanco");
                paso = false;
            }


            return paso;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

            Asignaturas tipo = new Asignaturas();
            tipo = LlenarClase();

            try
            {
                if (AsignaturasBLL.Buscar((int)IdAsignaturaNumericUpDown.Value) != null)
                {
                    AsignaturasBLL.Modificar(tipo);
                    MessageBox.Show("Modificado Correctamente");
                    Limpiar();
                }
                else
                {
                    if (IdAsignaturaNumericUpDown.Value == 0)
                    {
                        if (!AsignaturasBLL.Duplicado(NombreAsignaturaTextBox.Text))
                        {
                            AsignaturasBLL.Guardar(tipo);
                            MessageBox.Show("Se guardo correctamente");
                            Limpiar();
                        }
                        else
                        {
                            errorProvider.SetError(NombreAsignaturaTextBox, "Este Tipo ya existe");
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
                if (AsignaturasBLL.Buscar((int)IdAsignaturaNumericUpDown.Value) == null)
                {
                    MessageBox.Show("No se puede eliminar una Asignatura que no existe");
                }
                else
                {
                    AsignaturasBLL.Eliminar((int)IdAsignaturaNumericUpDown.Value);
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
