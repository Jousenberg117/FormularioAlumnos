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
        public static string path { get; } = ConfigurationManager.AppSettings.Get("path") 
                                           + ConfigurationManager.AppSettings.Get("path_file");

        public static Boolean FileExist(string path)
        {
            return File.Exists(path);
        }
        public static Boolean FileCreate(string path)
        {
            Boolean Retorno= true;
            StreamWriter streamWriter = null;
            try
            {
                if (!File.Exists(path)) streamWriter = new StreamWriter(path);
            }
            catch(Exception ex)
            {
                Retorno = false;
                throw ex;
            }
            finally
            {
                if (streamWriter != null) streamWriter.Close();
            }
            return Retorno;
        }
        public static void Sobreescribir(string jsonAlumno)
        {
            if (!FileManager.FileExist(path))
                FileManager.FileCreate(path);
        
        StreamWriter fichero = new StreamWriter(path, true);
            try
            {
                fichero.WriteLine(jsonAlumno);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                fichero.Close();
            }
        }
        public static string Leer()
        {
            string alumnoRead = string.Empty;
            if (FileExist(path))
            {
                StreamReader fichero = new StreamReader(path);
                try
                {
                    do
                    {
                        alumnoRead = fichero.ReadLine();
                    }
                    while (!fichero.EndOfStream); 
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    fichero.Close();
                }
            }
            return alumnoRead;
        }
    }
}