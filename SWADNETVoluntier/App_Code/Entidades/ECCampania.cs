using System;
using System.Runtime.Serialization;


/// <summary>
/// Descripción breve de ECCampania
/// </summary>
[DataContract]
public class ECCampania
{
    #region Atributos
    [DataMember]
    public int IdCampania { get; set; }
    [DataMember]
    public string NombreCampania { get; set; }
    [DataMember]
    public string DescripcionCampania { get; set; }
    [DataMember]
    public DateTime FechaInicioCampania { get; set; }
    [DataMember]
    public DateTime FechaFinCampania { get; set; }
    [DataMember]
    public string EstadoCampania { get; set; }
    [DataMember]
    public string SedeCampania { get; set; }
    [DataMember]
    public DateTime FechaRegistroCampania { get; set; }
    [DataMember]
    public DateTime FechaModificacionCampania { get; set; }
    [DataMember]
    public string IdUsuarioCreador { get; set; }

    #endregion

    public ECCampania()
    {
        NombreCampania = string.Empty;
        DescripcionCampania = string.Empty;
        FechaInicioCampania = DateTime.MinValue;
        FechaFinCampania = DateTime.MinValue;
        EstadoCampania = string.Empty;
        SedeCampania = string.Empty;
        FechaRegistroCampania = DateTime.MinValue;
        FechaModificacionCampania = DateTime.MinValue;
        IdUsuarioCreador = string.Empty;
    }
}