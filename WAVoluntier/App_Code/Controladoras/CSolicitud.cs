using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for CSolicitud
/// </summary>
public class CSolicitud : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    List<ECUsuario> eUsuarios = new List<ECUsuario>();
    ECSolicitudParticipacion ECSolicitudParticipacion = new ECSolicitudParticipacion();
    public CSolicitud()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos
    #region LNServicio
    public List<ECSolicitudParticipacion> Obtener_CSolicitud_O_IdCampania_CC(int idCampania)
    {
        List<ECSolicitudParticipacion> lstEcSolicitud = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitud = lnServicio.Obtener_CSolicitudes_O_Campania(idCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcSolicitud;
    }
    public List<ECSolicitudParticipacion> Obtener_CSolicitud_O_IdUsuario_CC(string idUsuario)
    {
        List<ECSolicitudParticipacion> lstEcSolicitud = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitud = lnServicio.Obtener_CSolicitudes_O_Usuario(idUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return lstEcSolicitud;
    }
    #endregion
    public void Editar_Solicitud(ECSolicitudParticipacion eCSolicitud)
    {
        try
        {
            lnServicio.Actualizar_CSolicitud_A_Estado(eCSolicitud);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }
    public void Eliminar_Solicitud(int idSolicitud)
    {
        try
        {
            lnServicio.Eliminar_Solicitud(idSolicitud);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }


        #endregion
}