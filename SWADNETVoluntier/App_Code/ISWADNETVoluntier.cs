using System.Collections.Generic;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ISWADNETVoluntier
{
    #region Tabla : CCampania
    [OperationContract]
    List<ECCampania> Obtener_CCampania_O_Sede(string sedeCampania);
    [OperationContract]
    List<ECCampania> Obtener_CCampania_O();
    [OperationContract]
    ECCampania Obtener_CCampania_O_IdCampania(int IdCampania);
    [OperationContract]
    void Insertar_CCampania_I(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A_Estado(int idCampania, string estadoCampania);
    [OperationContract]
    void Actualizar_CCampania_A_Estado_Cancelado(int idCampania);
    #endregion
    #region Tabla: CParticipacion
    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O();

    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario);

    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania);

    [OperationContract]
    void Insertar_CParticipacion_I(ECParticipacion eCCParticipacion);

    [OperationContract]
    void Actualizar_CParticipacion_A(ECParticipacion eCCParticipacion);
    #endregion
    #region Tabla: CSolicitudParticipacion
    [OperationContract]
    List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania);
    [OperationContract]
    List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario);
    [OperationContract]
    void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion);
    [OperationContract]
    void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado);
    #endregion
    #region Tabla: CUsuario
    [OperationContract]
    ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle);
    [OperationContract]
    void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, string horasUsuario);
    #endregion

    #region Tabla : CUsuarioNetvalle
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle);
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle);
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle);
    [OperationContract]
    void Insertar_CUsuarioNetvalle_y_CUsuario(string codigoUsuarioNetvalle, string nombresUsuarioNetvalle, string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string sedeUsuarioNetvalle);
    #endregion



}

//// Use a data contract as illustrated in the sample below to add composite types to service operations.
//[DataContract]
//public class CompositeType
//{
//	bool boolValue = true;
//	string stringValue = "Hello ";

//	[DataMember]
//	public bool BoolValue
//	{
//		get { return boolValue; }
//		set { boolValue = value; }
//	}

//	[DataMember]
//	public string StringValue
//	{
//		get { return stringValue; }
//		set { stringValue = value; }
//	}
//}
