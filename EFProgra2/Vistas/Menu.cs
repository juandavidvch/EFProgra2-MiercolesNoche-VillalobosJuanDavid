using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProgra2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student estudiante = new Student();
            estudiante.MdiParent = this;
            estudiante.Show();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Subject materias = new Subject();
            materias.MdiParent = this;
            materias.Show();
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teacher profesores = new Teacher();
            profesores.MdiParent = this;
            profesores.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estadisticas numeros = new Estadisticas();
            numeros.MdiParent = this;
            numeros.Show();
        }

    }
}
