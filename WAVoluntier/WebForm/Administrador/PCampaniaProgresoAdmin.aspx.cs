using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Administrador_PCampaniaProgresoAdmin : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    ECCampania eCCampania = new ECCampania();
    List<ECParticipacion> lstParticipantes = new List<ECParticipacion>();

    protected void Page_Load(object sender, EventArgs e)
    {
        eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Convert.ToInt32(Session["codCampania"]));
        lstParticipantes = sWLNVoluntierClient.Obtener_CParticipacion_O_PorCampania(Convert.ToInt32(Session["codCampania"])).ToList();

        if (!IsPostBack)
        {
            if (eCCampania.EstadoCampania == SDatosGlobales.EN_CURSO)
            {
                lblEstado.Text = "EN CURSO";
            }
            else if (eCCampania.EstadoCampania == SDatosGlobales.FINALIZADO)
            {
                lblEstado.Text = "FINALIZADO";
            }
            lblTitulo.Text = eCCampania.NombreCampania;
            lblDescripcion.Text = eCCampania.DescripcionCampania;
            string mesInicio = eCCampania.FechaInicioCampania.Month.ToString();
            string diaInicio = eCCampania.FechaInicioCampania.Day.ToString();
            string anioInicio = eCCampania.FechaInicioCampania.Year.ToString();

            string mesFin = eCCampania.FechaInicioCampania.Month.ToString();
            string diaFin = eCCampania.FechaInicioCampania.Day.ToString();
            string anioFin = eCCampania.FechaInicioCampania.Year.ToString();

            string fechaInicio = SUtil.ConvertirFechas(diaInicio) + "/" + SUtil.ConvertirFechas(mesInicio) + "/" + anioInicio;
            string fechaCierre = SUtil.ConvertirFechas(diaFin) + "/" + SUtil.ConvertirFechas(mesFin) + "/" + anioFin;

            lblFechaInicio.Text = fechaInicio;
            lblFechaCierre.Text = fechaCierre;
            if (lstParticipantes.Count > 0 )
            {
                rptParticipantes.DataSource = lstParticipantes;
                rptParticipantes.DataBind();

            }
            else
            {
                lblNotificacion.Text = "NO TIENES PARTICIPANTES";
            }
        }
    }

    protected void btnAceptar_Command(object sender, CommandEventArgs e)
    {

    }
}