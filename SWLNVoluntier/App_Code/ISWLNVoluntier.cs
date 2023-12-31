﻿using SWADNETVoluntier;
using System;
using System.Collections.Generic;
using System.ServiceModel;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface ISWLNVoluntier
{
    #region CCampania
    [OperationContract]
    List<ECCampania> Obtener_CCampania_O();
    [OperationContract]
    List<ECCampania> Obtener_CCampania_O_Sede(string Sede);
    [OperationContract]
    ECCampania Obtener_CCampania_O_IdCampania(int idCampania);
    [OperationContract]
    void Insertar_CCampania_I(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A(ECCampania eCCampania);
    [OperationContract]
    void Actualizar_CCampania_A_Estado(int idCampania, string nuevoEstado);
    [OperationContract]
    void Actualizar_CCampania_A_Estado_Cancelado(int idCampania);
    #endregion

    #region CParticipacion
    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O();
    [OperationContract]
    void Insertar_CParticipacion_I(ECParticipacion eCParticipacion);
    [OperationContract]
    void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion);
    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario);
    [OperationContract]
    List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania);
    #endregion

    #region CSolicitudParticipacion
    [OperationContract]
    List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania);
    [OperationContract]
    List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario);
    [OperationContract]
    void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion);
    [OperationContract]
    void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado);
    #endregion

    #region CUsuario
    [OperationContract]
    ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle);
    [OperationContract]
    List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle);
    [OperationContract]
    void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, string horas);
    #endregion

    #region CUsuarioNetvalle
    [OperationContract]
    ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle);
    [OperationContract]
    void Insertar_CUsuarioNetvalle_y_CUsuario(
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string sedeUsuarioNetvalle);
    #endregion

    #region EUsuarioCompleja
    [OperationContract]
    List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string Sede);
    #endregion

    #region LNReciclaje
    [OperationContract]
    ECUsuarioNetvalle CUsuarioNetvalle_CUsuario_I(string tarjeta);
    #endregion

    [OperationContract]
    string Descifrado(string Texto, string Tipo);
    [OperationContract]
    string Cifrar_Cadena(string TextoACifrar);
    [OperationContract]
    Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string IdEmp, string Sede);
    [OperationContract]
    Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string IdEmp, string Sede);
}