using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFProgra2
{
    public class StudentEntity
    {
        private int id_estudiante;
        private string nombre;
        private string apellido;
        private string direccion;
        private int edad;
        private string id_curso;

        public int Estudiante
        {
            get
            {
                return id_estudiante;
            }
            set
            {
                id_estudiante = value;
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
        public string Direccion
        {
            get
            {
                return direccion;
            }
            set
            {
                direccion = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }

        public string Curso
        {
            get
            {
                return id_curso;
            }
            set
            {
                id_curso = value;
            }
        }

        public StudentEntity()
        {
            id_estudiante = int.MinValue;
            nombre = string.Empty;
            apellido = string.Empty;
            direccion = string.Empty;
            edad = int.MinValue;
            id_curso = string.Empty;
        }
    }
}
