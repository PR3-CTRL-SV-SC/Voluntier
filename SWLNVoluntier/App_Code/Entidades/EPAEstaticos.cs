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
    static public string EstadoActiva = "AC";
    static public string EstadoCancelada = "CA";
    static public string EstadoFinalizada = "FI";
    static public string EstadoValido = "VA";
    static public string EstadoInvalido = "IV";
    [DataMember]
    static public DateTime FechaModificacion = DateTime.Now;
    [DataMember]
    static public DateTime FechaRegistro = DateTime.Now;

    public EPAEstaticos()
    {

    }
}