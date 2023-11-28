using System;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ECUsuarioNetvalle
/// </summary>
[DataContract]
public class ECUsuarioNetvalle
{
    #region Atributos
    [DataMember]
    public string CodigoUsuarioNetvalle { get; set; }
    [DataMember]
    public string NombreUsuarioNetvalle { get; set; }
    [DataMember]
    public string ApellidosUsuarioNetvalle { get; set; }
    [DataMember]
    public string CargoUsuarioNetvalle { get; set; }
    [DataMember]
    public string SedeUsuarioNetvalle { get; set; }
    [DataMember]
    public DateTime FechaRegistroUsuarioNetvalle { get; set; }
    [DataMember]
    public DateTime FechaModificacionUsuarioNetvalle { get; set; }
    [DataMember]
    public char EstadoUsuarioNetvalle { get; set; }
    #endregion
    public ECUsuarioNetvalle()
    {
        CodigoUsuarioNetvalle = string.Empty;
        NombreUsuarioNetvalle = string.Empty;
        ApellidosUsuarioNetvalle = string.Empty;
        CargoUsuarioNetvalle = string.Empty;
        SedeUsuarioNetvalle = string.Empty;
        FechaRegistroUsuarioNetvalle = DateTime.MinValue;
        FechaModificacionUsuarioNetvalle = DateTime.MinValue;
        EstadoUsuarioNetvalle = char.MinValue;
    }
}