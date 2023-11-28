using SWLNVoluntier;
using System;
using System.Web.UI;

public partial class PLogin : System.Web.UI.Page
{
    SWLNVoluntierClient swLNVoluntier = new SWLNVoluntierClient();
    ECUsuario eCUsuario = new ECUsuario();
    ECUsuarioNetvalle usuarioNetvalle = new ECUsuarioNetvalle();
    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        swLNVoluntier = new SWLNVoluntierClient();
        eCUsuario = new ECUsuario();
        usuarioNetvalle = new ECUsuarioNetvalle();
        eCUsuario = swLNVoluntier.Obtener_CUsuario_O_Codigo(txtUsername.Text.Trim());
        usuarioNetvalle = swLNVoluntier.Obtener_CUsuarioNetvalle_O_Codigo(txtUsername.Text.Trim());
        if (eCUsuario.CodigoUsuario.Trim() != "")
        {
            if (eCUsuario.RolUsuario.ToString().Trim() == cmbRol.SelectedValue.ToString().Trim())
            {
                Session["Codigo"] = eCUsuario.CodigoUsuario.ToUpper();
                if (eCUsuario.RolUsuario == "AD")
                {
                    Session["Rol"] = "ADMINISTRATIVO";
                    Session["Sede"] = usuarioNetvalle.CargoUsuarioNetvalle.ToString().Trim();
                    Response.Redirect("/WebForm/Administrador/PMenuAdministrador.aspx");
                }
                if (eCUsuario.RolUsuario == "DO")
                {
                    Session["Rol"] = "DOCENTE";
                    Session["Sede"] = usuarioNetvalle.CargoUsuarioNetvalle.ToString().Trim();
                    Response.Redirect("/WebForm/Administrador/PMenuAdministrador.aspx");
                }
                if (eCUsuario.RolUsuario == "ES")
                {
                    Session["Rol"] = "ESTUDIANTE";
                    Session["Sede"] = usuarioNetvalle.CargoUsuarioNetvalle.ToString().Trim();
                    Response.Redirect("/WebForm/Usuario/PMenuEstudiante.aspx");
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('" + Convert.ToString(cmbRol.SelectedItem.Value) + "')", true);

            }

        }
        else
        {
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('VERIFIQUE LA INFORMACION INGRESADA')", true);
        }
    }
}