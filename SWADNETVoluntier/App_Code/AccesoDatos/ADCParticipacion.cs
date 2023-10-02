﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for ADCParticipacion
/// </summary>
public class ADCParticipacion
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
    /// Obtener todas las campañas
    /// </summary>
    /// <returns>Retorna una lista de campañas</returns>
    public DTOCParticipacion Obtener_CParticipacion_O()
    {
        DTOCParticipacion dTOCParticipacion = new DTOCParticipacion();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CParticipacion_O");

            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTOCParticipacion, "CParticipacion");
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CParticipacion_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTOCParticipacion;
    }

    /// <summary>
    /// Metodo para insertar una Campaña
    /// </summary>
    /// <param name="eCParticipacion"></param>
    public void Insertar_CParicipacion_I(ECParticipacion eCParticipacion)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampaniaParticipacion", DbType.DateTime, eCParticipacion.IdCampaniaParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuarioParticipacion", DbType.DateTime, eCParticipacion.IdUsuarioParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaRegistroParticipacion", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionParticipacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoParticipacion", DbType.String, eCParticipacion.EstadoParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "horasParticipacion", DbType.String, eCParticipacion.HorasParticipacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_CParicipacion_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar una Participación
    /// </summary>
    /// <param name="eCParticipacion"></param>
    public void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CParticipacion_A");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampaniaParticipacion", DbType.Int32, eCParticipacion.IdCampaniaParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuarioParticipacion", DbType.Int32, eCParticipacion.IdUsuarioParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionParticipacion", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoParticipacion", DbType.String, eCParticipacion.EstadoParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "horasParticipacion", DbType.Int32, eCParticipacion.HorasParticipacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CParticipacion_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Obtener participaciones por usuario
    /// </summary>
    /// <param name="idUsuario">ID del usuario</param>
    /// <returns>Retorna una lista de participaciones del usuario</returns>
    public DTOCParticipacion Obtener_CParticipacion_PorUsuario(int idUsuario)
    {
        DTOCParticipacion dTOCParticipacion = new DTOCParticipacion();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CParticipacion_PorUsuario");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuario", DbType.Int32, idUsuario);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTOCParticipacion, "CParticipacion");
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CParticipacion_PorUsuario", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTOCParticipacion;
    }

    #endregion


}