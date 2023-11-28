using System;
using System.Runtime.Serialization;

/// <summary>
/// Summary Variables estaticas de Procedimientos Almacenados
/// </summary>
//public enum Estado { CANCELADA, FINALIZADA, ACTIVA, VALIDO }
[DataContract]
public class EPAEstaticos
{
    [DataMember]
    static public string EstadoActiva = "AC";
    [DataMember]
    static public string EstadoCancelada = "CA";
    [DataMember]
    static public string EstadoFinalizada = "FI";
    [DataMember]
    static public string EstadoValido = "VA";
    [DataMember]
    static public DateTime FechaModificacion = DateTime.Now;
    [DataMember]
    static public DateTime FechaRegistro = DateTime.Now;
    [DataMember]
    static public int HorasUsuario = 0;

    public EPAEstaticos()
    {

    }

}