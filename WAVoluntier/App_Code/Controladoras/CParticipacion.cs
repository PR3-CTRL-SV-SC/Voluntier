using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for CParticipacion
/// </summary>
public class CParticipacion : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ECUsuario> eUsuarios = new List<ECUsuario>();
    ECParticipacion ECParticipacion = new ECParticipacion();


    public CParticipacion()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos
    #region LNServicio

    public List<ECParticipacion> Obtener_CParticipacion_O_IdCampania_CC(int idCampania)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = lnServicio.Obtener_CParticipacion_O_PorCampania(idCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_IdUsuario_CC(string idUsuario)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = lnServicio.Obtener_CParticipacion_O_PorUsuario(idUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcParticipacion;
    }


    #endregion

    public void Editar_Participacion(ECParticipacion eCParticipacion)
    {
        try
        {
            lnServicio.Actualizar_CParticipacion_A(eCParticipacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }


    #endregion
}