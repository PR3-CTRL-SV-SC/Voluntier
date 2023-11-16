using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WebForm_Administrador_PCampaniasPropuestas : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> eCCampanias;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            CargarDatos();
        }
    }
    
    private void CargarDatos()
    {
        eCCampanias = new List<ECCampania>();
        try
        {
            eCCampanias = sWLNVoluntierClient.Obtener_CCampania_O().ToList();
            var campaniasPendientes = eCCampanias.Where(c => c.EstadoCampania == SDatosGlobales.PENDIENTE).ToList();

            if (campaniasPendientes.Count < 1)
            {
                lblNotificacion.Text = "NO EXISTEN CAMPAÑAS PENDIENTES";
            }
            else
            {
                rptCampañas.DataSource = campaniasPendientes;
                rptCampañas.DataBind();
            }    
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        int valId = Convert.ToInt32(Session["codCampania"]);
        sWLNVoluntierClient.Actualizar_CCampania_A_Estado(valId, SDatosGlobales.APROBADO);
        Response.Redirect("PGestionCampanias.aspx");
    }

    protected void btnNegar_Click(object sender, EventArgs e)
    {
        int valId = Convert.ToInt32(Session["codCampania"]);
        sWLNVoluntierClient.Actualizar_CCampania_A_Estado(valId, SDatosGlobales.RECHAZADO);
        Response.Redirect("PGestionCampanias.aspx");
    }

    protected void btnAceptar_Command(object sender, CommandEventArgs e)
    {
        string argument = e.CommandArgument as string;
        if (!string.IsNullOrEmpty(argument))
        {
            string[] argumentParts = argument.Split('|');
            if (argumentParts.Length == 2)
            {
                int itemId = Convert.ToInt32(argumentParts[0]);
                string nombre = argumentParts[1];
                Session["codCampania"] = itemId;
                //ClientScript.RegisterStartupScript(this.GetType(), "probando", "alert(" + itemId +");", true);
                lblCampaniaAceptada.Text = nombre.ToString();
            }
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "AbrirAceptar()", true);
    }

    protected void btnRechazar_Command(object sender, CommandEventArgs e)
    {
        string argument = e.CommandArgument as string;
        if (!string.IsNullOrEmpty(argument))
        {
            string[] argumentParts = argument.Split('|');
            if (argumentParts.Length == 2)
            {
                int itemId = Convert.ToInt32(argumentParts[0]);
                string nombre = argumentParts[1];
                Session["codCampania"] = itemId;

                lblCampaniaRechazada.Text = nombre.ToString();
            }
        }
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "AbrirRechazar()", true);
    }
    protected void btnCerrarAceptacion_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "CerrarAceptar()", true);
    }

    protected void btnCerrarRechazo_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "CerrarRechazar()", true);
    }
}