using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ISWADNETVoluntier
{
    #region Tabla : CCampania
    [OperationContract]
    ECCampania Obtener_CCampania_O_Sede(string sedeCampania);
    [OperationContract]
    List<ECCampania> Obtener_CCampania_O();
    [OperationContract]
    void Insertar_CCampania_I(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A_Estado(string idCampania);
    [OperationContract]
    void Actualizar_CCampania_A_Estado_Cancelado(string idCampania);
    #endregion
    #region Tabla: CUsuario
    [OperationContract]
    ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle);
    [OperationContract]
    void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, int horasUsuario);
    #endregion
    #region Tabla : CUsuarioNetvalle
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle);
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle);
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle);
    [OperationContract]
    void Insertar_CUsuarioNetvalle_y_CUsuario(string roleUsuario, string codigoUsuarioNetvalle, string nombresUsuarioNetvalle, string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string tarjetaUsuarioNetvalle, string sedeUsuarioNetvalle);
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
