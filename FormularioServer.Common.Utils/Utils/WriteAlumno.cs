using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.Xml;
using Newtonsoft.Json;          // JSONs
using System.IO;                // Files
using FormularioServer.Common.Model;

namespace FormularioServer.Common.FileManager
{
      public class WriteAlumno
    {
            Alumno miAlumno = new Alumno();

        
            // Funcion para generar el JSON
            public string ParseJSON(string nombre, string apellidos, string dni)
            {
                miAlumno.nombre = nombre;
                miAlumno.apellido = apellidos;
                miAlumno.dni = dni;

                string jsonAlumno = JsonConvert.SerializeObject(miAlumno);

            // Path del fichero
            string path = ConfigurationManager.AppSettings.Get("path");


            // Sobreescribir 
            using (StreamWriter fichero = new StreamWriter(path, true))
                {
                    //fichero.WriteLine(jsonAlumno);
                    fichero.WriteLine(jsonAlumno);
                    fichero.Close();
                    return jsonAlumno;
                }
            }

            /*
                // Evento clic del boton registrar, al clicar se rellena el objeto Alumno, y es almacenado en un JSON.
                private void Boton_registrar(object sender, EventArgs e)
                {
                    // Obtener JSON con datos formulario
                    string jsonAlumno = ParseJSON(Convert.ToInt32(textBox_id.Text), textBox_name.Text, textBox_apellidos.Text, textBox_dni.Text);

                    // Añadir a fichero
                    bool res = Add(jsonAlumno);
                    if (res == true)
                    {
                        // Aviso de que ha sido creado, y llamada al Add para escribir en el fichero.
                        MessageBox.Show("¡Se ha guardado correctamente, puedes leer el archivo!");
                    }
                    else
                    {
                        MessageBox.Show("¡Ooooh no se ha podido guardar!");
                    }

                    // Limpiar el formulario
                    textBox_id.Clear();
                    textBox_name.Clear();
                    textBox_apellidos.Clear();
                    textBox_dni.Clear();
                }

                // Funcion para generar el JSON
                public string ParseJSON(int id, string nombre, string apellidos, string dni)
                {
                    miAlumno.Id = id;
                    miAlumno.Nombre = nombre;
                    miAlumno.Apellidos = apellidos;
                    miAlumno.Dni = dni;

                    string jsonAlumno = JsonConvert.SerializeObject(miAlumno);
                    return jsonAlumno;
                }

                public bool Add(string jsonAlumno)
                {
                    // Path del fichero
                    string path = @"C:/Users/jhoubbertM/Downloads/Formulario-.NET-master/alumnos.txt";

                    // Check de si existe el fichero.
                    if (!File.Exists(path))
                    {
                        File.Create(path).Dispose();

                        // Creamos el fichero con el path.
                        using (TextWriter fichero = new StreamWriter(path))
                        {
                            // Se escribe el objeto Alumno en el fichero.
                            //fichero.WriteLine(jsonAlumno); 
                            fichero.Write(jsonAlumno);  // Al hacer writeLines inserta por defecto \n\r, por eso ha sido modificado por write
                        }

                    }
                    // Abrimos el fichero del path
                    else if (File.Exists(path))
                    {
                        // Sobreescribir 
                        using (TextWriter fichero = new StreamWriter(path))
                        {
                            //fichero.WriteLine(jsonAlumno);
                            fichero.Write(jsonAlumno);
                        }

                    }

                    string textoFichero = File.ReadAllText(path);
                    bool comparacion = String.Equals(textoFichero, jsonAlumno);

                    return comparacion;
                }*/


        }
    }

