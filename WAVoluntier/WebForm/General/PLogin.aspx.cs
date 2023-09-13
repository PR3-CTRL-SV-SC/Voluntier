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
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnIniciar_Click(object sender, ImageClickEventArgs e)
    {
        Console.WriteLine("Hola");
        //if (txbCuenta.Text.Trim() != "" && txbPIN.Text.Trim() != "")
        //{
        //    eUsuarioNetvalle = new ERUsuarioNetvalle();
        //    eUsuarioNetvalle = swLNReciclado.Obtener_RUsuarioNetvalle_O_Codigo_Pass_Rol(txbCuenta.Text.Trim().ToUpper(), txbPIN.Text, ddlSelectUser.SelectedValue);
        //    if (eUsuarioNetvalle.CodigoUsuarioNetvalle.Trim() != "")
        //    {
        //        Session["Codigo"] = eUsuarioNetvalle.CodigoUsuarioNetvalle.ToUpper();
        //        Session["Sede"] = eUsuarioNetvalle.SedeUsuarioNetvalle.ToUpper();
        //        if (ddlSelectUser.SelectedValue == "AD")
        //        {
        //            Session["Rol"] = "ADMINISTRATIVO";
        //            Response.Redirect("/WebForm/Administrador/PMenuAdministrador.aspx");
        //        }
        //        if (ddlSelectUser.SelectedValue == "EU")
        //        {
        //            Session["Rol"] = "ESTUDIANTE";
        //            Response.Redirect("/WebForm/Usuario/PMenuEstudiante.aspx");
        //        }
        //    }
        //}
    }
}