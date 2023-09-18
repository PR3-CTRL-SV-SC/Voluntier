using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PListaCampanias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            // Crear una lista de datos ficticios (dummies)
            List<Campania> listaCampañas = new List<Campania>
            {
                new Campania { NombreCampaña = "Campaña 1", Descripcion = "Descripción de la Campaña 1", FechaInicio = new DateTime(2023, 1, 1), FechaCierre = new DateTime(2023, 1, 31) },
                new Campania { NombreCampaña = "Campaña 2", Descripcion = "Descripción de la Campaña 2", FechaInicio = new DateTime(2023, 2, 15), FechaCierre = new DateTime(2023, 3, 15) },
                new Campania { NombreCampaña = "Campaña 3", Descripcion = "Descripción de la Campaña 3", FechaInicio = new DateTime(2023, 4, 10), FechaCierre = new DateTime(2023, 4, 30) }
                // Agrega más datos ficticios según sea necesario
            };

            // Vincular la lista de campañas al Repeater
            rptCampañas.DataSource = listaCampañas;
            rptCampañas.DataBind();
        }
    }

    // Clase para representar una campaña
    public class Campania
    {
        public string NombreCampaña { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaCierre { get; set; }
    }
}
