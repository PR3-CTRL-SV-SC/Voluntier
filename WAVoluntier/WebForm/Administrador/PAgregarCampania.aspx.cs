using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PAgregarCampania : System.Web.UI.Page
{
    List<String> lstOrganizaciones;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnIniciar_Click(object sender, EventArgs e)
    {
        //lstOrganizaciones = new List<String>();
        //lstOrganizaciones.Add(txtOrganizacion.Text);
        //GridViewListaOrganizaciones.DataSource = lstOrganizaciones;
        //GridViewListaOrganizaciones.DataBind();
    }

    protected void GridViewListaOrganizaciones_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //if (e.CommandName == "btnEliminar")
        //{
        //    lstOrganizaciones = new List<String>();
        //    for (int i = 0; i < GridViewListaOrganizaciones.Rows.Count; i++)
        //    {
        //        string valor = GridViewListaOrganizaciones.Rows[i].Cells[0].Text;
        //    }
        //    int index = Convert.ToInt32(e.CommandArgument.ToString());
        //    lstOrganizaciones.RemoveAt(index);
        //    GridViewListaOrganizaciones.DataSource = null;
        //    GridViewListaOrganizaciones.DataSource = lstOrganizaciones;
        //    GridViewListaOrganizaciones.DataBind();
        //}
    }
}