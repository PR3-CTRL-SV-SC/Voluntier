using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SDatosGlobales
/// </summary>
public static class SDatosGlobales
{
    #region Estados

    /// <summary>
    /// Códigos de estados utilizados dentro del sistema
    /// </summary>
    /// 
    public const string NOMBRE_APLICACION = "PROYECTO CONTROL SERVICIO SOCIAL";

    public const string HABILITADO = "H";
    public const string DESHABILITADO = "I";
    public const string ELIMINAR = "E";
    public const string NOMBRE_HABILITADO = "Habilitar";
    public const string NOMBRE_DESHABILITADO = "Inhabilitar";
    public const string NOMBRE_ELIMINAR = "Eliminar";

    #endregion


    #region Manejo de fechas

    /// <summary>
    /// Fecha null de tipo string y DateTime
    /// </summary>
    public static readonly DateTime DATETIME_NULL = new DateTime(1980, 1, 1, 0, 0, 0);
    public const string FECHA_NULL = "01/01/1980 00:00";

    #endregion

    #region Opciones de bitacora

    /// <summary>
    /// Opciones para el registro de bitacoras del sistema
    /// </summary>
    public const string BITACORA_REGISTRO = "R";
    public const string BITACORA_ACTUALIZAR = "A";
    public const string BITACORA_ELIMINAR = "E";
    public const string BITACORA_HABILITAR = "H";
    public const string BITACORA_REPORTE = "I";

    #endregion

    #region Mensajes del sistema

    /// <summary>
    /// Mensaje por defecto a utilizado en caso de error
    /// </summary>
    public const string MENSAJE_ATENCION = "Ha ocurrido una operación interna inesperada, vuelva a intentarlo más tarde por favor.";

    #endregion

    #region Paginación

    public static readonly int PAGINACION_TAMANOPAGINA = 15;
    public static readonly int PAGINACION_NUM_PAGINAS = 10;
    public static readonly string TIPO_ORDEN_ASC = "ASC";
    public static readonly string TIPO_ORDEN_DESC = "DESC";

    #endregion



    #region Valores SI NO

    public static readonly string SI = "S";
    public static readonly string NO = "N";

    #endregion

    #region Estados Solicitud

    public static readonly string APROBADO = "AP";

    public static readonly string PENDIENTE = "PE";

    public static readonly string RECHAZADO = "RE";

    public static readonly string CANCELADO = "CA";

    #endregion


    #region Archivos

    public static readonly string EXTENSION_PDF = "pdf";

    public static readonly string NOMBREARCHIVO = "Formulario de solicitud de vacaciones";

    #endregion
}