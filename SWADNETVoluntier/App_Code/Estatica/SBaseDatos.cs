using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
[DataContract]
public class SBaseDatos
{
    [DataMember]
    public static Database BDSWADNETReciclado = DatabaseFactory.CreateDatabase("BDVoluntierConnectionString");
}