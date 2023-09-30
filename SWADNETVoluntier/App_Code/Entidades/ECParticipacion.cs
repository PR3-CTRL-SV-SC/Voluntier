using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ECParticipacion
/// </summary>
public class ECParticipacion
{
    #region Atributos
    [DataMember]
    public int IdCampaniaParticipacion { get; set; }
    [DataMember]
    public int IdUsuarioParticipacion{ get; set; }
    [DataMember]
    public DateTime FechaRegistroParticipacion { get; set; }
    [DataMember]
    public DateTime FechaModificacionParticipacion { get; set; }
    [DataMember]
    public string EstadoParticipacion { get; set; }
    [DataMember]
    public int HorasParticipacion { get; set; }
    [DataMember]
    public int IdParticipacion { get; set; }
    #endregion
    public ECParticipacion()
    {
        IdCampaniaParticipacion = 0;
        IdUsuarioParticipacion = 0;
        FechaRegistroParticipacion = DateTime.MinValue;
        FechaModificacionParticipacion = DateTime.MinValue;
        EstadoParticipacion = string.Empty;
        HorasParticipacion = 0;
        IdParticipacion = 0;
    }
}