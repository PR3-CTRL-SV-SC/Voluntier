using System.Runtime.Serialization;

/// <summary>
/// Summary description for ECSolicitudParticipacion
/// </summary>
public class ECSolicitudParticipacion
{
    #region Atributos
    [DataMember]
    public int IdSolicitud { get; set; }
    [DataMember]
    public string IdUsuarioSolicitud { get; set; }
    [DataMember]
    public int IdCampaniaSolicitud { get; set; }
    [DataMember]
    public string EstadoSolicitud { get; set; }

    #endregion

    public ECSolicitudParticipacion()
    {
        IdSolicitud = 0;
        IdUsuarioSolicitud = string.Empty;
        IdCampaniaSolicitud = 0;
        EstadoSolicitud = string.Empty;
    }
}