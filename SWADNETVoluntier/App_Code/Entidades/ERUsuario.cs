using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

/// <summary>
/// Descripción breve de ERUsuario
/// </summary>
[DataContract]
public class ERUsuario
{
    #region Atributos
    [DataMember]
    public string CodigoUsuario { get; set; }
    [DataMember]
    public string CreditosUsuario { get; set; }
    [DataMember]
    public string RolUsuario { get; set; }
    #endregion

    public ERUsuario()
    {
        CodigoUsuario = string.Empty;
        CreditosUsuario = string.Empty;
        RolUsuario = string.Empty;
    }
}