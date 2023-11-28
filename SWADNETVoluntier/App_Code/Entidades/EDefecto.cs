using System;
using System.Runtime.Serialization;
using System.ServiceModel;

/// <summary>
/// Summary description for EDefecto
/// </summary>

public enum TTipoError { Ninguno, Comunicacion, BaseDatos, Codificacion, Falla };

[DataContract]
public class EDefecto
{
    #region Atributos

    private string _Servicio;
    private string _Clase;
    private TTipoError _TipoError;
    private string _Metodo;
    private string _Excepcion;
    private string _Mensaje;



    #endregion


    #region Propiedades
    [DataMember]
    public string Servicio
    {
        #region Propiedad de Servicio
        get { return _Servicio; }
        set { _Servicio = value; }
        #endregion

    }

    [DataMember]
    public string Clase
    {
        #region Propiedad de Clase
        get { return _Clase; }
        set { _Clase = value; }
        #endregion

    }

    [DataMember]
    public TTipoError TipoError
    {
        #region Propiedad de TipoError
        get { return _TipoError; }
        set { _TipoError = value; }
        #endregion

    }
    [DataMember]
    public string Metodo
    {
        #region Propiedad de Metodo
        get { return _Metodo; }
        set { _Metodo = value; }
        #endregion

    }
    [DataMember]
    public string Excepcion
    {
        #region Propiedad de Excepcion
        get { return _Excepcion; }
        set { _Excepcion = value; }
        #endregion

    }
    [DataMember]
    public string Mensaje
    {
        #region Propiedad de Mensaje
        get { return _Mensaje; }
        set { _Mensaje = value; }
        #endregion

    }
    #endregion


    #region Contructor
    public EDefecto()
    {
        _Servicio = string.Empty;
        _Clase = string.Empty;
        _Metodo = string.Empty;
        _Excepcion = string.Empty;
        _Mensaje = string.Empty;
        _TipoError = TTipoError.Ninguno;
    }

    public EDefecto(Exception e, string clase, string metodo)
    {
        if (e is FaultException<EDefecto>)
        {
            FaultException<EDefecto> aux = e as FaultException<EDefecto>;
            Excepcion = aux.Detail.Excepcion;
            TipoError = aux.Detail.TipoError;
            Servicio = aux.Detail.Servicio;
            Clase = aux.Detail.Clase;
            Metodo = aux.Detail.Metodo;
            Mensaje = aux.Detail.Mensaje;
        }
        else
        {

            Excepcion = e.ToString();
            TipoError = TTipoError.Falla;
            Servicio = "SWLNInfraescructura";
            Clase = clase;
            Metodo = metodo;
            Mensaje = e.Message;
        }
    }



    #endregion
}