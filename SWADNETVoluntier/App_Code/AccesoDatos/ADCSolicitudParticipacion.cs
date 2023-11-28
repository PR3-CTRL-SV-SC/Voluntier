using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Summary description for ADCSolicitudParticipacion
/// </summary>
public class ADCSolicitudParticipacion
{
    #region Metodos privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>

    private EDefecto ConstruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefectoAD = new EDefecto();
        eDefectoAD.TipoError = tipoError;
        eDefectoAD.Servicio = "SWADNETVoluntier";
        eDefectoAD.Clase = "ADCParticipacion";
        eDefectoAD.Metodo = metodo;
        eDefectoAD.Excepcion = excepcion;
        eDefectoAD.Mensaje = mensaje;
        return eDefectoAD;
    }

    #endregion

    #region Metodos publicos

    /// <summary>
    /// Obtener solicitudes de participación por ID de campaña
    /// </summary>
    /// <param name="idCampania">ID de la campaña</param>
    /// <returns>Retorna una lista de solicitudes de participación</returns>
    public DTOCSolicitudParticipacion Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        DTOCSolicitudParticipacion dtoCSolicitud = new DTOCSolicitudParticipacion();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("Obtener_CSolicitudes_O_Campania");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampania", DbType.Int32, idCampania);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCSolicitud, "CSolicitudParticipacion");


        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CSolicitudes_O_Campania", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dtoCSolicitud;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="idUsuario"></param>
    /// <returns></returns>
    /// <exception cref="FaultException{EDefecto}"></exception>
    public DTOCSolicitudParticipacion Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        DTOCSolicitudParticipacion dtoCSolicitud = new DTOCSolicitudParticipacion();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("Obtener_CSolicitudes_O_Usuario");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuario", DbType.String, idUsuario);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCSolicitud, "CSolicitudParticipacion");
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CSolicitudes_O_Usuario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dtoCSolicitud;
    }

    /// <summary>
    /// Insertar una nueva solicitud de participación
    /// </summary>
    /// <param name="nuevaSolicitud">La nueva solicitud de participación</param>
    public void Insertar_CSolicitud_I(ECSolicitudParticipacion nuevaSolicitud)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CSolicitud_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuarioSolicitud", DbType.String, nuevaSolicitud.IdUsuarioSolicitud);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampaniaSolicitud", DbType.Int32, nuevaSolicitud.IdCampaniaSolicitud);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoSolicitud", DbType.String, nuevaSolicitud.EstadoSolicitud);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_CSolicitud_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar el estado de una solicitud de participación
    /// </summary>
    /// <param name="idSolicitud">ID de la solicitud</param>
    /// <param name="nuevoEstado">El nuevo estado de la solicitud</param>
    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CSolicidud_A_Estado");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idSolicitud", DbType.Int32, idSolicitud);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoSolicitud", DbType.String, nuevoEstado);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CSolicitud_A_Estado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }


    #endregion

}