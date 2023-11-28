using System;

/// <summary>
/// Entodad de generacion de defectos
/// </summary>
/// 
public enum TTipoDefecto { Ninguno, Comunicacion, BaseDatos, Codificacion, Falla };
public class EDefecto
{
    #region Atributos

    private string _Servicio;
    private TTipoDefecto _TipoDefecto;

    public TTipoDefecto TipoDefecto
    {
        #region Propiedad de TipoError
        get { return _TipoDefecto; }
        set { _TipoDefecto = value; }
        #endregion

    }
    public string Servicio
    {
        get { return _Servicio; }
        set { _Servicio = value; }
    }

    private string _Clase;
    public string Clase
    {
        get { return _Clase; }
        set { _Clase = value; }
    }

    private Type _TipoError;
    public Type TipoError
    {
        get { return _TipoError; }
        set { _TipoError = value; }
    }
    private string _Metodo;
    public string Metodo
    {
        get { return _Metodo; }
        set { _Metodo = value; }
    }
    private string _Excepcion;
    public string Excepcion
    {
        get { return _Excepcion; }
        set { _Excepcion = value; }
    }
    private string _Mensaje;
    public string Mensaje
    {
        get { return _Mensaje; }
        set { _Mensaje = value; }
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
    }
    #endregion
}