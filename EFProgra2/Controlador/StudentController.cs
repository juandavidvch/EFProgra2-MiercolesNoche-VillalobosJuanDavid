using System.Data;

namespace EFProgra2
{
    class StudentController
    {
        Modelo mode = new Modelo();
        StudentEntity estudiante = new StudentEntity();
        string sql;

        public DataTable lectura()
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

        public DataTable buscar(int id)
        {
            sql = "SELECT "
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_MATERIA"
                + " FROM "
                + "ESTUDIANTE"
                + " WHERE "
                + "ID_ESTUDIANTE = " + id;
            return mode.llenar(sql);
        }

        public void insertar(StudentEntity entestudiante)
        {
            sql = "INSERT INTO ESTUDIANTE ("
                + "ID_ESTUDIANTE,"
                + "NOMBRE,"
                + "APELLIDO,"
                + "DIRECCION,"
                + "EDAD,"
                + "ID_MATERIA"
                + ") VALUES ("
                + entestudiante.Estudiante + ","
                + "'" + entestudiante.Nombre + "',"
                + "'" + entestudiante.Apellido + "',"
                + "'" + entestudiante.Direccion + "',"
                + ""  + entestudiante.Edad + ","
                + ""  + entestudiante.Curso
                + ")";
            mode.ejecutar(sql);
        }

        public void modificar(StudentEntity entestudiante)
        {
            sql = "UPDATE ESTUDIANTE SET "
                + "NOMBRE = '" + entestudiante.Nombre + "',"
                + "APELLIDO = '" + entestudiante.Apellido + "',"
                + "DIRECCION = '" + entestudiante.Direccion + "',"
                + "EDAD = " + entestudiante.Edad + ","
                + "ID_MATERIA = " + entestudiante.Curso                
                + " WHERE "
                + "ID_ESTUDIANTE = " + entestudiante.Estudiante;
            mode.ejecutar(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE ESTUDIANTE "
                + "WHERE "
                + "ID_ESTUDIANTE = " + id;
            mode.ejecutar(sql);
        }

    }
}
