using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;


/// <summary>
/// Descripción breve de ERCampania
/// </summary>
[DataContract]
public class ERCampania
{
    #region Atributos
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
    
    #endregion

    public ERCampania()
    {
        NombreCampania = string.Empty;
        DescripcionCampania = string.Empty;
        FechaInicioCampania = DateTime.MinValue;
        FechaFinCampania = DateTime.MinValue;
        EstadoCampania = string.Empty;
        SedeCampania = string.Empty;
        FechaRegistroCampania = DateTime.MinValue;
        FechaModificacionCampania = DateTime.MinValue;
        
    }


}