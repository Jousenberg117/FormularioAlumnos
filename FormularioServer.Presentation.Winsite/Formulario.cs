using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Tracing;
using System.Windows.Forms;
using FormularioServer.Common.Model;
using FormularioServer.Infrastructure.Repository.Repositories;

namespace FormularioAlumnos
{
    public partial class Formulario : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Formulario()
        {
            InitializeComponent();
        }

        Alumno jsonAlumno = new Alumno();
        AlumnoRepository repository = new AlumnoRepository();

        // Evento clic del boton registrar, al clicar se rellena el objeto Alumno, y es almacenado en un JSON.
        private void BotonRegistrar(object sender, EventArgs e)
        {
            // Obtener JSON con datos formulario
            jsonAlumno = repository.ParseJSON(textName.Text, textLastName.Text, textDNI.Text);
            try
            {
                repository.add(jsonAlumno);
               
                log.Debug(jsonAlumno);
            }
            catch (Exception ex)
            {
                log.Error(ex.Message, ex);
                throw ex;
            }
            
            
            // Aviso de que ha sido creado, y llamada al Add para escribir en el fichero.
            MessageBox.Show("¡Se ha guardado correctamente, puedes leer el archivo!");
           

            // Limpiar el formulario
            textName.Clear();
            textLastName.Clear();
            textDNI.Clear();
        }

   

    }
}
