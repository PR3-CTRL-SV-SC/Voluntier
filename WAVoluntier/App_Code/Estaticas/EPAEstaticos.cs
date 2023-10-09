using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Descripción breve de EPAEstaticos
/// </summary>
public class EPAEstaticos
{
    static public string EstadoActiva = "AC";
    static public string EstadoCancelada = "CA";
    static public string EstadoFinalizada = "FI";
    static public string EstadoValido = "VA";
    static public string EstadoInvalido = "IV";
    static public DateTime FechaModificacion = DateTime.Now;
    static public DateTime FechaRegistro = DateTime.Now;
    static public double DonacionVoto = 0;

    public EPAEstaticos()
    {

    }

}