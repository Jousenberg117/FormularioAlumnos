using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FormularioServer.Common.Model;

namespace FormularioServer.Infrastructure.Repository.Interfaces
{
    public interface IAlumnoRepository
    {
        Alumno add(Alumno alumno);
    }
}
