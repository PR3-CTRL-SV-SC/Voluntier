using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PListaCampanias : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> lstCampanias;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            CargarDatos();
        }
    }

    private void CargarDatos()
    {
        lstCampanias = new List<ECCampania>();
        try
        {
            lstCampanias = sWLNVoluntierClient.Obtener_CCampania_O().Where(c => c.EstadoCampania == "AP").OrderBy(c => c.FechaInicioCampania).ToList();

            if (lstCampanias.Count < 1)
            {
                lblNotificacion.Text = "NO TIENES CAMPAÑAS DISPONIBLES";
            }
            else
            {
                rptCampañas.DataSource = lstCampanias;
                rptCampañas.DataBind();
            }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    protected void btnVer_Command(object sender, CommandEventArgs e)
    {
        int IdCampania = Convert.ToInt32(e.CommandArgument);
        Session["codCampania"] = IdCampania;
        Session["Url"] = "PListaCampanias.aspx";
        Response.Redirect("PCampania.aspx");
    }
}
