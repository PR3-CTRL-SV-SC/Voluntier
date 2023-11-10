using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Usuario_PMisCampanias : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> lstCampanias = new List<ECCampania>();
    List<ECSolicitudParticipacion> lstSolicitudes = new List<ECSolicitudParticipacion>();
    List<ECParticipacion> lstParticipacion = new List<ECParticipacion>();
    List<ECParticipacion> lstPartiHoras = new List<ECParticipacion>();

    private void LimpiarDatos()
    {
        lstCampanias.Clear();
        lstSolicitudes.Clear();
        lstParticipacion.Clear();
        gvListaCampanias.DataSource = null;
        gvListaCampanias.DataBind();
        lblNotificacion.Text = "";
    }

    private void CargarHoras ()
    {
        lstPartiHoras = sWLNVoluntierClient.Obtener_CParticipacion_O_PorUsuario(Session["Codigo"].ToString()).ToList();
        if (lstPartiHoras.Count > 0)
        {
            int totalMinutos = 0;
            string totalTiempo = "00:00";
            foreach (var item in lstPartiHoras)
            {
                var tiempo = item.HorasParticipacion.Split(':');
                if (tiempo.Length == 2)
                {
                    int h = Convert.ToInt32(tiempo[0]);
                    int m = Convert.ToInt32(tiempo[1]);

                    totalMinutos += (h * 60) + m;
                    totalTiempo = string.Format("{0:D2}:{1:D2}", totalMinutos / 60, totalMinutos % 60);

                }
            }
            lblHoras.Text = totalTiempo + " /150:00 Horas";
        }
        else
        {
            lblHoras.Text = "0 /150 Horas";
        }
    }
    
    private void CargarPendientes()
    {
        LimpiarDatos();
        lblOpciones.Text = "Lista de Solicitudes Pendientes";
        lstSolicitudes = sWLNVoluntierClient.Obtener_CSolicitudes_O_Usuario(Session["Codigo"].ToString()).Where(s => s.EstadoSolicitud == SDatosGlobales.PENDIENTE).ToList();
        foreach (ECSolicitudParticipacion solicitud in lstSolicitudes)
        {
            lstCampanias.Add(sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(solicitud.IdCampaniaSolicitud));
        }
        var lstTabla = lstCampanias.Join(lstSolicitudes, c => c.IdCampania, s => s.IdCampaniaSolicitud, (c, s) => new { c.IdCampania, c.NombreCampania, EstadoCampania = SUtil.TransformarEstados(c.EstadoCampania) ,s.EstadoSolicitud, HorasParticipacion = "-" }).ToList();
        if (lstTabla.Count > 0)
        {
            gvListaCampanias.DataSource = lstTabla;
            gvListaCampanias.DataBind();
        }
        else
        {
            lblNotificacion.Text = "No hay solicitudes pendientes";
        }
    }

    private void CargarAprobados()
    {
        LimpiarDatos();
        lblOpciones.Text = "Lista de Solicitudes Aprobadas";
        lstParticipacion = sWLNVoluntierClient.Obtener_CParticipacion_O_PorUsuario(Session["Codigo"].ToString()).ToList();
        foreach (ECParticipacion participacion in lstParticipacion)
        {
            lstCampanias.Add(sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(participacion.IdCampaniaParticipacion));
        }
        var lstTabla = lstCampanias.Join(lstParticipacion, c => c.IdCampania, p => p.IdCampaniaParticipacion, (c, p) => new { c.IdCampania, c.NombreCampania, EstadoCampania = SUtil.TransformarEstados(c.EstadoCampania), EstadoSolicitud = p.EstadoParticipacion, p.HorasParticipacion }).ToList();
        if (lstTabla.Count > 0)
        {
            gvListaCampanias.DataSource = lstTabla;
            gvListaCampanias.DataBind();
        }
        else
        {
            lblNotificacion.Text = "No hay solicitudes aprobadas";
        }
    }

    private void CargarRechazados()
    {
        LimpiarDatos();
        lblOpciones.Text = "Lista de Solicitudes Rechazadas";
        lstSolicitudes = sWLNVoluntierClient.Obtener_CSolicitudes_O_Usuario(Session["Codigo"].ToString()).Where(s => s.EstadoSolicitud == SDatosGlobales.RECHAZADO).ToList();
        foreach (ECSolicitudParticipacion solicitud in lstSolicitudes)
        {
            lstCampanias.Add(sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(solicitud.IdCampaniaSolicitud));
        }
        var lstTabla = lstCampanias.Join(lstSolicitudes, c => c.IdCampania, s => s.IdCampaniaSolicitud, (c, s) => new { c.IdCampania, c.NombreCampania, EstadoCampania = SUtil.TransformarEstados(c.EstadoCampania), s.EstadoSolicitud, HorasParticipacion = "-" }).ToList();
        if (lstTabla.Count > 0)
        {
            gvListaCampanias.DataSource = lstTabla;
            gvListaCampanias.DataBind();
        }
        else
        {
            lblNotificacion.Text = "No hay solicitudes rechazadas";
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        CargarAprobados();
        CargarHoras();
    }
    
    protected void btnPendientes_Click(object sender, EventArgs e)
    {
        CargarPendientes();
    }

    protected void btnAprobados_Click(object sender, EventArgs e)
    {
        CargarAprobados();
    }

    protected void btnRechazados_Click(object sender, EventArgs e)
    {
        CargarRechazados();
    }

    protected void btnVer_Command(object sender, CommandEventArgs e)
    {
        int idCampania = Convert.ToInt32(e.CommandArgument);
        Session["codCampania"] = idCampania;
        Session["Url"] = "PMisCampanias.aspx";

        Response.Redirect("PCampania.aspx");
    }
}