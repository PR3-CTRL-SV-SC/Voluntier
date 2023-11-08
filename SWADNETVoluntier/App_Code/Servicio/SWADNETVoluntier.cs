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
    public List<ECCampania> Obtener_CCampania_O_Sede(string sedeCampania)
    {
        CCCampania cCCampania = new CCCampania();
        List<ECCampania> lstCCampania = new List<ECCampania>();
        lstCCampania = cCCampania.Obtener_CCampania_O_Sede(sedeCampania);
        return lstCCampania;

    }

    public List<ECCampania> Obtener_CCampania_O()
    {
        CCCampania cCCampania = new CCCampania();
        List<ECCampania> lstCCampania = new List<ECCampania>();
        lstCCampania = cCCampania.Obtener_CCampania_O();
        return lstCCampania;
    }

    public ECCampania Obtener_CCampania_O_IdCampania(int idCampania)
    {
        CCCampania cCCampania = new CCCampania();
        ECCampania eCCampania = new ECCampania();
        eCCampania = cCCampania.Obtener_CCampania_O_IdCampania(idCampania);
        return eCCampania;
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

    public void Actualizar_CCampania_A_Estado(int idCampania, string estadoCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Actualizar_CCampania_A_Estado(idCampania, estadoCampania);
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(int idCampania)
    {
        CCCampania cCCampania = new CCCampania();
        cCCampania.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
    }
    #endregion
    #region Tabla: CCParticipacion
    public List<ECParticipacion> Obtener_CParticipacion_O()
    {
        CCParticipacion cCParticipacion = new CCParticipacion();
        List<ECParticipacion> lstCCParticipacion = new List<ECParticipacion>();
        lstCCParticipacion = cCParticipacion.Obtener_CParticipacion_O();
        return lstCCParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        CCParticipacion cCParticipacion = new CCParticipacion();
        List<ECParticipacion> lstCCParticipacion = new List<ECParticipacion>();
        lstCCParticipacion = cCParticipacion.Obtener_CParticipacion_O_PorUsuario(idUsuario);
        return lstCCParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        CCParticipacion cCParticipacion = new CCParticipacion();
        List<ECParticipacion> lstCCParticipacion = new List<ECParticipacion>();
        lstCCParticipacion = cCParticipacion.Obtener_CParticipacion_O_PorCampania(idCampania);
        return lstCCParticipacion;
    }

    public void Insertar_CParticipacion_I(ECParticipacion eCCParticipacion)
    {
        CCParticipacion cCParticipacion = new CCParticipacion();
        cCParticipacion.Insertar_CParticipacion_I(eCCParticipacion);
    }

    public void Actualizar_CParticipacion_A(ECParticipacion eCCParticipacion)
    {
        CCParticipacion cCParticipacion = new CCParticipacion();
        cCParticipacion.Actualizar_CParticipacion_A(eCCParticipacion);
    }
    #endregion
    #region Tabla: CCSolicitudParticipacion
    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        CCSolicitudParticipacion cCSolicitudParticipacion = new CCSolicitudParticipacion();
        List<ECSolicitudParticipacion> lstCSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        lstCSolicitudParticipacion = cCSolicitudParticipacion.Obtener_CSolicitudes_O_Campania(idCampania);
        return lstCSolicitudParticipacion;
    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        CCSolicitudParticipacion cCSolicitudParticipacion = new CCSolicitudParticipacion();
        List<ECSolicitudParticipacion> lstCSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        lstCSolicitudParticipacion = cCSolicitudParticipacion.Obtener_CSolicitudes_O_Usuario(idUsuario);
        return lstCSolicitudParticipacion;
    }

    public void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion)
    {
        CCSolicitudParticipacion cCSolicitudParticipacion = new CCSolicitudParticipacion();
        cCSolicitudParticipacion.Insertar_CSolicitud_I(eCSolicitudParticipacion);
    }

    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        CCSolicitudParticipacion cCSolicitudParticipacion = new CCSolicitudParticipacion();
        cCSolicitudParticipacion.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
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
}
