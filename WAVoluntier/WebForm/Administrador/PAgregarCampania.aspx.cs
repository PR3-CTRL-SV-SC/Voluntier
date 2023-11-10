using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SWLNVoluntier;

public partial class PAgregarCampania : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> lstCampanias;
    ECCampania eCCampania;

    #region Metodos Privados
    public void CleanPage()
    {
        lblExep.Text = "";
        txbNombreCmpania.Text = "";
        txbDescripcion.Text = "";
        txbFechaFin.Text = "";
        txbFechaInicio.Text = "";
        lblDatosNombreCampania.Text = "";
        lblDatosDescripcionCampania.Text = "";
        lblFechaInicio.Text = "";
        lblFechaCierre.Text = "";
    }
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        lstCampanias = sWLNVoluntierClient.Obtener_CCampania_O().ToList();
    }

    protected void btnGuardarCampania_Click(object sender, EventArgs e)
    {
        if(SUtil.ValidacionesTextBox(txbNombreCmpania.Text) && SUtil.ValidacionesTextBox(txbDescripcion.Text))
        {
            var lstNombre = lstCampanias.Where(c => c.NombreCampania.ToUpper() == txbNombreCmpania.Text.ToUpper()).ToList();
            if (lstNombre.Count > 0)
            {
                lblExep.Text = "Ya existe una campaña con ese nombre";
            }
            else
            {
                string fechaInicio = txbFechaInicio.Text;
                string fechaFinal = txbFechaFin.Text;
                if (fechaInicio == "" || fechaFinal == "")
                {
                    lblExep.Text = "Los campos de fechas no pueden estar vacios";
                }
                else
                {
                    if (DateTime.Parse(fechaInicio) <= DateTime.Today || DateTime.Parse(fechaFinal) <= DateTime.Today)
                    {
                        lblExep.Text = "Las fechas tienen que ser posteriores al a fecha actual";
                    }
                    else
                    {
                        if (DateTime.Parse(txbFechaInicio.Text) < DateTime.Parse(txbFechaFin.Text))
                        {
                            lblDatosNombreCampania.Text = txbNombreCmpania.Text;
                            lblDatosDescripcionCampania.Text = txbDescripcion.Text;
                            lblFechaInicio.Text = txbFechaInicio.Text;
                            lblFechaCierre.Text = txbFechaFin.Text;
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Abrir()", true);
                            lblExep.Text = "";
                        }
                        else
                        {
                            lblExep.Text = "La fecha final tiene que ser posterior a la fecha inicial";
                        }
                    }
                }
            }
        }
        else
        {
            lblExep.Text = "Error en los campos de nombre y descripcion";
        }
    }

    protected void btnConfirmar_Click(object sender, EventArgs e)
    {
        eCCampania = new ECCampania();
        
        eCCampania.NombreCampania = txbNombreCmpania.Text;
        eCCampania.DescripcionCampania = txbDescripcion.Text;
        eCCampania.FechaInicioCampania = DateTime.Parse(txbFechaInicio.Text);
        eCCampania.FechaFinCampania = DateTime.Parse(txbFechaFin.Text);
        if (Session["Rol"].ToString() == "ADMINISTRATIVO")
        {
            //eCCampania.EstadoCampania = SDatosGlobales.APROBADO;
            eCCampania.EstadoCampania = SDatosGlobales.PENDIENTE;
        }
        else
        {
            eCCampania.EstadoCampania = SDatosGlobales.PENDIENTE;
        }
        eCCampania.SedeCampania = "C";
        eCCampania.FechaRegistroCampania = EPAEstaticos.FechaRegistro;
        eCCampania.FechaModificacionCampania = EPAEstaticos.FechaModificacion;
        eCCampania.IdUsuarioCreador = Session["Codigo"].ToString();
        sWLNVoluntierClient.Insertar_CCampania_I(eCCampania);
        
        CleanPage();
        
        Response.Redirect("PGestionCampanias.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }
}