using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EUsuarioCompleja
/// </summary>
[DataContract]
public class EUsuarioCompleja
{
    [DataMember]
    public string NombreCompleto { get; set; }
    [DataMember]
    public int Horas { get; set; }
    public EUsuarioCompleja()
    {
        NombreCompleto = string.Empty;
        Horas = 0;
    }
}