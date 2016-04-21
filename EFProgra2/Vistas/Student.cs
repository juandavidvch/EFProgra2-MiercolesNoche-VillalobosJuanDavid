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
    public partial class Student : Form
    {
        StudentController controlestudiante = new StudentController();
        StudentEntity entestudiante = new StudentEntity();

        public Student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargar();
            controlestudiante.insertar(entestudiante);
            cargarGrid();
            cleanFields();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //modificar
            cargar();
            controlestudiante.modificar(entestudiante);
            cargarGrid();
            cleanFields();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //delete
            controlestudiante.eliminar(Convert.ToInt32(txtIDEstudiante.Text));
            cargarGrid();
            cleanFields();
        }

        private void cleanFields()
        {
            txtIDEstudiante.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEdad.Text = "";
            combo_Curso.Text = "";
        }

        private void Student_Load(object sender, EventArgs e)
        {
            cargarGrid();
        }

        private void cargarGrid()
        {
            dataGridView1.DataSource = controlestudiante.lectura();
        }

        private void cargar()
        {
            entestudiante.Estudiante = Convert.ToInt32(txtIDEstudiante.Text);
            entestudiante.Nombre = txtNombre.Text;
            entestudiante.Apellido = txtApellido.Text;
            entestudiante.Direccion = txtDireccion.Text;
            entestudiante.Edad = Convert.ToInt16(txtEdad.Text);
            entestudiante.Curso = combo_Curso.Text;
            //entestudiante.Curso = Convert.ToInt16(combo_Curso.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //actualizar
            controlestudiante.lectura();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = controlestudiante.buscar(Convert.ToInt32(txtIDEstudiante.Text));
            txtNombre.Text = dt.Rows[0][0].ToString();
            txtApellido.Text = dt.Rows[0][1].ToString();
            txtDireccion.Text = dt.Rows[0][2].ToString();
            txtEdad.Text = dt.Rows[0][3].ToString();
            combo_Curso.Text = dt.Rows[0][4].ToString();
        }
    }
}
