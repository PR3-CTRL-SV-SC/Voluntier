using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Administrador_PCampaniasAdmin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Valores dummy para simular una campaña
            string titulo = "Título de la Campaña Dummy";
            string descripcion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
            DateTime fechaInicio = DateTime.Now.AddDays(7); // Fecha de inicio en una semana
            DateTime fechaCierre = DateTime.Now.AddDays(30); // Fecha de cierre en 30 días

            // Asigna los valores a los controles en la vista
            lblTitulo.Text = titulo;
            lblDescripcion.Text = descripcion;
            lblFechas.Text = $"Fecha de Inicio: {fechaInicio:dd/MM/yyyy} - Fecha de Cierre: {fechaCierre:dd/MM/yyyy}";


            // Crear una lista de estudiantes de ejemplo
            List<Estudiante> estudiantes = new List<Estudiante>
            {
                new Estudiante { NombreEstudiante = "Estudiante 1", ID = 1 },
                new Estudiante { NombreEstudiante = "Estudiante 2", ID = 2 },
                new Estudiante { NombreEstudiante = "Estudiante 3", ID = 3 }
            };

            // Vincular la lista de estudiantes al Repeater
            rptSolicitudes.DataSource = estudiantes;
            rptSolicitudes.DataBind();
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        // Obtener el botón que se presionó
        Button btn = (Button)sender;

        // Obtener el ID del estudiante
        int id = Convert.ToInt32(btn.CommandArgument);

        // Buscar el estudiante en la base de datos
        // ...

        // Actualizar el estado del estudiante
        // ...

        // Actualizar la lista de estudiantes
        // ...
    }

    protected void btnDenegar_Click(object sender, EventArgs e)
    {
        // Obtener el botón que se presionó
        Button btn = (Button)sender;

        // Obtener el ID del estudiante
        int id = Convert.ToInt32(btn.CommandArgument);

        // Buscar el estudiante en la base de datos
        // ...

        // Actualizar el estado del estudiante
        // ...

        // Actualizar la lista de estudiantes
        // ...
    }

    public class Estudiante
    {
        public int ID { get; set; }
        public string NombreEstudiante { get; set; }
    }
}