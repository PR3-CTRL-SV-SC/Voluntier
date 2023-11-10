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
        swADNETVoluntier = new SWADNETVoluntierClient();
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

    #region Metodos publicos
    #region CCampania

    public List<ECCampania> Obtener_CCampania_O()
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = swADNETVoluntier.Obtener_CCampania_O().ToList();
        }
        catch (EndpointNotFoundException EndPointEx)
        {
            EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O", EndPointEx.ToString(), EndPointEx.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException CommEx)
        {
            FaultException feaultEx = CommEx as FaultException;
            if (feaultEx == null)
            {
                lstEcCampania = swADNETVoluntier.Obtener_CCampania_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcCampania;
    }

    public ECCampania Obtener_CCampania_O_IdCampania(int idCampania)
    {

        ECCampania ecCampania = new ECCampania();
        try
        {
            ecCampania = swADNETVoluntier.Obtener_CCampania_O_IdCampania(idCampania);
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
                ecCampania = swADNETVoluntier.Obtener_CCampania_O_IdCampania(idCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return ecCampania;
    }

    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        try
        {
            swADNETVoluntier.Insertar_CCampania_I(eCCampania);
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
                swADNETVoluntier.Insertar_CCampania_I(eCCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CCampania_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        try
        {
            swADNETVoluntier.Actualizar_CCampania_A(eCCampania);
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
                swADNETVoluntier.Actualizar_CCampania_A(eCCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_CCampania_A_Estado(int idCampania, string nuevoEstado)
    {
        try
        {
            swADNETVoluntier.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
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
                swADNETVoluntier.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(int idCampania)
    {
        try
        {
            swADNETVoluntier.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
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
                swADNETVoluntier.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public List<ECCampania> Obtener_CCampania_O_Sede(string sedeCampania)
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = swADNETVoluntier.Obtener_CCampania_O_Sede(sedeCampania).ToList();
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
                lstEcCampania = swADNETVoluntier.Obtener_CCampania_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CCampania_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
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
            lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O().ToList();
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
                lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O().ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcParticipacion;
    }

    public void Insertar_CParticipacion_I(ECParticipacion eCParticipacion)
    {
        try
        {
            swADNETVoluntier.Insertar_CParticipacion_I(eCParticipacion);
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
                swADNETVoluntier.Insertar_CParticipacion_I(eCParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CParticipacion_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion)
    {
        try
        {
            swADNETVoluntier.Actualizar_CParticipacion_A(eCParticipacion);
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
                swADNETVoluntier.Actualizar_CParticipacion_A(eCParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();
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
                lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();
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
                lstEcParticipacion = swADNETVoluntier.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcParticipacion;
    }

    #endregion
    #region CSolicitudParticipacion

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Campania(int idCampania)
    {
        List<ECSolicitudParticipacion> lstEcSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitudParticipacion = swADNETVoluntier.Obtener_CSolicitudes_O_Campania(idCampania).ToList();
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
                lstEcSolicitudParticipacion = swADNETVoluntier.Obtener_CSolicitudes_O_Campania(idCampania).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcSolicitudParticipacion;
    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        List<ECSolicitudParticipacion> lstEcSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitudParticipacion = swADNETVoluntier.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();
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
                lstEcSolicitudParticipacion = swADNETVoluntier.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcSolicitudParticipacion;
    }

    public void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion)
    {
        try
        {
            swADNETVoluntier.Insertar_CSolicitud_I(eCSolicitudParticipacion);
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
                swADNETVoluntier.Insertar_CSolicitud_I(eCSolicitudParticipacion);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Insertar_CSolicitud_I", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        try
        {
            swADNETVoluntier.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
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
                swADNETVoluntier.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    #endregion
    #region CUsuario

    public ECUsuario Obtener_CUsuario_O_Codigo(string CodigoUsuario)
    {
        ECUsuario eCUsuario = new ECUsuario();
        try
        {
            eCUsuario = swADNETVoluntier.Obtener_CUsuario_O_Codigo(CodigoUsuario);
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
                eCUsuario = swADNETVoluntier.Obtener_CUsuario_O_Codigo(CodigoUsuario);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return eCUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = swADNETVoluntier.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();
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
                lstEcUsuario = swADNETVoluntier.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = swADNETVoluntier.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();
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
                lstEcUsuario = swADNETVoluntier.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
        return lstEcUsuario;
    }

    public void Actualizar_CUsuario_A_Horas_Codigo(string Codigo, int Horas)
    {
        try
        {
            swADNETVoluntier.Actualizar_CUsuario_A_Horas_Codigo(Codigo, Horas);
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
                swADNETVoluntier.Actualizar_CUsuario_A_Horas_Codigo(Codigo, Horas);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

        }
    }

    #endregion
    #region CUsuarioNetvalle

    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string CodigoUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        try
        {
            eCUsuarioNetvalle = swADNETVoluntier.Obtener_CUsuarioNetvalle_O_Codigo(CodigoUsuarioNetvalle);
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
                eCUsuarioNetvalle = swADNETVoluntier.Obtener_CUsuarioNetvalle_O_Codigo(CodigoUsuarioNetvalle);
            }
            else
            {
                EDefecto eDefecto = ContruirErrorServicio(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", CommEx.ToString(), CommEx.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }

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
        try
        {
            swADNETVoluntier.Insertar_CUsuarioNetvalle_y_CUsuario(
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
                swADNETVoluntier.Insertar_CUsuarioNetvalle_y_CUsuario(
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
            }

        }
    }

    #endregion

    #endregion
}