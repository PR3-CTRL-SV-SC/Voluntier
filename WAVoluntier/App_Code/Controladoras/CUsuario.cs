using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Text.RegularExpressions;
using System.ServiceModel;
using SWLNVoluntier;

/// <summary>
/// Summary description for CCampania
/// </summary>
public class CUsuario : System.Web.UI.Page
{
    LNServicio lnServicio = new LNServicio();
    public CUsuario()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #region Metodos publicos

    #region LNServicio

    
    public ECUsuario Obtener_RUsuario_O_Codigo_CU(string Codigo)
    {
        ECUsuario erUsuario = new ECUsuario();
        try
        {
            erUsuario = lnServicio.Obtener_CUsuario_O_Codigo(Codigo);
        }
        catch (FaultException<EDefecto> ex)
        {
            throw ex;
        }
        return erUsuario;

    }
    
    #endregion

    #endregion
}