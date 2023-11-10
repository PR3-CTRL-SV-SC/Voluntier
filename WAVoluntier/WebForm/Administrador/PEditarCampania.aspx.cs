using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PEditarCampania : System.Web.UI.Page
{
    SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient();
    List<ECCampania> lstCampanias;
    ECCampania eCCampania;

    #region Metodos Privados
    public void CleanPage()
    {
        lblExep.Text = "";
        txbNombreCampania.Text = "";
        txbDescripcion.Text = "";
        txbFechaFin.Text = "";
        txbFechaInicio.Text = "";
        lblDatosNombreCampania.Text = "";
        lblDatosDescripcionCampania.Text = "";
        lblFechaInicio.Text = "";
        lblFechaCierre.Text = "";
    }

    private void CargarDatos()
    {
        int Id = Convert.ToInt32(Session["EditarCampania"].ToString());
        try
        {
            eCCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(Id);

            string mesInicio = eCCampania.FechaInicioCampania.Month.ToString();
            string diaInicio = eCCampania.FechaInicioCampania.Day.ToString();
            string anioInicio = eCCampania.FechaInicioCampania.Year.ToString();

            string mesFin = eCCampania.FechaFinCampania.Month.ToString();
            string diaFin = eCCampania.FechaFinCampania.Day.ToString();
            string anioFin = eCCampania.FechaFinCampania.Year.ToString();

            string fechaInicio = anioInicio + "-" + SUtil.ConvertirFechas(mesInicio) + "-" + SUtil.ConvertirFechas(diaInicio);
            string fechaCierre = anioFin + "-" + SUtil.ConvertirFechas(mesFin) + "-" + SUtil.ConvertirFechas(diaFin);

            txbNombreCampania.Text = eCCampania.NombreCampania;
            txbDescripcion.Text = eCCampania.DescripcionCampania;
            txbFechaInicio.Text = fechaInicio;
            txbFechaFin.Text = fechaCierre;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if(txbNombreCampania.Text == "" || txbDescripcion.Text == "")
        {
            CargarDatos();
        }
        lstCampanias = sWLNVoluntierClient.Obtener_CCampania_O().ToList();
    }

    protected void btnGuardarCampania_Click(object sender, EventArgs e)
    {
        int Id = Convert.ToInt32(Session["EditarCampania"].ToString());
        if (SUtil.ValidacionesTextBox(txbNombreCampania.Text) && SUtil.ValidacionesTextBox(txbDescripcion.Text))
        {
            var lstNombre = lstCampanias.Where(c => c.NombreCampania.ToUpper() == txbNombreCampania.Text.ToUpper() && c.IdCampania != Id).ToList();
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
                            lblDatosNombreCampania.Text = txbNombreCampania.Text;
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
        ECCampania eCCampania = new ECCampania();

        eCCampania.IdCampania = Convert.ToInt32(Session["EditarCampania"].ToString());
        eCCampania.NombreCampania = txbNombreCampania.Text;
        eCCampania.DescripcionCampania = txbDescripcion.Text;
        eCCampania.FechaInicioCampania = DateTime.Parse(txbFechaInicio.Text);
        eCCampania.FechaFinCampania = DateTime.Parse(txbFechaFin.Text);
        eCCampania.EstadoCampania = SDatosGlobales.PENDIENTE;
        eCCampania.SedeCampania = "C";
        eCCampania.FechaModificacionCampania = EPAEstaticos.FechaModificacion;
        sWLNVoluntierClient.Actualizar_CCampania_A(eCCampania);
        CleanPage();
        Response.Redirect("PGestionCampanias.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "Cerrar()", true);
    }
}