using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCSolicitudParticipacion
/// </summary>
public class CCSolicitudParticipacion
{
    #region Metodos privados
    private ADCSolicitudParticipacion adCSolicitudParticipacion;
    #endregion
    #region Metodos publicos
    public CCSolicitudParticipacion()
    {
        adCSolicitudParticipacion = new ADCSolicitudParticipacion();
    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        DTOCSolicitudParticipacion dtoCSolicitudParticipacion = adCSolicitudParticipacion.Obtener_CSolicitudes_O_Campania(idCampania);
        List<ECSolicitudParticipacion> solicitudes = new List<ECSolicitudParticipacion>();

        foreach (DTOCSolicitudParticipacion.CSolicitudParticipacionRow drSolicitud in dtoCSolicitudParticipacion.CSolicitudParticipacion.Rows)
        {
            ECSolicitudParticipacion eCSolicitudParticipacion = new ECSolicitudParticipacion();
            eCSolicitudParticipacion.IdSolicitud = drSolicitud.IdSolicitud;
            eCSolicitudParticipacion.IdCampaniaSolicitud = drSolicitud.IdCampaniaSolicitud;
            eCSolicitudParticipacion.IdUsuarioSolicitud = drSolicitud.IdUsuarioSolicitud;
            eCSolicitudParticipacion.EstadoSolicitud = drSolicitud.EstadoSolicitud;
            solicitudes.Add(eCSolicitudParticipacion);
        }

        return solicitudes;
    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        DTOCSolicitudParticipacion dtoCSolicitudParticipacion = adCSolicitudParticipacion.Obtener_CSolicitudes_O_Usuario(idUsuario);
        List<ECSolicitudParticipacion> solicitudes = new List<ECSolicitudParticipacion>();

        foreach (DTOCSolicitudParticipacion.CSolicitudParticipacionRow drSolicitud in dtoCSolicitudParticipacion.CSolicitudParticipacion.Rows)
        {
            ECSolicitudParticipacion eCSolicitudParticipacion = new ECSolicitudParticipacion();
            eCSolicitudParticipacion.IdSolicitud = drSolicitud.IdSolicitud;
            eCSolicitudParticipacion.IdCampaniaSolicitud = drSolicitud.IdCampaniaSolicitud;
            eCSolicitudParticipacion.IdUsuarioSolicitud = drSolicitud.IdUsuarioSolicitud;
            eCSolicitudParticipacion.EstadoSolicitud = drSolicitud.EstadoSolicitud;
            solicitudes.Add(eCSolicitudParticipacion);
        }

        return solicitudes;
    }

    public void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion)
    {
        adCSolicitudParticipacion.Insertar_CSolicitud_I(eCSolicitudParticipacion);
    }

    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        adCSolicitudParticipacion.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
    }

    #endregion
}