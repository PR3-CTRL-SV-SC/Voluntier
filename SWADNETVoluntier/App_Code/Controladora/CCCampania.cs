using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCCampania
/// </summary>
public class CCCampania
{
    #region Metodos privados
    private ADCCampania adCCampania;
    #endregion
    #region Metodos publicos
    public CCCampania()
    {
        adCCampania = new ADCCampania();
    }

    public ECCampania Obtener_CCampania_O_Sede(string SedeCampania)
    {
        ECCampania eCCampania = new ECCampania();
        DTOCCampania dtoCCampania = adCCampania.Obtener_CCampania_O_Sede(SedeCampania);
        foreach (DTOCCampania.CCampaniaRow drCCampania in dtoCCampania.CCampania.Rows)
        {
            eCCampania.NombreCampania = drCCampania.NombreCampania.TrimEnd();
            eCCampania.DescripcionCampania = drCCampania.DescripcionCampania.TrimEnd();
            eCCampania.FechaInicioCampania = drCCampania.FechaInicioCampania;
            eCCampania.FechaFinCampania = drCCampania.FechaFinCampania;
            eCCampania.EstadoCampania = drCCampania.EstadoCampania.TrimEnd();
            eCCampania.SedeCampania = drCCampania.SedeCampania.ToString().TrimEnd();
            eCCampania.FechaRegistroCampania = drCCampania.FechaRegistroCampania;
            eCCampania.FechaModificacionCampania = drCCampania.FechaModificacionCampania;

        }
        return eCCampania;
    }

    public List<ECCampania> Obtener_CCampania_O()
    {
        ECCampania eCCampania;
        List<ECCampania> lstECCampania = new List<ECCampania>();
        DTOCCampania dtoCCampania = adCCampania.Obtener_CCampania_O();
        if (dtoCCampania != null)
        {
            foreach (DTOCCampania.CCampaniaRow drCCampania in dtoCCampania.CCampania.Rows)
            {
                eCCampania = new ECCampania();
                eCCampania.IdCampania = drCCampania.IdCampania;
                eCCampania.NombreCampania = drCCampania.NombreCampania.TrimEnd();
                eCCampania.DescripcionCampania = drCCampania.DescripcionCampania.TrimEnd();
                eCCampania.FechaInicioCampania = drCCampania.FechaInicioCampania;
                eCCampania.FechaFinCampania = drCCampania.FechaFinCampania;
                eCCampania.EstadoCampania = drCCampania.EstadoCampania.TrimEnd();
                eCCampania.SedeCampania = drCCampania.SedeCampania.ToString().TrimEnd();
                eCCampania.FechaRegistroCampania = drCCampania.FechaRegistroCampania;
                eCCampania.FechaModificacionCampania = drCCampania.FechaModificacionCampania;
                lstECCampania.Add(eCCampania);
            }
        }
        else
        {
            dtoCCampania = new DTOCCampania();
        }

        return lstECCampania;
    }

    public void Insertar_CCampania_I(ECCampania eCCampania)
    {
        adCCampania.Insertar_CCampania_I(eCCampania);
    }

    public void Actualizar_CCampania_A(ECCampania eCCampania)
    {
        adCCampania.Actualizar_CCampania_A(eCCampania);
    }

    public void Actualizar_CCampania_A_Estado(string IdCampania)
    {
        adCCampania.Actualizar_CCampania_A_Estado(IdCampania);
    }

    public void Actualizar_CCampania_A_Estado_Cancelado(string IdCampania)
    {
        adCCampania.Actualizar_CCampania_A_Estado_Cancelado(IdCampania);
    }
    #endregion
}