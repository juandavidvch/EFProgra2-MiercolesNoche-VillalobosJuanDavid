using System.Data;

namespace EFProgra2
{
    class SubjectController
    {
        Modelo mode = new Modelo();
        SubjectEntity materia = new SubjectEntity();
        string sql;

        public DataTable lectura()
        {
            sql = "SELECT "
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + " FROM "
                + "MATERIA";
            return mode.llenar(sql);
        }

        public void insertar(SubjectEntity entMateria)
        {
            sql = "INSERT INTO MATERIA ("
                + "ID_MATERIA,"
                + "NOMBRE,"
                + "ID_PROFESOR"
                + ") VALUES ("
                + entMateria.Materia  + ","
                + "'" + entMateria.Nombre + "',"
                + "" + entMateria.Profesor
                + ")";
            mode.ejecutar(sql);
        }

        public void modificar(SubjectEntity entMateria)
        {
            sql = "UPDATE MATERIA SET "
                + "NOMBRE = '" + entMateria.Nombre + "',"
                + "ID_PROFESOR = " + entMateria.Profesor
                + " WHERE "
                + "ID_MATERIA = " + entMateria.Materia;
            mode.ejecutar(sql);
        }

        public void eliminar(int id)
        {
            sql = "DELETE MATERIA "
                + "WHERE "
                + "ID_MATERIA = " + id;
            mode.ejecutar(sql);
        }
    }
}
