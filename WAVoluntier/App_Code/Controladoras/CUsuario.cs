using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using SWLNReciclado;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.ServiceModel;

/// <summary>
/// Summary description for CCampania
/// </summary>
public class CUsuario : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    ERVoto rVoto = new ERVoto();
    public CUsuario()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio

    public void Insertar_RVoto_I_CU(string codigoUsuario, string nombreCampania, string nombreOrganizacion, DateTime fechaRegistroVoto, string donacionVoto, string estadoVoto)
    {
        try
        {
           lnServicio.Insertar_RVoto_I(codigoUsuario, nombreCampania, nombreOrganizacion, fechaRegistroVoto,donacionVoto, estadoVoto);
        }
        catch (FaultException<EDefecto> ex)
        {

            throw ex;
        }
    }
    public ERVoto Obtener_RVoto_O_Codigo_Campania_CU(string codigoUsuario, string nombreCampania)
    {
        try
        {
            rVoto = lnServicio.Obtener_RVoto_O_Codigo_Campania(codigoUsuario, nombreCampania);
        }
        catch (FaultException<EDefecto> ex)
        {

            throw ex;
        }
        
        return rVoto;
    }
    public ERUsuario Obtener_RUsuario_O_Codigo_CU(string Codigo)
    {
        ERUsuario erUsuario = new ERUsuario();
        try
        {
            erUsuario = lnServicio.Obtener_RUsuario_O_Codigo(Codigo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erUsuario;

    }
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede_CU(string Sede)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        try
        {
            lstEUsuarioCompleja = lnServicio.Obtener_EUsuarioCompleja_O_Sede(Sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEUsuarioCompleja;
    }
    #endregion

    #endregion
}