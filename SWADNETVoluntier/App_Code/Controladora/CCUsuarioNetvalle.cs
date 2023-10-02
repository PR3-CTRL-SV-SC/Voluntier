using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCUsuarioNetvalle
/// </summary>
public class CCUsuarioNetvalle
{
    #region Metodos privados
    private ADCUsuarioNetvalle adCUsuarioNetvalle;
    #endregion
    #region Metodo publicos
    public CCUsuarioNetvalle()
    {
        adCUsuarioNetvalle = new ADCUsuarioNetvalle();
    }

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = adCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetvalle, codigoUsuarioNetvalle);
        foreach (DTOCUsuarioNetvalle.CUsuarioNetvalleRow drCUsuarioNetvalle in dtoCUsuarioNetvalle.CUsuarioNetvalle.Rows)
        {
            eCUsuarioNetvalle = new ECUsuarioNetvalle();
            eCUsuarioNetvalle.NombresUsuarioNetvalle = drCUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.ApellidosUsuarioNetvalle = drCUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
        }
        return eCUsuarioNetvalle;
    }

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = adCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        foreach (DTOCUsuarioNetvalle.CUsuarioNetvalleRow drCUsuarioNetvalle in dtoCUsuarioNetvalle.CUsuarioNetvalle.Rows)
        {
            eCUsuarioNetvalle = new ECUsuarioNetvalle();
            eCUsuarioNetvalle.CodigoUsuarioNetvalle = drCUsuarioNetvalle.CodigoUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.NombresUsuarioNetvalle = drCUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.ApellidosUsuarioNetvalle = drCUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.CargoUsuarioNetvalle = drCUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.TarjetaUsuarioNetvalle = drCUsuarioNetvalle.TarjetaUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.SedeUsuarioNetvalle = drCUsuarioNetvalle.SedeUsuarioNetvalle.ToString().TrimEnd();
        }
        return eCUsuarioNetvalle;
    }

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        DTOCUsuarioNetvalle dtoCUsuarioNetvalle = adCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetvalle);
        foreach (DTOCUsuarioNetvalle.CUsuarioNetvalleRow drCUsuarioNetvalle in dtoCUsuarioNetvalle.CUsuarioNetvalle.Rows)
        {
            eCUsuarioNetvalle = new ECUsuarioNetvalle();
            eCUsuarioNetvalle.CodigoUsuarioNetvalle = drCUsuarioNetvalle.CodigoUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.NombresUsuarioNetvalle = drCUsuarioNetvalle.NombresUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.ApellidosUsuarioNetvalle = drCUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.CargoUsuarioNetvalle = drCUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.TarjetaUsuarioNetvalle = drCUsuarioNetvalle.TarjetaUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.SedeUsuarioNetvalle = drCUsuarioNetvalle.SedeUsuarioNetvalle.ToString().TrimEnd();
        }
        return eCUsuarioNetvalle;
    }

    public void Insertar_CUsuarioNetvalle_y_CUsuario(string roleUsuario,
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string tarjetaUsuarioNetvalle,
        string sedeUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        adCUsuarioNetvalle.Insertar_CUsuarioNetvalle_y_CUsuario(roleUsuario,
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        tarjetaUsuarioNetvalle,
        sedeUsuarioNetvalle);

    }
    #endregion
}