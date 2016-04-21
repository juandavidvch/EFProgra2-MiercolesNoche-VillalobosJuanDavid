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
    public partial class Teacher : Form
    {
        TeacherController controlprofesor = new TeacherController();
        TeacherEntity entprofesor = new TeacherEntity();

        public Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add
            cargar();
            controlprofesor.insertar(entprofesor);
            cargarGrid();
            cleanFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            cargar();
            controlprofesor.modificar(entprofesor);
            cargarGrid();
            cleanFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            controlprofesor.eliminar(Convert.ToInt16(txtIDProfesor.Text));
            cargarGrid();
            cleanFields();
        }

        private void cargar()
        {
            entprofesor.Profesor = Convert.ToInt16(txtIDProfesor.Text);
            entprofesor.Nombre = txtNombre.Text;
            entprofesor.Apellido = txtApellido.Text;
        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controlprofesor.lectura();
        }

        private void cleanFields()
        {
            txtIDProfesor.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
        }

        private void Teacher_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controlprofesor.buscar(Convert.ToInt32(txtIDProfesor.Text));
            txtNombre.Text = dt.Rows[0][0].ToString();
            txtApellido.Text = dt.Rows[0][1].ToString();
        }






    }
}
