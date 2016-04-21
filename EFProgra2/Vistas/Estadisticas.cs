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
    public partial class Estadisticas : Form
    {
        StatisticsController estadisticas = new StatisticsController();
        
        public Estadisticas()
        {
            InitializeComponent();
        }

        private void Estadisticas_Load(object sender, EventArgs e)
        {
            cargarGrids();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estadisticas.generar(dataGridView1);
        }

        private void cargarGrids()
        {
            dataGridView1.DataSource = estadisticas.lectura1();
            dataGridView2.DataSource = estadisticas.lectura2();
            dataGridView3.DataSource = estadisticas.lectura3();
        }
    }
}
