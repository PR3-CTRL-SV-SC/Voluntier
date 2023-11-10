using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Administrador_PCampaniaProgresoAdmin : System.Web.UI.Page
{
    ECCampania eCCampania = new ECCampania();
    ECParticipacion eCParticipacion;
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECParticipacion> lstParticipantes = new List<ECParticipacion>();
    List<ECUsuarioNetvalle> lstUsuarios = new List<ECUsuarioNetvalle>();

    private void LimpiarDatos()
    {
        rptParticipantes.DataSource = null;
        rptParticipantes.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LimpiarDatos();
            eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Convert.ToInt32(Session["codCampania"]));
            lstParticipantes = sWLNVoluntierClient.Obtener_CParticipacion_O_PorCampania(Convert.ToInt32(Session["codCampania"])).ToList();
            //foreach(var participantes in lstParticipantes)
            //{
            //    ClientScript.RegisterStartupScript(this.GetType(),"alertita", "alert('" + Session["codCampania"] + "');",true);
            //}
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

            string mesFin = eCCampania.FechaFinCampania.Month.ToString();
            string diaFin = eCCampania.FechaFinCampania.Day.ToString();
            string anioFin = eCCampania.FechaFinCampania.Year.ToString();

            string fechaInicio = SUtil.ConvertirFechas(diaInicio) + "/" + SUtil.ConvertirFechas(mesInicio) + "/" + anioInicio;
            string fechaCierre = SUtil.ConvertirFechas(diaFin) + "/" + SUtil.ConvertirFechas(mesFin) + "/" + anioFin;

            lblFechaInicio.Text = fechaInicio;
            lblFechaCierre.Text = fechaCierre;
            if (lstParticipantes.Count > 0 )
            {
                foreach (ECParticipacion participante in lstParticipantes)
                {
                    lstUsuarios.Add(sWLNVoluntierClient.Obtener_CUsuarioNetvalle_O_Codigo(participante.IdUsuarioParticipacion));
                }
                var lstParticipantesNombre = lstParticipantes.Join(lstUsuarios, p => p.IdUsuarioParticipacion.ToUpper(),
                                                                                u => u.CodigoUsuarioNetvalle.ToUpper(), 
                                                                                (p, u) => {
                                                                                    var horasMinutos = p.HorasParticipacion.Split(':');
                                                                                    if (horasMinutos.Length == 2)
                                                                                    {
                                                                                        string horas = horasMinutos[0];
                                                                                        string minutos = horasMinutos[1];
                                                                                        return new
                                                                                        {
                                                                                            p.IdUsuarioParticipacion,
                                                                                            Horas = horas,
                                                                                            Minutos = minutos,
                                                                                            NombreCompleto = u.NombreUsuarioNetvalle + " " + u.ApellidosUsuarioNetvalle
                                                                                        };
                                                                                    }
                                                                                    else
                                                                                    {
                                                                                        return new
                                                                                        {
                                                                                            p.IdUsuarioParticipacion,
                                                                                            Horas = "00",
                                                                                            Minutos = "00",
                                                                                            NombreCompleto = u.NombreUsuarioNetvalle + " " + u.ApellidosUsuarioNetvalle
                                                                                        };
                                                                                    }
                                                                                }).ToList();
                rptParticipantes.DataSource = lstParticipantesNombre;
                rptParticipantes.DataBind();

            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "ocultarTbSol", "document.getElementById('tbParticipantes').style.display = 'none';", true);
                lblNotificacion.Text = "NO TIENES PARTICIPANTES";
            }
        }
    }

    protected void btnAceptar_Command(object sender, CommandEventArgs e)
    {
        string idUsuario = "";
        int itemIndex = 0;
        string argument = e.CommandArgument as string;
        if (!string.IsNullOrEmpty(argument))
        {
            string[] argumentParts = argument.Split('|');
            if (argumentParts.Length == 2)
            {
                idUsuario = argumentParts[0];
                itemIndex = Convert.ToInt32(argumentParts[1]);
            }
        }
        RepeaterItem item = rptParticipantes.Items[itemIndex];

        TextBox txtHoras = (TextBox)item.FindControl("txtHoras");
        TextBox txtMinutos = (TextBox)item.FindControl("txtMinutos");

        eCParticipacion = new ECParticipacion();
        eCParticipacion = sWLNVoluntierClient.Obtener_CParticipacion_O_PorUsuario(idUsuario).Where(p => p.IdCampaniaParticipacion == Convert.ToInt32(Session["codCampania"].ToString())).First();
        eCParticipacion.HorasParticipacion = txtHoras.Text + ":" + txtMinutos.Text;
        //ClientScript.RegisterStartupScript(this.GetType(), "alertita", "alert('"+ eCParticipacion.HorasParticipacion +"');",true ) ;
        sWLNVoluntierClient.Actualizar_CParticipacion_A(eCParticipacion);
        Response.Redirect(Request.RawUrl);
    }
}