using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERUsuarioNetvalle
/// </summary>
[DataContract]
public class ERUsuarioNetvalle
{
    #region Atributos
    [DataMember]
    public string CodigoUsuarioNetvalle { get; set; }
    [DataMember]
    public string NombresUsuarioNetvalle { get; set; }
    [DataMember]
    public string ApellidosUsuarioNetvalle { get; set; }
    [DataMember]
    public string CargoUsuarioNetvalle { get; set; }
    [DataMember]
    public string TarjetaUsuarioNetvalle { get; set; }
    [DataMember]
    public string SedeUsuarioNetvalle { get; set; }
    [DataMember]
    public DateTime FechaRegistroUsuarioNetvalle { get; set; }
    [DataMember]
    public DateTime FechaModificacionUsuarioNetvalle { get; set; }
    [DataMember]
    public char EstadoUsuarioNetvalle { get; set; }
    #endregion
    public ERUsuarioNetvalle()
    {
        CodigoUsuarioNetvalle = string.Empty;
        NombresUsuarioNetvalle = string.Empty;
        ApellidosUsuarioNetvalle = string.Empty;
        CargoUsuarioNetvalle = string.Empty;
        TarjetaUsuarioNetvalle = string.Empty;
        SedeUsuarioNetvalle = string.Empty;
        FechaRegistroUsuarioNetvalle = DateTime.MinValue;
        FechaModificacionUsuarioNetvalle = DateTime.MinValue;
        EstadoUsuarioNetvalle = char.MinValue;
    }
}