using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Summary description for ADCUsuario
/// </summary>
public class ADCUsuario
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
        EDefecto.Servicio = "SWADNETReciclado";
        EDefecto.Clase = "ADCUsuario";
        EDefecto.Metodo = metodo;
        EDefecto.Excepcion = excepcion;
        EDefecto.Mensaje = mensaje;
        return EDefecto;
    }
    #endregion 
    #region Metodos publicos
    /// <summary>
    /// Obtener un usuario por codigo
    /// </summary>
    /// <param name="codigoUsuario"></param>
    /// <returns>Retorna un usuario</returns>
    public DTOCUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario)
    {
        DTOCUsuario dtoCUsuario = new DTOCUsuario();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuario_O_Codigo");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "codigoUsuario", DbType.String, codigoUsuario);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuario, "CUsuario");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuario_O_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuario;
    }
    /// <summary>
    /// Obtener el top de usuarios en créditos
    /// </summary>
    /// <param name="Sede"></param>
    /// <returns>Retorna una lista de usuarios ordenados por créditos</returns>
    public DTOCUsuario Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        DTOCUsuario dtoCUsuario = new DTOCUsuario();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarios_O_Top_Horas");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeUsuarioNetvalle", DbType.String, sedeUsuarioNetvalle);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuario, "CUsuario");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuarios_O_Top_Horas", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuario;
    }

    /// <summary>
    /// Obtener a todos los usuarios
    /// </summary>
    /// <param name="Sede"></param>
    /// <returns>Retorna la lista del codigo de los usuarios con sus créditos</returns>
    public DTOCUsuario Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        DTOCUsuario dtoCUsuario = new DTOCUsuario();
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuarios_O_Sede");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "sedeUsuarioNetvalle", DbType.String, sedeUsuarioNetvalle);
            BDSWADNETVoluntier.LoadDataSet(dbCommand, dtoCUsuario, "CUsuario");
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Obtener_CUsuarios_O_Sede", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
        return dtoCUsuario;
    }

    /// <summary>
    /// Actualizar los créditos del usuario a la nueva cantidad enviada
    /// </summary>
    /// <param name="Codigo"></param>
    /// <param name="Horas"></param>
    public void Actualizar_CUsuario_A_Horas_Codigo(string Codigo, int Horas)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CUsuario_A_Horas_Codigo");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "codigoUsuario", DbType.String, Codigo);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "horasUsuario", DbType.Int32, Horas);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto EDefecto = ContruirErrorServicio(TTipoError.BaseDatos, "Actualizar_CUsuario_A_Horas_Codigo", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(EDefecto);
        }
    }
    #endregion
}