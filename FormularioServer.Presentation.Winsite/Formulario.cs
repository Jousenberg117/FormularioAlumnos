using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FormularioServer.Common.Model;

namespace FormularioAlumnos
{
    public partial class Formulario : Form
    {
        

        public Formulario()
        {
            InitializeComponent();
        }
        WriteAlumno Write = new WriteAlumno();

        // Evento clic del boton registrar, al clicar se rellena el objeto Alumno, y es almacenado en un JSON.
        private void BotonRegistrar(object sender, EventArgs e)
        {
            // Obtener JSON con datos formulario
            string jsonAlumno = Write.ParseJSON(textName.Text, textLastName.Text, textDNI.Text);
            
            
            // Aviso de que ha sido creado, y llamada al Add para escribir en el fichero.
            MessageBox.Show("¡Se ha guardado correctamente, puedes leer el archivo!");
           

            // Limpiar el formulario
            textName.Clear();
            textLastName.Clear();
            textDNI.Clear();
        }

   

        /*  public bool Add(string jsonAlumno)
          {

              // Check de si existe el fichero.
              if (!File.Exists(path))
              {
                  File.Create(path).Dispose();

                  // Creamos el fichero con el path.
                  using (StreamWriter fichero = new StreamWriter(path))
                  {
                      // Se escribe el objeto Alumno en el fichero.
                      //fichero.WriteLine(jsonAlumno); 
                      fichero.WriteLine(jsonAlumno);  // Al hacer writeLines inserta por defecto \n\r, por eso ha sido modificado por write
                  }

              }
              // Abrimos el fichero del path
              else if (File.Exists(path))
              {

              }*/

        /* string textoFichero = File.ReadAllText(path);
         bool comparacion = String.Equals(textoFichero, jsonAlumno);

         return comparacion;
     }*/


    }
}
