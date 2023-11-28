using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de SBaseDatos
/// </summary>
[DataContract]
public class SBaseDatos
{
    [DataMember]
    public static Database BDSWADNETVoluntier = DatabaseFactory.CreateDatabase("BDVoluntierConnectionString");
}