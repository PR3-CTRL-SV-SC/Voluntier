using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

/// <summary>
/// Summary description for LNServicio
/// </summary>
public class LNServicio
{
    #region Propiedades
    public string NombreClase
    {
        get { return GetType().Name; }
    }
    #endregion
    #region Variables miembro
    private SWLNVoluntierClient sWLNVoluntier;
    #endregion

    #region Constructor
    public LNServicio()
    {
        sWLNVoluntier = new SWLNVoluntierClient();
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje, string stackTrace)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion,
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(TTipoDefecto tipoDefecto, string metodo, string excepcion, string mensaje)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = tipoDefecto,
            Servicio = SDatosGlobales.NOMBRE_APLICACION,
            Clase = NombreClase,
            Metodo = metodo,
            Mensaje = mensaje,
            Excepcion = excepcion
        };

        return eDefecto;
    }

    private EDefecto ConstruirDefecto(FaultException<EDefecto> ex)
    {
        EDefecto eDefecto = new EDefecto
        {
            TipoDefecto = ex.Detail.TipoDefecto,
            Servicio = ex.Detail.Servicio,
            Clase = ex.Detail.Clase,
            Metodo = ex.Detail.Metodo,
            Excepcion = ex.Detail.Excepcion,
            Mensaje = ex.Detail.Mensaje,
        };
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
            lstEcCampania = sWLNVoluntier.Obtener_CCampania_O().ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcCampania = sWLNVoluntierClient.Obtener_CCampania_O().ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CCampania_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcCampania;
    }

    public List<ECCampania> Obtener_CCampania_O_Sede(string Sede)
    {
        List<ECCampania> lstEcCampania = new List<ECCampania>();
        try
        {
            lstEcCampania = sWLNVoluntier.Obtener_CCampania_O_Sede(Sede).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_Sede", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcCampania = sWLNVoluntierClient.Obtener_CCampania_O_Sede(Sede).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_Sede", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CCampania_O_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcCampania;
    }

    public ECCampania Obtener_CCampania_O_IdCampania(int idCampania)
    {
        ECCampania ecCampania = new ECCampania();
        try
        {
            ecCampania = sWLNVoluntier.Obtener_CCampania_O_IdCampania(idCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    ecCampania = sWLNVoluntierClient.Obtener_CCampania_O_IdCampania(idCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CCampania_O_IdCampania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CCampania_O_IdCampania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return ecCampania;
    }

    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        try
        {
            sWLNVoluntier.Insertar_CCampania_I(eCCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CCampania_I", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Insertar_CCampania_I(eCCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CCampania_I", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_CCampania_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CCampania_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        try
        {
            sWLNVoluntier.Actualizar_CCampania_A(eCCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CCampania_A(eCCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CCampania_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_CCampania_A_Estado(int idCampania, string nuevoEstado)
    {
        try
        {
            sWLNVoluntier.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CCampania_A_Estado(idCampania, nuevoEstado);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CCampania_A_Estado", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(int idCampania)
    {
        try
        {
            sWLNVoluntier.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CCampania_A_Estado_Cancelado(idCampania);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CCampania_A_Estado_Cancelado", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CCampania_A_Estado_Cancelado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region CParticipacion
    public List<ECParticipacion> Obtener_CParticipacion_O()
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = sWLNVoluntier.Obtener_CParticipacion_O().ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcParticipacion = sWLNVoluntierClient.Obtener_CParticipacion_O().ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CParticipacion_O", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcParticipacion;
    }

    public void Insertar_CParticipacion_I(ECParticipacion eCParticipacion)
    {
        try
        {
            sWLNVoluntier.Insertar_CParticipacion_I(eCParticipacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CParticipacion_I", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Insertar_CParticipacion_I(eCParticipacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CParticipacion_I", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_CParticipacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CParticipacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion)
    {
        try
        {
            sWLNVoluntier.Actualizar_CParticipacion_A(eCParticipacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CParticipacion_A(eCParticipacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CParticipacion_A", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CParticipacion_A", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = sWLNVoluntier.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcParticipacion = sWLNVoluntierClient.Obtener_CParticipacion_O_PorUsuario(idUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CParticipacion_O_PorUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorUsuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcParticipacion;
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        List<ECParticipacion> lstEcParticipacion = new List<ECParticipacion>();
        try
        {
            lstEcParticipacion = sWLNVoluntier.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcParticipacion = sWLNVoluntierClient.Obtener_CParticipacion_O_PorCampania(idCampania).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CParticipacion_O_PorCampania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CParticipacion_O_PorCampania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
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
            lstEcSolicitudParticipacion = sWLNVoluntier.Obtener_CSolicitudes_O_Campania(idCampania).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcSolicitudParticipacion = sWLNVoluntierClient.Obtener_CSolicitudes_O_Campania(idCampania).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CSolicitudes_O_Campania", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Campania", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcSolicitudParticipacion;
    }

    public List<ECSolicitudParticipacion> Obtener_CSolicitudes_O_Usuario(string idUsuario)
    {
        List<ECSolicitudParticipacion> lstEcSolicitudParticipacion = new List<ECSolicitudParticipacion>();
        try
        {
            lstEcSolicitudParticipacion = sWLNVoluntier.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcSolicitudParticipacion = sWLNVoluntierClient.Obtener_CSolicitudes_O_Usuario(idUsuario).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CSolicitudes_O_Usuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CSolicitudes_O_Usuario", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcSolicitudParticipacion;
    }

    public void Insertar_CSolicitud_I(ECSolicitudParticipacion eCSolicitudParticipacion)
    {
        try
        {
            sWLNVoluntier.Insertar_CSolicitud_I(eCSolicitudParticipacion);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CSolicitud_I", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Insertar_CSolicitud_I(eCSolicitudParticipacion);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CSolicitudParticipacion_I", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_CSolicitudParticipacion_I", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CSolicitudParticipacion_I", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }

    public void Actualizar_CSolicitud_A_Estado(int idSolicitud, string nuevoEstado)
    {
        try
        {
            sWLNVoluntier.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CSolicitud_A_Estado(idSolicitud, nuevoEstado);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CSolicitud_A_Estado", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CSolicitud_A_Estado", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region CUsuario
    public ECUsuario Obtener_CUsuario_O_Codigo(string codigoUsuario)
    {
        ECUsuario eCUsuario = new ECUsuario();
        try
        {
            eCUsuario = sWLNVoluntier.Obtener_CUsuario_O_Codigo(codigoUsuario);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    eCUsuario = sWLNVoluntierClient.Obtener_CUsuario_O_Codigo(codigoUsuario);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CUsuario_O_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuario_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return eCUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = sWLNVoluntier.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcUsuario = sWLNVoluntierClient.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CUsuarios_O_Top_Horas", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Top_Horas", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        List<ECUsuario> lstEcUsuario = new List<ECUsuario>();
        try
        {
            lstEcUsuario = sWLNVoluntier.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    lstEcUsuario = sWLNVoluntierClient.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle).ToList();
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CUsuarios_O_Sede", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarios_O_Sede", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        return lstEcUsuario;
    }

    public void Actualizar_CUsuario_A_Horas_Codigo(string codigoUsuario, string horas)
    {
        try
        {
            sWLNVoluntier.Actualizar_CUsuario_A_Horas_Codigo(codigoUsuario, horas);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Actualizar_CUsuario_A_Horas_Codigo(codigoUsuario, horas);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Actualizar_CUsuario_A_Horas_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Actualizar_CUsuario_A_Horas_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
    }
    #endregion

    #region CUsuarioNetvalle
    public ECUsuarioNetvalle Obtener_CUsuarioNetvalle_O_Codigo(string codigoUsuarioNetvalle)
    {
        ECUsuarioNetvalle eCUsuarioNetvalle = new ECUsuarioNetvalle();
        try
        {
            eCUsuarioNetvalle = sWLNVoluntier.Obtener_CUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    eCUsuarioNetvalle = sWLNVoluntierClient.Obtener_CUsuarioNetvalle_O_Codigo(codigoUsuarioNetvalle);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_CUsuarioNetvalle_O_Codigo", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_CUsuarioNetvalle_O_Codigo", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
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
            sWLNVoluntier.Insertar_CUsuarioNetvalle_y_CUsuario(codigoUsuarioNetvalle, nombresUsuarioNetvalle, apellidosUsuarioNetvalle, cargoUsuarioNetvalle, sedeUsuarioNetvalle);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CUsuarioNetvalle_y_CUsuario", ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException comunicationExeption)
        {
            FaultException faultException = comunicationExeption as FaultException;
            if (faultException != null)
            {
                using (SWLNVoluntierClient sWLNVoluntierClient = new SWLNVoluntierClient())
                {
                    sWLNVoluntierClient.Insertar_CUsuarioNetvalle_y_CUsuario(codigoUsuarioNetvalle, nombresUsuarioNetvalle, apellidosUsuarioNetvalle, cargoUsuarioNetvalle, sedeUsuarioNetvalle);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CUsuarioNetvalle_y_CUsuario", comunicationExeption.Message, comunicationExeption.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Insertar_CUsuarioNetvalle_y_CUsuario", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Insertar_CUsuarioNetvalle_y_CUsuario", ex.Source, ex.Message);
        }
    }
    #endregion

    #region Cifrado y descifrado
    public string Descifrar_Cadena(string Texto, string Tipo)
    {
        string textoDescifrado = string.Empty;
        try
        {
            using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
            {
                textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
                {
                    textoDescifrado = sWLNServicioClient.Descifrado(Texto, Tipo);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Descifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoDescifrado;
    }

    public string Cifrar_Cadena(string TextoACifrar)
    {
        string textoCifrado = string.Empty;

        try
        {
            using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
            {
                textoCifrado = sWLNServicioClient.Cifrar_Cadena(TextoACifrar);
                //textoCifrado = sWLNServicioClient.Adicionar_VSolicitud()
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
                {
                    textoCifrado = sWLNServicioClient.Cifrar_Cadena(TextoACifrar);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", communicationException.ToString(), communicationException.Message, communicationException.StackTrace);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Cifrar_Cadena", ex.Source, ex.Message, ex.StackTrace);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return textoCifrado;
    }
    #endregion

    #region EEmpleado
    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        Tuple<EEmpleado, EMensajeError> result;
        try
        {
            using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
            {
                result = sWLNServicioClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
                {
                    result = sWLNServicioClient.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_Empleado_Id_Emp_SedeAcademica", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_Empleado_Id_Emp_SedeAcademica", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string Id_Emp, string SedeAcademica)
    {
        Tuple<byte[], EMensajeError> result;
        try
        {
            using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
            {
                result = sWLNServicioClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
            }
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(ConstruirDefecto(ex));
        }
        catch (EndpointNotFoundException ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (CommunicationException communicationException)
        {
            FaultException faultException = communicationException as FaultException;

            if (faultException == null)
            {
                using (SWLNVoluntierClient sWLNServicioClient = new SWLNVoluntierClient())
                {
                    result = sWLNServicioClient.Obtener_EmpleadoFotografia(Id_Emp, SedeAcademica);
                }
            }
            else
            {
                EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", communicationException.ToString(), communicationException.Message);
                throw new FaultException<EDefecto>(eDefecto);
            }
        }
        catch (ObjectDisposedException objectDisposedException)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Comunicacion, "Obtener_EmpleadoFotografia", objectDisposedException.ToString(), objectDisposedException.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }
        catch (Exception ex)
        {
            EDefecto eDefecto = ConstruirDefecto(TTipoDefecto.Falla, "Obtener_EmpleadoFotografia", ex.Source, ex.Message);
            throw new FaultException<EDefecto>(eDefecto);
        }

        return result;
    }

    #endregion
    #endregion

}