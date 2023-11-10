using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PCampania : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    ECCampania eCCampania = new ECCampania();
    List<ECSolicitudParticipacion> lstSolicitudes = new List<ECSolicitudParticipacion>();
    ECSolicitudParticipacion eCSolicitudParticipacion;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Convert.ToInt32(Session["codCampania"]));
        lstSolicitudes = sWLNVoluntierClient.Obtener_CSolicitudes_O_Campania(Convert.ToInt32(Session["codCampania"])).Where(c => c.IdUsuarioSolicitud == Session["Codigo"].ToString()).ToList();

        if (!IsPostBack)
        {
            if (lstSolicitudes.Count > 0)
            {
                btnPostular.Text = "YA POSTULASTE";
                btnPostular.Enabled = false;
                btnPostular.BackColor = System.Drawing.Color.DarkGray;
            }
            lblCampania.Text = eCCampania.NombreCampania.ToUpper();
            lblDescripcion.Text = eCCampania.DescripcionCampania.ToString();
            string mesInicio = eCCampania.FechaInicioCampania.Month.ToString();
            string diaInicio = eCCampania.FechaInicioCampania.Day.ToString();
            string anioInicio = eCCampania.FechaInicioCampania.Year.ToString();

            string mesFin = eCCampania.FechaFinCampania.Month.ToString();
            string diaFin = eCCampania.FechaFinCampania.Day.ToString();
            string anioFin = eCCampania.FechaFinCampania.Year.ToString();

            string fechaInicio = SUtil.ConvertirFechas(diaInicio) + "/" + SUtil.ConvertirFechas(mesInicio) + "/" + anioInicio;
            string fechaCierre = SUtil.ConvertirFechas(diaFin) + "/" + SUtil.ConvertirFechas(mesFin) + "/" + anioFin;

            lblFechaInicio.Text = fechaInicio;
            lblFechaCierre.Text = fechaCierre;
        }
    }

    protected void btnPostular_Click(object sender, EventArgs e)
    {
        lblModalCampania.Text = eCCampania.NombreCampania.ToUpper();
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        eCSolicitudParticipacion = new ECSolicitudParticipacion();
        eCSolicitudParticipacion.IdUsuarioSolicitud = Session["Codigo"].ToString();
        eCSolicitudParticipacion.IdCampaniaSolicitud = Convert.ToInt32(Session["codCampania"]);
        eCSolicitudParticipacion.EstadoSolicitud = SDatosGlobales.PENDIENTE;
        sWLNVoluntierClient.Insertar_CSolicitud_I(eCSolicitudParticipacion);
        Response.Redirect("PListaCampanias.aspx");
    }

    protected void btnCerrar_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }

    protected void btnAtras_Click(object sender, EventArgs e)
    {
        string lastUrl = Session["Url"].ToString();
        Response.Redirect(lastUrl);
    }
}