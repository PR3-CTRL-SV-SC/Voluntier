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
    List<ECCampania> lstCampanias, lstValidar;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            controlarCampanias();
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

    private void controlarCampanias()
    {
        lstValidar = new List<ECCampania>();
        lstValidar = sWLNVoluntierClient.Obtener_CCampania_O().Where(c => c.EstadoCampania == "AP").ToList();

        foreach (var item in lstValidar)
        {
            if (item.FechaInicioCampania < DateTime.Now)
            {
                sWLNVoluntierClient.Actualizar_CCampania_A_Estado(item.IdCampania, SDatosGlobales.EN_CURSO);
            }
        }
        CargarDatos();
    }

    protected void btnVer_Command(object sender, CommandEventArgs e)
    {
        int IdCampania = Convert.ToInt32(e.CommandArgument);
        Session["codCampania"] = IdCampania;
        Session["Url"] = "PListaCampanias.aspx";
        Response.Redirect("PCampania.aspx");
    }

    protected void timerControl_Tick(object sender, EventArgs e)
    {
        //ClientScript.RegisterStartupScript(this.GetType(), "avisoTimer", "alert('EMPEZO EL EVENTO');", true);
        controlarCampanias();
    }
}
