using SWLNVoluntier;
using System;
using System.ServiceModel;

/// <summary>
/// Descripción breve de CAutenticar
/// </summary>
public class CAutenticar
{
    #region Atributos

    private LNServicio lNServicio;

    private EUsuarioSesion eUsuarioSesion;

    #endregion

    #region Propiedades

    public string NombreClase
    {
        get { return GetType().Name; }
    }

    public EUsuarioSesion UsuarioSesion
    {
        set { eUsuarioSesion = value; }
    }

    #endregion

    #region Constructor

    public CAutenticar()
    {
        lNServicio = new LNServicio();
        eUsuarioSesion = null;
    }

    public CAutenticar(EUsuarioSesion eUsuarioSesion)
    {
        lNServicio = new LNServicio();
        this.eUsuarioSesion = eUsuarioSesion;
    }

    #endregion

    #region Metodos publico

    #region EEmpleado

    public Tuple<EEmpleado, EMensajeError> Obtener_Empleado_Id_Emp_SedeAcademica(string Id_Emp, string SedeAcademica)
    {
        try
        {
            return lNServicio.Obtener_Empleado_Id_Emp_SedeAcademica(Id_Emp, SedeAcademica);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    public Tuple<byte[], EMensajeError> Obtener_EmpleadoFotografia(string CuentaEmpleado, string SedeAcademica)
    {
        try
        {
            return lNServicio.Obtener_EmpleadoFotografia(CuentaEmpleado, SedeAcademica);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
    }

    #endregion

    #endregion
}