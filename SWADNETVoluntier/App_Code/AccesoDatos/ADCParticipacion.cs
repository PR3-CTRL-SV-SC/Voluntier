using Microsoft.Practices.EnterpriseLibrary.Data;
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
    public void Insertar_CCampania_I(ECParticipacion eCParticipacion)
    {
        try
        {
            Database BDSWADNETVoluntier = SBaseDatos.BDSWADNETVoluntier;
            DbCommand dbCommand = BDSWADNETVoluntier.GetStoredProcCommand("CCampania_I");
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idCampaniaParticipacion", DbType.DateTime, eCParticipacion.IdCampaniaParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "idUsuarioParticipacion", DbType.DateTime, eCParticipacion.IdUsuarioParticipacion);
            BDSWADNETVoluntier.AddInParameter(dbCommand, "horasParticipacion", DbType.String, eCParticipacion.HorasParticipacion);
            BDSWADNETVoluntier.ExecuteNonQuery(dbCommand);
        }

        catch (SqlException SQLEx)
        {
            EDefecto eDefectoAD = ConstruirErrorServicio(TTipoError.BaseDatos, "Insertar_CCampania_I", SQLEx.ToString(), SQLEx.Message);
            throw new FaultException<EDefecto>(eDefectoAD);
        }
    }

    #endregion


    public ADCParticipacion()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}