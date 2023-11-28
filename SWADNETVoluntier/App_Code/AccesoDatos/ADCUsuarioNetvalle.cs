using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.ServiceModel;

/// <summary>
/// Summary description for ADCUsuarioNetvalle
/// </summary>
public class ADCUsuarioNetvalle
{
    #region Metodos Privados
    /// <summary>
    /// Contruir el Error del servicio > metodo
    /// </summary>
    /// <param name="tipoError"></param>
    /// <param name="metodo"></param>
    /// <param name="excepcion"></param>
    /// <param name="mensaje"></param>
    /// <returns></returns>
    private EDefecto ContruirErrorServicio(TTipoError tipoError, string metodo, string excepcion, string mensaje)
    {
        EDefecto EDefecto = new EDefecto();
        EDefecto.TipoError = tipoError;
        EDefecto.Servicio = "SWADNETVoluntier";
        EDefecto.Clase = "ADCUsuarioNetvalle";
        EDefecto.Metodo = metodo;
        EDefecto.Excepcion = excepcion;
        EDefecto.Mensaje = mensaje;
        return EDefecto;
    }
    #endregion 

    #region Metodos publicos
    /// <summary>
    /// Obtener un usuarionetvalle mediante sede y codigo
    /// </summary>
    /// <param name="Sede"></param>
    /// <param name="Codigo"></param>
    /// <returns>Retorna nombres y apellidos de un usuarionetvalle por sede y codigo</returns>
    public DTOCUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = new DTOCUsuarioNetvalle();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarioNetvalle_O_Top_Sede_Codigo");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeUsuarioNetvalle", DbType.String, sedeUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "codigoUsuarioNetvalle", DbType.String, codigoUsuarioNetvalle);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuarioNetvalle, "CUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuarioNetvalle;
    }

    /// <summary>
    ///  Obtener un usuarionetvalle por codigo
    /// </summary>
    /// <param name="Codigo"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTOCUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = new DTOCUsuarioNetvalle();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarioNetvalle_O_Codigo");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "codigoUsuarioNetvalle", DbType.String, codigoUsuarioNetvalle);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuarioNetvalle, "CUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuarioNetvalle_O_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuarioNetvalle;
    }

    /// <summary>
    /// Obtener un usuarionetvalle por tarjeta
    /// </summary>
    /// <param name="Tarjeta"></param>
    /// <returns>Retorna un usuarionetvalle</returns>
    public DTOCUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = new DTOCUsuarioNetvalle();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarioNetvalle_O_Tarjeta");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "tarjetaUsuarioNetvalle", DbType.String, tarjetaUsuarioNetvalle);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuarioNetvalle, "CUsuarioNetvalle");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuarioNetvalle_O_Tarjeta", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuarioNetvalle;
    }
    #endregion

    #region Insertar_CUsuarioNetvalle_y_CUsuario
    public void Insertar_CUsuarioNetvalle_y_CUsuario(
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string sedeUsuarioNetvalle)
    {
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = new DTOCUsuarioNetvalle();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarioNetvalle_CUsuaro_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "codigoUsuarioNetvalle", DbType.String, codigoUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "nombresUsuarioNetvalle", DbType.String, nombresUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "apellidosUsuarioNetvalle", DbType.String, apellidosUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "cargoUsuarioNetvalle", DbType.String, cargoUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeUsuarioNetvalle", DbType.String, sedeUsuarioNetvalle);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaModificacionUsuarioNetvalle", DbType.DateTime, EPAEstaticos.FechaModificacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "fechaRegistroUsuarioNetvalle", DbType.DateTime, EPAEstaticos.FechaRegistro);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "estadoUsuarioNetvalle", DbType.String, EPAEstaticos.EstadoActiva);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "horasUsuario", DbType.String, EPAEstaticos.HorasUsuario);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuarioNetvalle, "CUsuarioNetvalle");
        }

        //catch (SqlException SQLEx)
        //{
        //    EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Insertar_CUsuarioNetvalle_y_CUsuario", SQLEx.ToString(), SQLEx.Message);
        //    throw new FaultException<EDefecto>(EDefecto);
        //}
        catch (Exception ex)
        {
            throw ex;
        }

    }

    #endregion
}