namespace EFProgra2
{
    public class SubjectEntity
    {
        private int id_materia;
        private string nombre;
        private int profesor;

        public int Materia
        {
            get
            {
                return id_materia;
            }
            set
            {
                id_materia = value;
            }
        }

        public int Profesor
        {
            get
            {
                return profesor;
            }
            set
            {
                profesor = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public SubjectEntity()
        {
            id_materia = int.MinValue;
            nombre = string.Empty;
            profesor = int.MinValue;
        }

    }
}
