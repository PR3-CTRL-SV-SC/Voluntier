using System.Collections.Generic;

/// <summary>
/// Summary description for CCUsuario
/// </summary>
public class CCUsuario
{
    #region Metodos privados
    private ADCUsuario adCUsuario;
    #endregion
    #region Metodos publicos
    public CCUsuario()
    {
        adCUsuario = new ADCUsuario();
    }

    public ECUsuario Obtener_CUsuario_O_Codigo(string CodigoUsuario)
    {
        ECUsuario eCUsuario = new ECUsuario();
        DTOCUsuario dtoCUsuario = adCUsuario.Obtener_CUsuario_O_Codigo(CodigoUsuario);
        foreach (DTOCUsuario.CUsuarioRow drCUsuario in dtoCUsuario.CUsuario.Rows)
        {
            eCUsuario = new ECUsuario();
            eCUsuario.CodigoUsuario = drCUsuario.CodigoUsuario.ToString().TrimEnd();
            eCUsuario.HorasUsuario = drCUsuario.HorasUsuario;
            eCUsuario.RolUsuario = drCUsuario.RolUsuario.ToString().TrimEnd();
            ///eCUsuario.RolUsuario = drCUsuario.RolUsuario.ToString().TrimEnd();
        }
        return eCUsuario;
    }

    public List<ECUsuario> Obtener_CUsuarios_O_Top_Horas(string sedeUsuarioNetvalle)
    {
        ECUsuario eCUsuario = new ECUsuario();
        List<ECUsuario> lsteCUsuario = new List<ECUsuario>();
        DTOCUsuario dtoCUsuario = adCUsuario.Obtener_CUsuarios_O_Top_Horas(sedeUsuarioNetvalle);
        foreach (DTOCUsuario.CUsuarioRow drCUsuario in dtoCUsuario.CUsuario.Rows)
        {
            eCUsuario = new ECUsuario();
            eCUsuario.CodigoUsuario = drCUsuario.CodigoUsuario.ToString().TrimEnd();
            eCUsuario.HorasUsuario = drCUsuario.HorasUsuario;
            eCUsuario.RolUsuario = drCUsuario.RolUsuario.ToString().TrimEnd();
            //eCUsuario.RolUsuario = drCUsuario.RolUsuario.ToString().TrimEnd();
            lsteCUsuario.Add(eCUsuario);
        }
        return lsteCUsuario;
    }
    public List<ECUsuario> Obtener_CUsuarios_O_Sede(string sedeUsuarioNetvalle)
    {
        ECUsuario eCUsuario = new ECUsuario();
        List<ECUsuario> lsteCUsuario = new List<ECUsuario>();
        DTOCUsuario dtoCUsuario = adCUsuario.Obtener_CUsuarios_O_Sede(sedeUsuarioNetvalle);
        foreach (DTOCUsuario.CUsuarioRow drCUsuario in dtoCUsuario.CUsuario.Rows)
        {
            eCUsuario = new ECUsuario();
            eCUsuario.CodigoUsuario = drCUsuario.CodigoUsuario.ToString().TrimEnd();
            eCUsuario.HorasUsuario = drCUsuario.HorasUsuario;
            lsteCUsuario.Add(eCUsuario);
        }
        return lsteCUsuario;
    }

    public void Actualizar_CUsuario_A_Horas_Codigo(string Codigo, string Horas)
    {
        adCUsuario.Actualizar_CUsuario_A_Horas_Codigo(Codigo, Horas);
    }
    #endregion
}