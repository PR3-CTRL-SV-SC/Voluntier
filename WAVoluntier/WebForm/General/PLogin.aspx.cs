using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PLogin : System.Web.UI.Page
{
    //SWLNRecicladoClient swLNReciclado = new SWLNRecicladoClient();
    //ERUsuarioNetvalle eUsuarioNetvalle = new ERUsuarioNetvalle();

    SWLNVoluntierClient swLNVoluntier = new SWLNVoluntierClient();
    ECUsuario eCUsuario = new ECUsuario();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        Console.WriteLine("Hola");
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
                Response.Redirect("/WebForm/Administrador/PAgregarCampania.aspx");
            }
            if (eCUsuario.RolUsuario == "ES")
            {
                Session["Rol"] = "ESTUDIANTE";
                Console.WriteLine("Estudiante");
            }
        }
        else
        {

        }
    }
}