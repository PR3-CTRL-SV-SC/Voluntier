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
            eCUsuarioNetvalle.NombreUsuarioNetvalle = drCUsuarioNetvalle.NombreUsuarioNetvalle.ToString().TrimEnd();
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
            eCUsuarioNetvalle.NombreUsuarioNetvalle = drCUsuarioNetvalle.NombreUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.ApellidosUsuarioNetvalle = drCUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.CargoUsuarioNetvalle = drCUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
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
            eCUsuarioNetvalle.NombreUsuarioNetvalle = drCUsuarioNetvalle.NombreUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.ApellidosUsuarioNetvalle = drCUsuarioNetvalle.ApellidosUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.CargoUsuarioNetvalle = drCUsuarioNetvalle.CargoUsuarioNetvalle.ToString().TrimEnd();
            eCUsuarioNetvalle.SedeUsuarioNetvalle = drCUsuarioNetvalle.SedeUsuarioNetvalle.ToString().TrimEnd();
        }
        return eCUsuarioNetvalle;
    }

    public void Insertar_CUsuarioNetvalle_y_CUsuario(
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string sedeUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        adCUsuarioNetvalle.Insertar_CUsuarioNetvalle_y_CUsuario(
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        sedeUsuarioNetvalle);

    }
    #endregion
}