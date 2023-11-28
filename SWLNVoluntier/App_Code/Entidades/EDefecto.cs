using System.Runtime.Serialization;

/// <summary>
/// Entodad de generacion de defectos
/// </summary>
public enum TTipoDefecto { Ninguno, Comunicacion, BaseDatos, Codificacion, Falla };
[DataContract]
public class EDefecto
{
    #region Atributos

    private string _Servicio;
    private string _Clase;
    private TTipoDefecto _TipoDefecto;
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
    public TTipoDefecto TipoDefecto
    {
        #region Propiedad de TipoError
        get { return _TipoDefecto; }
        set { _TipoDefecto = value; }
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
        _TipoDefecto = TTipoDefecto.Ninguno;
    }


    #endregion
}