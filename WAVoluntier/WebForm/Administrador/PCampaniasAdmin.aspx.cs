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
    List<ECSolicitudParticipacion> lstSolicitudes;
    List<ECUsuarioNetvalle> lstUsuarios = new List<ECUsuarioNetvalle>();
    ECParticipacion eCParticipacion;

    protected void Page_Load(object sender, EventArgs e)
    {
        lstSolicitudes = new List<ECSolicitudParticipacion>();
        eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Convert.ToInt32(Session["codCampania"]));
        lstSolicitudes = sWLNVoluntierClient.Obtener_CSolicitudes_O_Campania(Convert.ToInt32(Session["codCampania"])).ToList();

        if (!IsPostBack)
        {
            lblTitulo.Text = eCCampania.NombreCampania;
            lblDescripcion.Text = eCCampania.DescripcionCampania;
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
            if (eCCampania.EstadoCampania == SDatosGlobales.PENDIENTE)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "ocultarTbSol", "document.getElementById('tbSolicitudes').style.display = 'none';", true);
                lblNotificacion.Text = "NO PUEDES RECIBIR SOLICITUDES HASTA QUE LA CAMPAÑA SEA APROBADA";
            }
            if (eCCampania.EstadoCampania == SDatosGlobales.APROBADO)
            {
                lblEstado.Text = "APROBADO";
                foreach (ECSolicitudParticipacion solicitud in lstSolicitudes)
                {
                    {
                        lstUsuarios.Add(sWLNVoluntierClient.Obtener_CUsuarioNetvalle_O_Codigo(solicitud.IdUsuarioSolicitud));
                    }
                }
                var lstSolicitudesNombre = lstSolicitudes.Where(s => s.EstadoSolicitud == SDatosGlobales.PENDIENTE).Join(lstUsuarios, s => s.IdUsuarioSolicitud.ToUpper(), u => u.CodigoUsuarioNetvalle.ToUpper(), (s, u) => new { s.IdSolicitud, s.IdUsuarioSolicitud, NombreCompleto = u.NombreUsuarioNetvalle + " " + u.ApellidosUsuarioNetvalle }).ToList();
                var lstAceptados = lstSolicitudes.Where(s => s.EstadoSolicitud == SDatosGlobales.APROBADO).Join(lstUsuarios, s => s.IdUsuarioSolicitud.ToUpper(), u => u.CodigoUsuarioNetvalle.ToUpper(), (s, u) => new { NombreCompleto = u.NombreUsuarioNetvalle + " " + u.ApellidosUsuarioNetvalle }).ToList();
                var lstRechazados = lstSolicitudes.Where(s => s.EstadoSolicitud == SDatosGlobales.RECHAZADO).Join(lstUsuarios, s => s.IdUsuarioSolicitud.ToUpper(), u => u.CodigoUsuarioNetvalle.ToUpper(), (s, u) => new { NombreCompleto = u.NombreUsuarioNetvalle + " " + u.ApellidosUsuarioNetvalle }).ToList();
                if (lstSolicitudesNombre.Count > 0)
                {
                    rptSolicitudes.DataSource = lstSolicitudesNombre;
                    rptSolicitudes.DataBind();
                }
                else
                {
                    lblNotificacion.Text = "NO TIENES SOLICITUDES";
                    ClientScript.RegisterStartupScript(this.GetType(), "ocultarTbSol", "document.getElementById('tbSolicitudes').style.display = 'none';", true);
                }
                //ClientScript.RegisterStartupScript(this.GetType(), "alertita", "alert('" + lstRechazados.Count + "');", true);
                if (lstAceptados.Count > 0 || lstRechazados.Count > 0)
                {
                    rptAceptados.DataSource = lstAceptados;
                    rptAceptados.DataBind();
                    rptRechazados.DataSource = lstRechazados;
                    rptRechazados.DataBind();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "OcultarTbRes", "document.getElementById('tbResultados').style.display = 'none';", true);
                }
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
            eCParticipacion.HorasParticipacion = "00:00";
            sWLNVoluntierClient.Insertar_CParticipacion_I(eCParticipacion);
            sWLNVoluntierClient.Actualizar_CSolicitud_A_Estado(idSolicitud, SDatosGlobales.APROBADO);
            Response.Redirect(Request.RawUrl);
        }
    }

    protected void btnDenegar_Command(object sender, CommandEventArgs e)
    {
        int idSolicitud = Convert.ToInt32(e.CommandArgument);
        sWLNVoluntierClient.Actualizar_CSolicitud_A_Estado(idSolicitud, SDatosGlobales.RECHAZADO);
        Response.Redirect(Request.RawUrl);
    }
}