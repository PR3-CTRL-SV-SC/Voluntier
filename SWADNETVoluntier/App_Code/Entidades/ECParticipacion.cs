using System;
using System.Runtime.Serialization;

/// <summary>
/// Summary description for ECParticipacion
/// </summary>
[DataContract]
public class ECParticipacion
{
    #region Atributos
    [DataMember]
    public int IdParticipacion { get; set; }
    [DataMember]
    public int IdCampaniaParticipacion { get; set; }
    [DataMember]
    public string IdUsuarioParticipacion { get; set; }
    [DataMember]
    public DateTime FechaRegistroParticipacion { get; set; }
    [DataMember]
    public DateTime FechaModificacionParticipacion { get; set; }
    [DataMember]
    public string EstadoParticipacion { get; set; }
    [DataMember]
    public string HorasParticipacion { get; set; }

    #endregion
    public ECParticipacion()
    {
        IdParticipacion = 0;
        IdCampaniaParticipacion = 0;
        IdUsuarioParticipacion = string.Empty;
        FechaRegistroParticipacion = DateTime.MinValue;
        FechaModificacionParticipacion = DateTime.MinValue;
        EstadoParticipacion = string.Empty;
        HorasParticipacion = string.Empty;
    }
}