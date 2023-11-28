using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de EEmpleado
/// </summary>
/// 
[DataContract]
public class EEmpleado
{
    #region Propiedades
    [DataMember]
    public string CodigoEmpleado { get; set; }
    [DataMember]
    public string CuentaEmpleado { get; set; }
    [DataMember]
    public string TelefonoMovil { get; set; }
    [DataMember]
    public string TelefonoFijo { get; set; }
    [DataMember]
    public string CorreoPersonal { get; set; }
    [DataMember]
    public string PrimerNombre { get; set; }
    [DataMember]
    public string SegundoNombre { get; set; }
    [DataMember]
    public string PrimerApellido { get; set; }
    [DataMember]
    public string SegundoApellido { get; set; }
    [DataMember]
    public string CorreoElectronico { get; set; }
    [DataMember]
    public string NombreSedeAcademica { get; set; }
    [DataMember]
    public string Cargo { get; set; }
    [DataMember]
    public string Departamento { get; set; }
    [DataMember]
    public string SedeAcademica { get; set; }
    [DataMember]
    public string Id_Departamento { get; set; }
    [DataMember]
    public string Oficina { get; set; }
    [DataMember]
    public string Sexo { get; set; }

    #endregion

    #region Constructor

    public EEmpleado()
    {

    }

    #endregion
}