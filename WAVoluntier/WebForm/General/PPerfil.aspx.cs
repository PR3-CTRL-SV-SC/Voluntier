using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_General_PPerfil : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Supongamos que obtienes los datos del usuario desde algún origen, por ejemplo:
            Usuario usuario = ObtenerDatosDelUsuario();

            // Asigna los datos del usuario a los controles en la página
            lblNombreUsuario.Text = usuario.Nombre;
            lblCarrera.Text = usuario.Carrera;
            lblSede.Text = usuario.Sede;
            lblHorasRegistradas.Text = usuario.HorasRegistradas.ToString();
        }
    }

    private Usuario ObtenerDatosDelUsuario()
    {
        // Aquí deberías implementar la lógica para obtener los datos del usuario desde tu fuente de datos (base de datos, servicio, etc.).
        // Puedes reemplazar esta función con tu propia lógica de obtención de datos.

        // Ejemplo de datos de usuario de prueba:
        return new Usuario
        {
            Nombre = "Juan Pérez",
            Carrera = "Ingeniería Informática",
            Sede = "Sede Principal",
            HorasRegistradas = 100
        };
    }
}
public class Usuario
{
    public string Nombre { get; set; }
    public string Carrera { get; set; }
    public string Sede { get; set; }
    public int HorasRegistradas { get; set; }
}