using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PLogin : System.Web.UI.Page
{
    SWLNVoluntierClient swLNVoluntier = new SWLNVoluntierClient();
    ECUsuario eCUsuario = new ECUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        swLNVoluntier = new SWLNVoluntierClient();
        eCUsuario = new ECUsuario();
        eCUsuario = swLNVoluntier.Obtener_CUsuario_O_Codigo(txtUsername.Text.Trim());
        if (eCUsuario.CodigoUsuario.Trim() != "")
        {
            lblMensaje.Text = "Busca";
            Session["Codigo"] = eCUsuario.CodigoUsuario.ToUpper();
            if (eCUsuario.RolUsuario == "AD")
            {
                Session["Rol"] = "ADMINISTRATIVO";
                Session["Sede"] = "C";
                Response.Redirect("/WebForm/Administrador/PMenuAdministrador.aspx");
            }
            if (eCUsuario.RolUsuario == "ES")
            {
                Session["Rol"] = "ESTUDIANTE";
                Response.Redirect("/WebForm/Usuario/PMenuEstudiante.aspx");
            }
        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('VERIFIQUE LA INFORMACION INGRESADA')", true);
        }
    }
}