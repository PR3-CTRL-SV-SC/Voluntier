using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class SWADNETVoluntier : ISWADNETVoluntier
{
    #region Tabla : CCampania
    public ECCampania Obtener_CCampania_O_Sede(string sedeCampania)
    {
        CCCampania cCCampania = new CCCampania();
        ECCampania eCCampania = new ECCampania();
        eCCampania = cCCampania.Obtener_CCampania_O_Sede(sedeCampania);
        return eCCampania;

    }

    public List<ECCampania> Obtener_CCampania_O()
    {
        CCCampania cCCampania = new CCCampania();
        List<ECCampania> lstCCampania = new List<ECCampania>();
        lstCCampania = cCCampania.Obtener_CCampania_O();
        return lstCCampania;
    }

    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Insertar_CCampania_I(eCCampania);
    }

    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Actualizar_CCampania_A(eCCampania);
    }

    public void Actualizar_CCampania_A_Estado(string idCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Actualizar_CCampania_A_Estado(idCampania);
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(string idCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
    }
    #endregion
    #region Tabla : CUsuario
    public ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario)
    {
        CCUsuario cCUsuario = new CCUsuario();
        ECUsuario eCUsuario = new ECUsuario();
        eCUsuario = cCUsuario.Obtener_CUsuario_O_Codigo(codigoUsuario);
        return eCUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        CCUsuario cCUsuario = new CCUsuario();
        List<ECUsuario> lsteCUsuario = new List<ECUsuario>();
        lsteCUsuario = cCUsuario.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle);
        return lsteCUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        CCUsuario cCUsuario = new CCUsuario();
        List<ECUsuario> lsteCUsuario = new List<ECUsuario>();
        lsteCUsuario = cCUsuario.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle);
        return lsteCUsuario;
    }

    public void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, int horasUsuario)
    {
        CCUsuario cCUsuario = new CCUsuario();
        cCUsuario.Actualizar_CUsuario_A_Horas_Codigo(codigoUsuario, horasUsuario);
    }
    #endregion
    #region Tabla: CUsuarioNetvalle
    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(string sedeUsuarioNetvalle, string codigoUsuarioNetvalle)
    {
        CCUsuarioNetvalle cCUsuarioNetvalle = new CCUsuarioNetvalle();
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        eCUsuarioNetvalle = cCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Top_Sede_Codigo(sedeUsuarioNetvalle, codigoUsuarioNetvalle);
        return eCUsuarioNetvalle;
    }

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        CCUsuarioNetvalle cCUsuarioNetvalle = new CCUsuarioNetvalle();
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        eCUsuarioNetvalle = cCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        return eCUsuarioNetvalle;
    }

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Tarjeta(string tarjetaUsuarioNetvalle)
    {
        CCUsuarioNetvalle cCUsuarioNetvalle = new CCUsuarioNetvalle();
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        eCUsuarioNetvalle = cCUsuarioNetvalle.Obtener_CUsuarioNetvalle_O_Tarjeta(tarjetaUsuarioNetvalle);
        return eCUsuarioNetvalle;
    }
    public void Insertar_CUsuarioNetvalle_y_CUsuario(string roleUsuario, string codigoUsuarioNetvalle, string nombresUsuarioNetvalle, string apellidosUsuarioNetvalle, string cargoUsuarioNetvalle, string tarjetaUsuarioNetvalle, string sedeUsuarioNetvalle)
    {
        CCUsuarioNetvalle cCUsuarioNetvalle = new CCUsuarioNetvalle();
        cCUsuarioNetvalle.Insertar_CUsuarioNetvalle_y_CUsuario(roleUsuario,
        codigoUsuarioNetvalle,
        nombresUsuarioNetvalle,
        apellidosUsuarioNetvalle,
        cargoUsuarioNetvalle,
        tarjetaUsuarioNetvalle,
        sedeUsuarioNetvalle);
    }
    #endregion
    //public string GetData(int value)
    //{
    //	return string.Format("You entered: {0}", value);
    //}

    //public CompositeType GetDataUsingDataContract(CompositeType composite)
    //{
    //	if (composite == null)
    //	{
    //		throw new ArgumentNullException("composite");
    //	}
    //	if (composite.BoolValue)
    //	{
    //		composite.StringValue += "Suffix";
    //	}else
    //		composite.StringValue += "No Suffix";
    //	return composite;
    //}
}
