using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.IdentityModel.Metadata;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PGestionCampanias : System.Web.UI.Page
{
    private int Id_Campania = 0;
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> eCCampanias;

    protected void Page_Load(object sender, EventArgs e)
    {
        eCCampanias = new List<ECCampania>();
        if (!IsPostBack)
        {
            try
            {
                if (Session["Rol"].ToString() == "ADMINISTRATIVO")
                {
                    btnCampaniasPropuestas.Visible = true;
                }
                else
                {
                    btnCampaniasPropuestas.Visible = false;
                }
                eCCampanias = sWLNVoluntierClient.Obtener_CCampania_O().ToList();
                var campañasActivas = eCCampanias.Where(c => c.EstadoCampania == SDatosGlobales.APROBADO || c.EstadoCampania == SDatosGlobales.EN_CURSO || c.EstadoCampania == SDatosGlobales.FINALIZADO).ToList();

                if (campañasActivas.Count < 1)
                {
                    lblNotificacion.Text = "NO EXISTEN CAMPAÑAS ACTIVAS O EN CURSO";
                }
                else
                {
                    gvListaCampanias.DataSource = campañasActivas;
                    gvListaCampanias.DataBind();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

    protected void btnCrearCampania_Click(object sender, EventArgs e)
    {
        Response.Redirect("PAgregarCampania.aspx");
    }

    protected void gvListaCampanias_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "btnVer")
        {
            string argument = e.CommandArgument.ToString();
            string[] arguments = argument.Split('|');

            if (arguments.Length == 2)
            {
                int idCampania = Convert.ToInt32(arguments[0]);
                string estado = arguments[1];
                Session["codCampania"] = idCampania;

                if(estado == SDatosGlobales.APROBADO)
                {
                    Response.Redirect("PCampaniasAdmin.aspx");
                }
                else if (estado == SDatosGlobales.EN_CURSO || estado == SDatosGlobales.FINALIZADO)
                {
                    Response.Redirect("PCampaniaProgresoAdmin.aspx");
                }
            }
            
        }
        if (e.CommandName == "btnActualizar")
        {
            Id_Campania = Convert.ToInt32(e.CommandArgument);
            Session["EditarCampania"] = Id_Campania;
            Response.Redirect("PEditarCampania.aspx");
        }
        if (e.CommandName == "btnEliminar")
        {
            string argument = e.CommandArgument.ToString();
            string[] arguments = argument.Split('|');

            if (arguments.Length == 2)
            {
                int idCampania = Convert.ToInt32(arguments[0]);
                int rowIndex = Convert.ToInt32(arguments[1]);
                lblCampaniaEliminar.Text = gvListaCampanias.Rows[rowIndex].Cells[1].Text;
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
            }
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        sWLNVoluntierClient.Actualizar_CCampania_A_Estado_Cancelado(Id_Campania);
        Response.Redirect("PGestionCampanias.aspx");
    }
    
    protected void btCerrar_Click(object sender, ImageClickEventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }

    protected void btnCampaniasPropuestas_Click(object sender, EventArgs e)
    {
        Response.Redirect("PCampaniasPropuestas.aspx");
    }
}