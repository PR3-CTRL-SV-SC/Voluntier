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
/// Summary description for ADCCampania
/// </summary>
public class ADCCampania
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
        eDefectoAD.Clase = "ADCCampania";
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
    public DTOCCampania Obtener_CCampania_O()
    {
        DTOCCampania dTOCCampania = new DTOCCampania();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_O");

            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTOCCampania, "CCampania");
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CCampania_O", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTOCCampania;
    }


    /// <summary>
    /// Metodo para insertar una Campaña
    /// </summary>
    /// <param name="eCCampania"></param>
    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, eCCampania.NombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "descripcionCampania", DbType.String, eCCampania.DescripcionCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaInicioCampania", DbType.DateTime, eCCampania.FechaInicioCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaFinCampania", DbType.DateTime, eCCampania.FechaFinCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, eCCampania.SedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaRegistroCampania", DbType.String, EPAEstaticos.FechaRegistro);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_CCampania_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar una Campaña
    /// </summary>
    /// <param name="eCCampania"></param>
    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_A");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampania", DbType.Int32, eCCampania.IdCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombreCampania", DbType.String, eCCampania.NombreCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "descripcionCampania", DbType.String, eCCampania.DescripcionCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaInicioCampania", DbType.DateTime, eCCampania.FechaInicioCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaFinCampania", DbType.DateTime, eCCampania.FechaFinCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, eCCampania.SedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CCampania_A", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualiza el estado de una campaña a 'FINALIAZADA'
    /// </summary>
    /// <param name="eCCampania"></param>
    public void Actualizar_CCampania_A_Estado(string idCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_A_Estado");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampania", DbType.String, idCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampaniaF", DbType.String, EPAEstaticos.EstadoFinalizada);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CCampania_A_Estado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    /// <summary>
    /// Actualizar el estado de una campaña a cancelado
    /// </summary>
    /// <param name="nombreCampania"></param>
    public void Actualizar_CCampania_A_Estado_Cancelado(string idCampania)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_A_Estado_Cancelado");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampania", DbType.String, idCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoCancelada);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionCampania", DbType.String, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CCampania_A_Estado_Cancelado", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);

        }


    }


    /// <summary>
    /// Obtener campaña activa por sede
    /// </summary>
    /// <param name="sedeCampania"></param>
    /// <returns>Retorna una campania</returns>
    public DTOCCampania Obtener_CCampania_O_Sede(string sedeCampania)
    {
        DTOCCampania dTOCCampania = new DTOCCampania();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_O_Sede");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeCampania", DbType.String, sedeCampania);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoCampania", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dTOCCampania, "CCampania");
        }
        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Obtener_CCampania_O_Sede", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
        return dTOCCampania;
    }

    #endregion

}