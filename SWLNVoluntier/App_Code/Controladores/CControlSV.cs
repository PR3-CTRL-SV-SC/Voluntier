using SWADNETVoluntier;
using SWVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web.UI.WebControls;
using System.Xml;

/// <summary>
/// Summary description for CControlSV
/// </summary>
public class CControlSV
{
    #region Variable de miembro
    ASNETControlSV aSNetControlSV;
    #endregion
    public CControlSV()
    {
        aSNetControlSV = new ASNETControlSV();
    }

    #region Metodos privados
    private EDefecto ContruirErrorServicio(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto();
        eDefecto.TipoDefecto = tipoDefecto;
        eDefecto.Servicio = "SWLNVoluntier";
        eDefecto.Clase = "CVoluntier";
        eDefecto.Metodo = metodo;
        eDefecto.Excepcion = excepcion;
        eDefecto.Mensaje = mensaje;
        return eDefecto;
    }

    #endregion
    #region Metodos Publicos

    #region CCampania
    public List<ECCampania> Obtener_CCampania_O()
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = aSNetControlSV.Obtener_CCampania_O().ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcCampania = aSNetControlSV.Obtener_CCampania_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_RCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
        return lstEcCampania;
    }

    public ECCampania Obtener_CCampania_O_IdCampania(int idCampania)
    {
        ECCampania ecCampania = new ECCampania();
        try
        {
            ecCampania = aSNetControlSV.Obtener_CCampania_O_IdCampania(idCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                ecCampania = aSNetControlSV.Obtener_CCampania_O_IdCampania(idCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
        return ecCampania;
    }

    public void Insertar_CCampania_I(ECCampania ecCampania)
    {
        try
        {
            aSNetControlSV.Insertar_CCampania_I(ecCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CCampania_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Insertar_CCampania_I(ecCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
    }

    public void Actualizar_CCampania_A(ECCampania ecCampania)
    {
        try
        {
            aSNetControlSV.Actualizar_CCampania_A(ecCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Actualizar_CCampania_A(ecCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
    }

    public void Actualizar_CCampania_A_Estado(int idCampania, string nuevoEstado)
    {
        try
        {
            aSNetControlSV.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(int idCampania)
    {
        try
        {
            aSNetControlSV.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
    }

    public List<ECCampania> Obtener_CCampania_O_Sede(string sedeCampania)
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = aSNetControlSV.Obtener_CCampania_O_Sede(sedeCampania);

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcCampania = aSNetControlSV.Obtener_CCampania_O_Sede(sedeCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }

        }
        return lstEcCampania;
    }
    #endregion

    #region CParticipacion

    public List<ECParticipacion> Obtener_CParticipacion_O()
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O().ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }
        }
        return lstEcParticipacion;
    }

    public void Insertar_CParticipacion_I(ECParticipacion ecParticipacion)
    {
        try
        {
            aSNetControlSV.Insertar_CParticipacion_I(ecParticipacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CParticipacion_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Insertar_CParticipacion_I(ecParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CParticipacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
    }

    public void Actualizar_CParticipacion_A(ECParticipacion ecParticipacion)
    {
        try
        {
            aSNetControlSV.Actualizar_CParticipacion_A(ecParticipacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Actualizar_CParticipacion_A(ecParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return lstEcParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcParticipacion = aSNetControlSV.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }
        }
        return lstEcParticipacion;
    }

    #endregion

    #region CSolicitud

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        List<ECSolicitudParticipacion> lstEcSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitudParticipacion = aSNetControlSV.Obtener_CSolicitudes_O_Campania(idCampania).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcSolicitudParticipacion = aSNetControlSV.Obtener_CSolicitudes_O_Campania(idCampania).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return lstEcSolicitudParticipacion;

    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        List<ECSolicitudParticipacion> lstEcSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitudParticipacion = aSNetControlSV.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcSolicitudParticipacion = aSNetControlSV.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return lstEcSolicitudParticipacion;
    }

    public void Insertar_CSolicitud_I(ECSolicitudParticipacion ecSolicitudParticipacion)
    {
        try
        {
            aSNetControlSV.Insertar_CSolicitud_I(ecSolicitudParticipacion);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CSolicitud_I", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Insertar_CSolicitud_I(ecSolicitudParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CSolicitud_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
    }

    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        try
        {
            aSNetControlSV.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                aSNetControlSV.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
    }
    #endregion

    #region CUsuario

    public ECUsuario Obtener_CUsuario_O_Codigo(string CodigoUsuario)
    {
        ECUsuario ecUsuario = new ECUsuario();
        try
        {
            ecUsuario = aSNetControlSV.Obtener_CUsuario_O_Codigo(CodigoUsuario);

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {

                ecUsuario = aSNetControlSV.Obtener_CUsuario_O_Codigo(CodigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return ecUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = aSNetControlSV.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {

                lstEcUsuario = aSNetControlSV.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return lstEcUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = aSNetControlSV.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {

                lstEcUsuario = aSNetControlSV.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
        return lstEcUsuario;
    }

    public void Actualizar_CUsuario_A_Horas_Codigo(string Codigo, string Horas)
    {
        try
        {
            aSNetControlSV.Actualizar_CUsuario_A_Horas_Codigo(Codigo, Horas);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {

                aSNetControlSV.Actualizar_CUsuario_A_Horas_Codigo(Codigo, Horas);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;

            }
        }
    }

    #endregion

    #region CUsuarioNetvalle

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string CodigoUsuarioNetvalle)
    {
        ECUsuarioNetvalle ecUsuarioNetvalle = new ECUsuarioNetvalle();
        try
        {
            ecUsuarioNetvalle = aSNetControlSV.Obtener_CUsuarioNetvalle_O_Codigo(CodigoUsuarioNetvalle);

        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);

        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;

            if (feaultEx == null)
            {

                ecUsuarioNetvalle = aSNetControlSV.Obtener_CUsuarioNetvalle_O_Codigo(CodigoUsuarioNetvalle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }
        }
        return ecUsuarioNetvalle;

    }

    public void Insertar_CUsuarioNetvalle_y_CUsuario(
        string codigoUsuarioNetvalle,
        string nombresUsuarioNetvalle,
        string apellidosUsuarioNetvalle,
        string cargoUsuarioNetvalle,
        string sedeUsuarioNetvalle)
    {
        try
        {
            aSNetControlSV.Insertar_CUsuarioNetvalle_y_CUsuario(
                       codigoUsuarioNetvalle,
                              nombresUsuarioNetvalle,
                                     apellidosUsuarioNetvalle,
                                            cargoUsuarioNetvalle,
                                                sedeUsuarioNetvalle);
        }
        catch (EndpointNotFoundException EndPointEx)
        {

            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CUsuarioNetvalle_y_CUsuario", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {

            FaultException feaultEx = CommEx as FaultException;

            if (feaultEx == null)
            {

                aSNetControlSV.Insertar_CUsuarioNetvalle_y_CUsuario(
                           codigoUsuarioNetvalle,
                                  nombresUsuarioNetvalle,
                                         apellidosUsuarioNetvalle,
                                                cargoUsuarioNetvalle,
                                                              sedeUsuarioNetvalle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CUsuarioNetvalle_y_CUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
                //throw feaultEx;
            }
        }
    }


    #endregion

    #region EUsuarioCompleja
    public List<EUsuarioCompleja> Obtener_EUsuarioCompleja_O_Sede(string sedeUsuario)
    {
        List<EUsuarioCompleja> lstEUsuarioCompleja = new List<EUsuarioCompleja>();
        List<ECUsuario> lstCUsuario = new List<ECUsuario>();
        ECUsuarioNetvalle ecUsuarioNetvalle;
        EUsuarioCompleja eUsuarioCompleja;
        try
        {
            lstCUsuario = aSNetControlSV.Obtener_CUsuarios_O_Top_Horas(sedeUsuario);
            foreach (ECUsuario ecUsuario in lstCUsuario)
            {
                eUsuarioCompleja = new EUsuarioCompleja();
                ecUsuarioNetvalle = new ECUsuarioNetvalle();
                ecUsuarioNetvalle = aSNetControlSV.Obtener_CUsuarioNetvalle_O_Codigo(ecUsuario.CodigoUsuario);
                eUsuarioCompleja.NombreCompleto = ecUsuarioNetvalle.NombreUsuarioNetvalle + " " + ecUsuarioNetvalle.ApellidosUsuarioNetvalle;
                lstEUsuarioCompleja.Add(eUsuarioCompleja);
            }
            return lstEUsuarioCompleja;
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstCUsuario = aSNetControlSV.Obtener_CUsuarios_O_Top_Horas(sedeUsuario);
                foreach (ECUsuario erUsuario in lstCUsuario)
                {
                    eUsuarioCompleja = new EUsuarioCompleja();
                    ecUsuarioNetvalle = new ECUsuarioNetvalle();
                    ecUsuarioNetvalle = aSNetControlSV.Obtener_CUsuarioNetvalle_O_Codigo(erUsuario.CodigoUsuario);
                    eUsuarioCompleja.NombreCompleto = ecUsuarioNetvalle.NombreUsuarioNetvalle + " " + ecUsuarioNetvalle.ApellidosUsuarioNetvalle;
                    eUsuarioCompleja.Horas = Convert.ToInt32(erUsuario.HorasUsuario);
                    lstEUsuarioCompleja.Add(eUsuarioCompleja);
                }
                return lstEUsuarioCompleja;
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_EUsuarioCompleja_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }

    }

    #endregion

    #region LNReciclaje
    public ECUsuarioNetvalle CUsuarioNetvalle_CUsuario_I(string tarjeta)
    {
        SWReciclajeClient client = new SWReciclajeClient();
        ECUsuarioNetvalle usuarioNetvalle = new ECUsuarioNetvalle();
        //00055840406248
        string usuarioEncrip = client.Encriptar("Reciclaje1");
        string claveEncriptada = client.Encriptar("Reciclaje123");
        string tarjetaEncriptada = client.Encriptar(tarjeta);

        object result = client.ObtenerInformacionEstudiante(usuarioEncrip, claveEncriptada, tarjetaEncriptada);

        result = client.Desencriptar(result.ToString());

        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(result.ToString());

        XmlNode root = xmlDoc.DocumentElement;

        XmlNode XMLCodigo = root.SelectSingleNode("Codigo");
        XmlNode XMLMensaje = root.SelectSingleNode("Mensaje");
        if (XMLMensaje != null && XMLCodigo != null)
        {
            usuarioNetvalle.NombreUsuarioNetvalle = XMLCodigo.InnerText.ToString() + "," + XMLMensaje.InnerText.ToString();
            return usuarioNetvalle;
        }
        else
        {
            XmlNode XMLcarrera = root.SelectSingleNode("Carrera");
            XmlNode XMLcodigoUsuario = root.SelectSingleNode("CodigoUsuario");
            XmlNode XMLcodigoSedeAcademica = root.SelectSingleNode("CodigoSedeAcademica");
            XmlNode XMLnombreCompleto = root.SelectSingleNode("NombreCompleto");
            XmlNode XMLId_TipoUsuario = root.SelectSingleNode("Id_TipoUsuario");


            if (XMLId_TipoUsuario.InnerText.ToString() == "ES" && XMLcarrera.InnerText.ToString() != string.Empty)
            {
                string carrera = XMLcarrera.InnerText;
                string codigoUsuario = XMLcodigoUsuario.InnerText;
                string codigoSedeAcademica = XMLcodigoSedeAcademica.InnerText;
                string nombreCompleto = XMLnombreCompleto.InnerText;
                string[] nombreCompletoEstudiante = nombreCompleto.Split(' ');
                if (codigoSedeAcademica == "C")
                {
                    codigoSedeAcademica = "Cochabamba";
                }

                usuarioNetvalle.CodigoUsuarioNetvalle = codigoUsuario;
                usuarioNetvalle.SedeUsuarioNetvalle = codigoSedeAcademica;
                usuarioNetvalle.CargoUsuarioNetvalle = "Estudiante";

                usuarioNetvalle.EstadoUsuarioNetvalle = char.Parse(EPAEstaticos.EstadoActiva);
                usuarioNetvalle.FechaModificacionUsuarioNetvalle = EPAEstaticos.FechaModificacion;
                usuarioNetvalle.FechaRegistroUsuarioNetvalle = EPAEstaticos.FechaRegistro;
                if (nombreCompletoEstudiante.Length > 3)
                {
                    usuarioNetvalle.NombreUsuarioNetvalle = nombreCompletoEstudiante[2] + " " + nombreCompletoEstudiante[3];
                    usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                }
                usuarioNetvalle.NombreUsuarioNetvalle = nombreCompletoEstudiante[2];
                usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                return usuarioNetvalle;
            }
            else
            {
                if (XMLId_TipoUsuario.InnerText.ToString() == "AD" && XMLcarrera.InnerText.ToString() == string.Empty)
                {
                    string carrera = XMLcarrera.InnerText;
                    string codigoUsuario = XMLcodigoUsuario.InnerText;
                    string codigoSedeAcademica = XMLcodigoSedeAcademica.InnerText;
                    string nombreCompleto = XMLnombreCompleto.InnerText;
                    string[] nombreCompletoEstudiante = nombreCompleto.Split(' ');
                    {
                        codigoSedeAcademica = "Cochabamba";
                    }

                    usuarioNetvalle.CodigoUsuarioNetvalle = codigoUsuario;
                    usuarioNetvalle.SedeUsuarioNetvalle = codigoSedeAcademica;
                    usuarioNetvalle.CargoUsuarioNetvalle = "Administrador";

                    usuarioNetvalle.EstadoUsuarioNetvalle = char.Parse(EPAEstaticos.EstadoActiva);
                    usuarioNetvalle.FechaModificacionUsuarioNetvalle = EPAEstaticos.FechaModificacion;
                    usuarioNetvalle.FechaRegistroUsuarioNetvalle = EPAEstaticos.FechaRegistro;
                    if (nombreCompletoEstudiante.Length > 3)
                    {
                        usuarioNetvalle.NombreUsuarioNetvalle = nombreCompletoEstudiante[2] + " " + nombreCompletoEstudiante[3];
                        usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                    }
                    usuarioNetvalle.NombreUsuarioNetvalle = nombreCompletoEstudiante[2];
                    usuarioNetvalle.ApellidosUsuarioNetvalle = nombreCompletoEstudiante[0] + " " + nombreCompletoEstudiante[1];
                    return usuarioNetvalle;
                }
                usuarioNetvalle.NombreUsuarioNetvalle = "Cuenta no habilitada";
                return usuarioNetvalle;
            }
        }
    }


    #endregion

    #endregion
}