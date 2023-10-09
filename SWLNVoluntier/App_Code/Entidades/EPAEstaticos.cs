using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for EPAEstaticos
/// </summary>
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
    static public double DonacionVoto = 0;

    public EPAEstaticos()
    {

    }
}