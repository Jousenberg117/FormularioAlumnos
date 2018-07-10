using System;
using System.IO;                // Files
using System.Configuration;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormularioServer.Infrastructure.Repository.Manager
{
    public class FileManager
    {
        // Path del fichero
        public static string path { get; } = ConfigurationManager.AppSettings.Get("path");

        public static void Sobreescribir(string jsonAlumno)
        {
            StreamWriter fichero = new StreamWriter(path, true);

                    fichero.WriteLine(jsonAlumno);
                    fichero.Close();
        }
    }
}
