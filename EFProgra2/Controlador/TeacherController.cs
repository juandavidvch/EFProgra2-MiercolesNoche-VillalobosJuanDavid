using System.Data;

namespace EFProgra2
{
    class TeacherController
    {
        Modelo mode = new Modelo();
        TeacherEntity profesor = new TeacherEntity();
        string sql;

        public DataTable lectura()
        {
            sql = "SELECT "
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + " FROM "
                + "PROFESOR";
            return mode.llenar(sql);
        }

        public void insertar(TeacherEntity entProfe)
        {
            sql = "INSERT INTO PROFESOR ("
                + "ID_PROFESOR,"
                + "NOMBRE,"
                + "APELLIDO"
                + ") VALUES ("
                + entProfe.Profesor + ","
                + "'" + entProfe.Nombre + "',"
                + "'" + entProfe.Apellido + "'"
                + ")";
            mode.ejecutar(sql);
        }

        public void modificar(TeacherEntity entProfe)
        {
            sql = "UPDATE PROFESOR SET "
                + "NOMBRE = '" + entProfe.Nombre + "',"
                + "APELLIDO = '" + entProfe.Apellido + "'"
                + " WHERE "
                + "ID_PROFESOR = " + entProfe.Profesor;
            mode.ejecutar(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE PROFESOR "
                + "WHERE "
                + "ID_PROFESOR = " + id;
            mode.ejecutar(sql);
        }
    }
}
