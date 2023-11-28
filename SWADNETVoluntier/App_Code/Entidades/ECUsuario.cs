using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ECUsuario
/// </summary>
[DataContract]
public class ECUsuario
{
    #region Atributos
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string RolUsuario { get; set; }
    [DataMember]
    public string HorasUsuario { get; set; }
    #endregion

    public ECUsuario()
    {
        CodigoUsuario = string.Empty;
        RolUsuario = string.Empty;
        HorasUsuario = string.Empty;
    }
}