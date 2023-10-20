using SWLNVoluntier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EUsuarioSesion
/// </summary>
public class EUsuarioSesion
{
    #region Propiedades

    public string IDEmpleado { get; set; }

    public string Cuenta { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public byte[] Fotografia { get; set; }

    public string NombreCompleto { get; set; }

    public string TelefonoMovil { get; set; }

    public string TelefonoFijo { get; set; }

    public string CorreoPersonal { get; set; }

    public string CorreoInstitucional { get; set; }

    public string SedeAcademica { get; set; }

    public string Id_SedeAcademica { get; set; }

    public string Cargo { get; set; }

    public string Departamento { get; set; }

    public string IDDepartamento { get; set; }

    public string Oficina { get; set; }

    public string Sexo { get; set; }

    #endregion

    #region Constructor

    public EUsuarioSesion(EEmpleado eEmpleado, byte[] fotografia)
    {
        if (eEmpleado != null)
        {
            IDEmpleado = eEmpleado.CodigoEmpleado;
            CorreoInstitucional = eEmpleado.CorreoElectronico;
            CorreoPersonal = eEmpleado.CorreoPersonal;
            Cuenta = eEmpleado.CuentaEmpleado;
            NombreCompleto = SUtil.ObtenerNombreCompleto(eEmpleado);
            TelefonoFijo = eEmpleado.TelefonoFijo;
            TelefonoMovil = eEmpleado.TelefonoMovil;
            Fotografia = fotografia;

            Id_SedeAcademica = eEmpleado.SedeAcademica;
            IDDepartamento = eEmpleado.Id_Departamento;
            SedeAcademica = eEmpleado.NombreSedeAcademica;
            Cargo = eEmpleado.Cargo;
            Departamento = eEmpleado.Departamento;
            Oficina = eEmpleado.Oficina;
            Sexo = eEmpleado.Sexo;
        }
        else
        {
            throw new ArgumentNullException();
        }
    }

    #endregion
}