using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERVoto
/// </summary>
[DataContract]
public class ERVoto
{
    #region Atributos
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CampaniaVoto { get; set; }
    [DataMember]
    public string OrganizacionVoto { get; set; }
    [DataMember]
    public DateTime FechaRegistroVoto { get; set; }
    [DataMember]
    public string DonacionVoto { get; set; }
    [DataMember]
    public string EstadoVoto { get; set; }
    [DataMember]
    public DateTime FechaModificacionVoto { get; set; }
    [DataMember]
    public int IdVoto { get; set; }
    #endregion
    public ERVoto()
    {
        CodigoUsuario = string.Empty;
        CampaniaVoto = string.Empty;
        OrganizacionVoto = string.Empty;
        FechaRegistroVoto = DateTime.MinValue;
        DonacionVoto = string.Empty;
        EstadoVoto = string.Empty;
        FechaModificacionVoto = DateTime.MinValue;
        IdVoto = 0;
    }
}