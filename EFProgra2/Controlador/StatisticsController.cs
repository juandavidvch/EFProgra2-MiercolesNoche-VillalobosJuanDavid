using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProgra2
{
    class StatisticsController
    {
        Modelo mode = new Modelo();
        string sql;
        int contador_menores;
        int contador_mayores;
        public DataTable lectura1()
        {
            sql = "SELECT "
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_MATERIA"
                + " FROM "
                + "ESTUDIANTE";
            return mode.llenar(sql);
        }

        public DataTable lectura2()
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + " FROM "
                + "MATERIA";
            return mode.llenar(sql);
        }

        public DataTable lectura3()
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + " FROM "
                + "PROFESOR";
            return mode.llenar(sql);
        }

        public void generar (DataGridView tabla)
        {
            foreach (DataGridViewRow fila in tabla.Rows)
            {
                double cant = Convert.ToDouble(fila.Cells["Edad"].Value);
                if (cant >= 18)
                {
                    contador_menores++;
                }
                else
                {
                    contador_mayores++;
                }
            }
        }



    }
}
