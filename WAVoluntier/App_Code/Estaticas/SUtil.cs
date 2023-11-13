using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using SWLNVoluntier;

/// <summary>
/// Summary description for SUtil
/// </summary>
public static class SUtil
{
    #region Metodos publicos
    public static bool ValidacionesTextBox(string texto)
    {
        bool ver = true;
        if (texto.Trim().Length == 0)
            return false;
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i].ToString() == "|" || texto[i].ToString() == "-") ver = false;
        }
        if (texto[texto.Length - 1].ToString() == "_") ver = false;
        return ver;
    }

    public static string TransformarEstados(string estado)
    {
        string result = "";
        switch (estado.ToUpper())
        {
            case "PE":
                result = "PENDIENTE";
                break;
            case "AP":
                result = "APROBADA";
                break;
            case "EC":
                result = "EN CURSO";
                break;
            case "FN":
                result = "FINALIZADA";
                break;
            case "RE":
                result = "RECHAZADA";
                break;

            default:
                result = "CANCELADA";
                break;
        }
        return result;
    }

    public static string ObtenerNombreCompleto(EEmpleado eEmpleado)
    {
        if (eEmpleado != null)
        {
            List<string> datos = new List<string> {
                    eEmpleado.PrimerNombre.ToLower(),
                    eEmpleado.SegundoNombre.ToLower(),
                    eEmpleado.PrimerApellido.ToLower(),
                    eEmpleado.SegundoApellido.ToLower(),
                };
            List<string> datosNombre = new List<string>();
            foreach (string palabras in datos)
            {
                foreach (string palabra in palabras.Split(' '))
                {
                    if (palabra.Length > 1)
                    {
                        datosNombre.Add(palabra[0].ToString().ToUpper() + palabra.Substring(1));
                    }
                    else
                    {
                        datosNombre.Add(palabra.ToUpper());
                    }
                }
            }

            return string.Join(" ", datosNombre.FindAll(c => !string.IsNullOrEmpty(c)));
        }
        else
        {
            throw new ArgumentNullException();
        }
    }

    public static string ConvertirFechas(string diaOMes)
    {
        string nuevoDiaMes = diaOMes;
        if (nuevoDiaMes.Length == 1)
        {
            nuevoDiaMes = "0" + diaOMes;
        }
        return nuevoDiaMes;
    }

    public static bool validacionImage(FileUpload fluImage)
    {
        bool res = false;
        if (fluImage.HasFile)
        {
            string nombreArchivo = System.IO.Path.GetFileName(fluImage.PostedFile.FileName);
            string validacionImage = nombreArchivo[nombreArchivo.Length - 3].ToString() + nombreArchivo[nombreArchivo.Length - 2].ToString() + nombreArchivo[nombreArchivo.Length - 1].ToString();
            if (validacionImage == "png")
            {
                res = true;
            }
        }
        return res;
    }
    #endregion

    #region Métodos de Sesión
    public static void BorrarSesiones(HttpSessionState Session)
    {
        Session["UsuarioSesion"] = null;
        Session.Remove("UsuarioSesion");
        Session["Verificar"] = null;
        Session.Remove("Verificar");
        Session["CAutenticar"] = null;
        Session.Remove("CAutenticar");
        Session["CSolicitud"] = null;
        Session.Remove("CSolicitud");
        Session["CListaSolicitud"] = null;
        Session.Remove("CListaSolicitud");
        Session["CArchivo"] = null;
        Session.Remove("CArchivo");
        Session["CInicio"] = null;
        Session.Remove("CInicio");
        Session["ErrorPerfil"] = null;
        Session.Remove("ErrorPerfil");
        Session["ArchivoSolicitud"] = null;
        Session.Remove("ArchivoSolicitud");
        Session["CArchivo"] = null;
        Session.Remove("CArchivo");

        Session.RemoveAll();
        Session.Clear();
    }
    #endregion
}