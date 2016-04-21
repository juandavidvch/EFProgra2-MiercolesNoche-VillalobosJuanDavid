using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProgra2
{
    public class TeacherEntity
    {
        private int id_profesor;
        private string nombre;
        private string apellido;

        public int Profesor
        {
            get
            {
                return id_profesor;
            }
            set
            {
                id_profesor = value;
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
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        public TeacherEntity()
        {
            id_profesor = int.MinValue;
            nombre = string.Empty;
            apellido = string.Empty;
        }


    }
}
