using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Summary description for ADVCampania
/// </summary>
public class ADVCampania
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
        eDefectoAD.Clase = "ADVCampania";
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
    public DTOCampania Obtener_RCampania_O()
    {
        DTOCampania dTORCampania = new DTOCampania();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_O");

            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTORCampania;
    }


    /// <summary>
    /// Metodo para insertar una Campaña
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Insertar_RCampania_I(ERCampania eRCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, eRCampania.NombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "descripcionCampania", DbType.String, eRCampania.DescripcionCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaInicioCampania", DbType.DateTime, eRCampania.FechaInicioCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaFinCampania", DbType.DateTime, eRCampania.FechaFinCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, eRCampania.SedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaRegistroCampania", DbType.String, EPAEstaticos.FechaRegistro);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_RCampania_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar una Campaña
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Actualizar_RCampania_A(ERCampania eRCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_A");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, eRCampania.NombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "descripcionCampania", DbType.String, eRCampania.DescripcionCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaInicioCampania", DbType.DateTime, eRCampania.FechaInicioCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaFinCampania", DbType.DateTime, eRCampania.FechaFinCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, eRCampania.SedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualiza el estado de una campaña a 'FINALIAZADA'
    /// </summary>
    /// <param name="eRCampania"></param>
    public void Actualizar_RCampania_A_Estado(string nombreCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_A_Estado");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, nombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampaniaF", DbType.String, EPAEstaticos.EstadoFinalizada);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A_Estado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar el estado de una campaña a cancelado
    /// </summary>
    /// <param name="nombreCampania"></param>
    public void Actualizar_RCampania_A_Estado_Cancelado(string nombreCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_A_Estado_Cancelado");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, nombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoCancelada);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_RCampania_A_Estado_Cancelado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);

        }


    }


    /// <summary>
    /// Obtener campaña activa por sede
    /// </summary>
    /// <param name="sedeCampania"></param>
    /// <returns>Retorna una campania</returns>
    public DTOCampania Obtener_RCampania_O_Sede(string sedeCampania)
    {
        DTOCampania dTORCampania = new DTOCampania();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("RCampania_O_Sede");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, sedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTORCampania, "RCampania");
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_RCampania_O_Sede", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTORCampania;
    }

    #endregion

}