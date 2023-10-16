using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SWLNVoluntier;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.ServiceModel;

/// <summary>
/// Summary description for CCampania
/// </summary>
public class CCampania : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ECUsuario> eUsuarios = new List<ECUsuario>();
    ECCampania ECCampania = new ECCampania();
    
    public CCampania()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos
    #region LNServicio

   
    public ECCampania Obtener_CCampania_O_IdCampania_CC(int idCampania)
    {
        ECCampania ecCampania = new ECCampania();
        try
        {
            ecCampania = lnServicio.Obtener_CCampania_O_IdCampania(idCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return ecCampania;
    }
    public List<ECCampania> Obtener_CCampania_O_Sede_CC(string sedeCampania)
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = lnServicio.Obtener_CCampania_O_Sede(sedeCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcCampania;
    }
    public List<ECCampania> Obtener_CCampania_O_CC()
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = lnServicio.Obtener_CCampania_O().ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcCampania;
    }

    #endregion

    #region Registro
    public void Editar_Campania(ECCampania eCCampania)
    {
        try
        {
            eCCampania.SedeCampania = Session["Sede"].ToString();
            //lnServicio.Actualizar_CCampania_A(Session["EditarCampania"].ToString(), descripcionCampania, DateTime.Parse(fechaInicioCampania.Trim()), DateTime.Parse(fechaFinCampania.Trim()), Session["Sede"].ToString());
            lnServicio.Actualizar_CCampania_A(eCCampania);
            //Context.Response.Redirect("../../WebForm/Administrador/PGestionCampanias.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_Campania(int CampaniaEliminar)
    {
        try
        {
            lnServicio.Actualizar_CCampania_A_Estado_Cancelado(CampaniaEliminar);
            Context.Response.Redirect("../../WebForm/Administrador/PCampaniasAdmin.aspx");
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    #endregion

    #endregion
}