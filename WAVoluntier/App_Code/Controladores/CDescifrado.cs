using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

/// <summary>
/// Descripción breve de CDescifrado
/// </summary>
public class CDescifrado
{
    #region Propiedades
    private LNServicio lNServicio { get; set; }
    #endregion

    #region Constructor
    public CDescifrado()
    {
        lNServicio = new LNServicio();
    }
    #endregion

    #region Métodos Públicos

    public string Cifrar_Cadena(string texto)
    {
        string textoDescifrado;
        try
        {
            textoDescifrado = lNServicio.Cifrar_Cadena(texto);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(null);
        }
        return textoDescifrado;
    }

    public string Descifrar_Cadena(string texto, string tipo)
    {
        string textoDescifrado;
        try
        {
            textoDescifrado = lNServicio.Descifrar_Cadena(texto, tipo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw new FaultException<EDefecto>(null);
        }
        return textoDescifrado;
    }

    #endregion
}