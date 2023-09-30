using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for ECSolicitudParticipacion
/// </summary>
public class ECSolicitudParticipacion
{
    #region Atributos
    [DataMember]
    public int IdSolicitud { get; set; }
    [DataMember]
    public int IdUsuarioSolicitud { get; set; }
    [DataMember]
    public int IdCampaniaSolicitud { get; set; }
    [DataMember]
    public string EstadoSolicitud { get; set; }

    #endregion

    public ECSolicitudParticipacion()
    {
        IdSolicitud = 0;
        IdUsuarioSolicitud = 0;
        IdCampaniaSolicitud = 0;
        EstadoSolicitud = string.Empty;
    }
}