using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Administrador_PCampaniasAdmin : System.Web.UI.Page
{
    ECCampania eCCampania = new ECCampania();
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECSolicitudParticipacion> lstSolicitudes = new List<ECSolicitudParticipacion>();
    List<ECUsuario> lstUsuarios = new List<ECUsuario>();
    ECParticipacion eCParticipacion;

    protected void Page_Load(object sender, EventArgs e)
    {
        eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Convert.ToInt32(Session["codCampania"]));
        lstSolicitudes = sWLNVoluntierClient.Obtener_CSolicitudes_O_Campania(Convert.ToInt32(Session["codCampania"])).Where(s => s.EstadoSolicitud == SDatosGlobales.PENDIENTE ).ToList();

        if (!IsPostBack)
        {
            if (eCCampania.EstadoCampania == SDatosGlobales.APROBADO)
            {
                lblEstado.Text = "APROBADO";
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

            foreach (ECSolicitudParticipacion solicitud in lstSolicitudes)
            {
                lstUsuarios.Add(sWLNVoluntierClient.Obtener_CUsuario_O_Codigo(solicitud.IdUsuarioSolicitud));
            }

            //var lstDatosSolicitud = lstSolicitudes.Join(lstSolicitudes, s => s.IdUsuarioSolicitud, u => u.IdUsuarioSolicitud, (s, u) => new { s, u }).ToList();
            if (lstSolicitudes.Count > 0)
            {
                rptSolicitudes.DataSource = lstSolicitudes;
                rptSolicitudes.DataBind();

            }
            else
            {
                lblNotificacion.Text = "NO TIENES SOLICITUDES";
            }
            
        }
    }

    protected void btnAceptar_Command(object sender, CommandEventArgs e)
    {
        string argument = e.CommandArgument.ToString();
        string[] arguments = argument.Split('|');

        if (arguments.Length == 2)
        {
            string idUsuario = arguments[0];
            int idSolicitud = Convert.ToInt32(arguments[1]);
            eCParticipacion = new ECParticipacion();
            eCParticipacion.IdCampaniaParticipacion = Convert.ToInt32(Session["codCampania"]);
            eCParticipacion.IdUsuarioParticipacion = idUsuario;
            eCParticipacion.EstadoParticipacion = SDatosGlobales.SIN_TIEMPO;
            sWLNVoluntierClient.Insertar_CParticipacion_I(eCParticipacion);
            sWLNVoluntierClient.Actualizar_CSolicitud_A_Estado(idSolicitud, SDatosGlobales.APROBADO);
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void btnDenegar_Command(object sender, CommandEventArgs e)
    {
        sWLNVoluntierClient.Actualizar_CSolicitud_A_Estado(Convert.ToInt32(Session["codCampania"]), SDatosGlobales.RECHAZADO);
        Response.Redirect(Request.RawUrl);
    }
}