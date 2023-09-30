using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ECUsuario
/// </summary>
[DataContract]
public class ECUsuario
{
    #region Atributos
    [DataMember]
    public string IdUsuario { get; set; }
    [DataMember]
    public string RolUsuario { get; set; }
    #endregion

    public ECUsuario()
    {
        IdUsuario = string.Empty;
        RolUsuario = string.Empty;
    }
}