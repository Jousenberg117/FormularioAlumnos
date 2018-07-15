using System;
using System.Xml;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormularioServer.Common.Model;
using FormularioServer.Infrastructure.Repository.Manager;
using FormularioServer.Infrastructure.Repository.Interfaces;

namespace FormularioServer.Infrastructure.Repository.Repositories
{
    public class AlumnoRepository : IAlumnoRepository
    {
        Alumno miAlumno = new Alumno();
        
        public Alumno ParseJSON(string nombre, string apellidos, string dni)
        {
            miAlumno.nombre = nombre;
            miAlumno.apellido = apellidos;
            miAlumno.dni = dni;
            return miAlumno;
        }
        public Alumno add(Alumno alumno)
        {
            string jsonAlumno = alumno.ToString();
            jsonAlumno = JsonConvert.SerializeObject(alumno);
            try
            { 
            FileManager.Sobreescribir(jsonAlumno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return alumno;
        }
    }
}
