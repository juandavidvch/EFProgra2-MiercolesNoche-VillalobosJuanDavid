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
    public partial class Subject : Form
    {
        SubjectController controlmateria = new SubjectController();
        SubjectEntity entMateria = new SubjectEntity();

        public Subject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            cargar();
            controlmateria.insertar(entMateria);
            cargarGrid();
            cleanFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            cargar();
            controlmateria.modificar(entMateria);
            cargarGrid();
            cleanFields();
        }

        private void cargar()
        {
            entMateria.Materia = Convert.ToInt16(txtIDMateria.Text);
            entMateria.Nombre = txtNombre.Text;
            entMateria.Profesor = Convert.ToInt16(comboProfesor.Text);
        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controlmateria.lectura();
        }

        private void cleanFields()
        {
            txtIDMateria.Text = "";
            txtNombre.Text = "";
            comboProfesor.Text = "";
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_colegioDataSet.profesor' Puede moverla o quitarla según sea necesario.
            this.profesorTableAdapter.Fill(this.bd_colegioDataSet.profesor);
            cargarGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            controlmateria.eliminar(Convert.ToInt16(txtIDMateria.Text));
            cargarGrid();
            cleanFields();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //actualizar
            controlmateria.lectura();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controlmateria.buscar(Convert.ToInt32(txtIDMateria.Text));
            txtNombre.Text = dt.Rows[0][0].ToString();
            comboProfesor.Text = dt.Rows[0][1].ToString();
        }

    }
}
