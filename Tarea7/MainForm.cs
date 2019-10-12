using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tarea7.UI.Registros;

namespace Tarea7
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroAsignaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroAsig registroAsig = new RegistroAsig();
           // registroAsig.MdiParent = this;
            registroAsig.Show();
        }

        private void RegistroAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegristroAs registroAs = new RegristroAs();
           // registroAs.MdiParent = this;
            registroAs.Show();
        }

        private void RegistroEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEs registroEs = new RegistroEs();
           // registroEs.MdiParent = this;
            registroEs.Show();

        }
    }
}
