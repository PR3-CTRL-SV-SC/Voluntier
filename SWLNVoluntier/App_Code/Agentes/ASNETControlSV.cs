using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Web;
using SWADNETVoluntier;

/// <summary>
/// Summary description for ASNETControlSV
/// </summary>
public class ASNETControlSV
{
    #region Variables miembro
    private SWADNETVoluntierClient swADNETVoluntier;
    #endregion
    public ASNETControlSV()
    {
        swADNETReciclado = new SWADNETRecicladoClient();
    }
    #region Metodos privados

    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNVoluntier";
        eDefecto.Clase = "ASNETRecic";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
    }

    #endregion
}