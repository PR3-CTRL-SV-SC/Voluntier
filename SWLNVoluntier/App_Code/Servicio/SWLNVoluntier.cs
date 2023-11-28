using SWADNETVoluntier;
using System;
using System.Collections.Generic;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class SWLNVoluntier : ISWLNVoluntier
{

    #region CCampania
    public List<ECCampania> Obtener_CCampania_O()
    {
        CControlSV cControlSV = new CControlSV();
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        lstEcCampania = cControlSV.Obtener_CCampania_O();
        return lstEcCampania;
    }
    public List<ECCampania> Obtener_CCampania_O_Sede(string Sede)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        lstEcCampania = cControlSV.Obtener_CCampania_O_Sede(Sede);
        return lstEcCampania;
    }
    public ECCampania Obtener_CCampania_O_IdCampania(int idCampania)
    {
        CControlSV cControlSV = new CControlSV();
        ECCampania eCCampania = new ECCampania();
        eCCampania = cControlSV.Obtener_CCampania_O_IdCampania(idCampania);
        return eCCampania;
    }
    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Insertar_CCampania_I(eCCampania);
    }
    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CCampania_A(eCCampania);
    }
    public void Actualizar_CCampania_A_Estado(int idCampania, string nuevoEstado)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
    }
    public void Actualizar_CCampania_A_Estado_Cancelado(int idCampania)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
    }
    #endregion

    #region CParticipacion
    public List<ECParticipacion> Obtener_CParticipacion_O()
    {
        CControlSV cControlSV = new CControlSV();
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        lstEcParticipacion = cControlSV.Obtener_CParticipacion_O();
        return lstEcParticipacion;
    }
    public void Insertar_CParticipacion_I(ECParticipacion eCParticipacion)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Insertar_CParticipacion_I(eCParticipacion);
    }
    public void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CParticipacion_A(eCParticipacion);
    }
    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        lstEcParticipacion = cControlSV.Obtener_CParticipacion_O_PorUsuario(idUsuario);
        return lstEcParticipacion;
    }
    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        lstEcParticipacion = cControlSV.Obtener_CParticipacion_O_PorCampania(idCampania);
        return lstEcParticipacion;
    }
    #endregion

    #region CSolicitudParticipacion
    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECSolicitudParticipacion> lstECSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        lstECSolicitudParticipacion = cControlSV.Obtener_CSolicitudes_O_Campania(idCampania);
        return lstECSolicitudParticipacion;
    }
    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECSolicitudParticipacion> lstECSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        lstECSolicitudParticipacion = cControlSV.Obtener_CSolicitudes_O_Usuario(idUsuario);
        return lstECSolicitudParticipacion;
    }
    public void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Insertar_CSolicitud_I(eCSolicitudParticipacion);
    }
    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
    }
    #endregion

    #region CUsuario
    public ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario)
    {
        CControlSV cControlSV = new CControlSV();
        ECUsuario eCUsuario = new ECUsuario();
        eCUsuario = cControlSV.Obtener_CUsuario_O_Codigo(codigoUsuario);
        return eCUsuario;
    }
    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECUsuario> lstECUsuario = new List<ECUsuario>();
        lstECUsuario = cControlSV.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle);
        return lstECUsuario;
    }
    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        CControlSV cControlSV = new CControlSV();
        List<ECUsuario> lstECUsuario = new List<ECUsuario>();
        lstECUsuario = cControlSV.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle);
        return lstECUsuario;
    }
    public void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, string horas)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Actualizar_CUsuario_A_Horas_Codigo(codigoUsuario, horas);
    }
    #endregion

    #region CUsuarioNetvalle
    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        CControlSV cControlSV = new CControlSV();
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        eCUsuarioNetvalle = cControlSV.Obtener_CUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        return eCUsuarioNetvalle;
    }
    public void Insertar_CUsuarioNetvalle_y_CUsuario(
               string codigoUsuarioNetvalle,
                      string nombresUsuarioNetvalle,
                             string apellidosUsuarioNetvalle,
                                    string cargoUsuarioNetvalle,
                                                  string sedeUsuarioNetvalle)
    {
        CControlSV cControlSV = new CControlSV();
        cControlSV.Insertar_CUsuarioNetvalle_y_CUsuario(
                       codigoUsuarioNetvalle,
                                  nombresUsuarioNetvalle,
                                             apellidosUsuarioNetvalle,
                                                        cargoUsuarioNetvalle,
                                                                              sedeUsuarioNetvalle);
    }
    #endregion


    #region EUsuarioCompleja
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede)
    {
        CControlSV cControlSV = new CControlSV();
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        lstEUsuarioCompleja = cControlSV.Obtener_EUsuarioCompleja_O_Sede(Sede);
        return lstEUsuarioCompleja;
    }
    #endregion


    //AÃ±adidas
    public string Descifrado(string Texto, string Tipo)
    {
        return "";
    }
    public string Cifrar_Cadena(string TextoACifrar)
    {
        return "";
    }
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        result = null;
        return result;
    }
    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        result = null;
        return result;
    }

    public ECUsuarioNetvalle CUsuarioNetvalle_CUsuario_I(string tarjeta)
    {
        CControlSV cControlSV = new CControlSV();
        return cControlSV.CUsuarioNetvalle_CUsuario_I(tarjeta);
    }
}