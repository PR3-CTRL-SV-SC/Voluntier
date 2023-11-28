using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PMenuEstudiante : System.Web.UI.Page
{
    List<ECCampania> lstValidar;
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        lstValidar = new List<ECCampania>();
        lstValidar = sWLNVoluntierClient.Obtener_CCampania_O().Where(c => c.EstadoCampania == SDatosGlobales.APROBADO && c.EstadoCampania == SDatosGlobales.EN_CURSO).ToList();

        foreach (var item in lstValidar)
        {
            if (item.FechaInicioCampania < DateTime.Now && item.FechaFinCampania > DateTime.Now)
            {
                sWLNVoluntierClient.Actualizar_CCampania_A_Estado(item.IdCampania, SDatosGlobales.EN_CURSO);
            }
            else if (item.FechaFinCampania < DateTime.Now)
            {
                sWLNVoluntierClient.Actualizar_CCampania_A_Estado(item.IdCampania, SDatosGlobales.FINALIZADO);
            }
        }
    }
}