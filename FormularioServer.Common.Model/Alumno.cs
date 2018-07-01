using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileServer.Common.Model
{
    public class Alumno
    {
        public int IdAlmuno { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }


        public Alumno()
        {
        }
        public Alumno(int IdAlmuno, string nombre, string apellido, string dni)
        {
            this.IdAlmuno = IdAlmuno;
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

        public override bool Equals(object obj)
        {
            var alumno = obj as Alumno;
            return alumno != null &&
                   IdAlmuno == alumno.IdAlmuno &&
                   nombre == alumno.nombre &&
                   apellido == alumno.apellido &&
                   dni == alumno.dni;
        }

        public override int GetHashCode()
        {
            var hashCode = -433359479;
            hashCode = hashCode * -1521134295 + IdAlmuno.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(nombre);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(apellido);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(dni);
            return hashCode;
        }
    }
}
