using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CCParticipacion
/// </summary>
public class CCParticipacion
{
    #region Metodos privados
    private ADCParticipacion adCParticipacion;
    #endregion
    #region Metodos publicos
    public CCParticipacion()
    {
        adCParticipacion = new ADCParticipacion();
    }

    public List<ECParticipacion> Obtener_CParticipacion_O()
    {
        DTOCParticipacion dtoCParticipacion = adCParticipacion.Obtener_CParticipacion_O();
        List<ECParticipacion> participaciones = new List<ECParticipacion>();

        foreach (DTOCParticipacion.CParticipacionRow drParticipacion in dtoCParticipacion.CParticipacion.Rows)
        {
            ECParticipacion eCParticipacion = new ECParticipacion();
            eCParticipacion.IdParticipacion = drParticipacion.IdParticipacion;
            eCParticipacion.IdCampaniaParticipacion = drParticipacion.IdCampaniaParticipacion;
            eCParticipacion.IdUsuarioParticipacion = drParticipacion.IdUsuarioParticipacion;
            eCParticipacion.FechaRegistroParticipacion = drParticipacion.FechaRegistroParticipacion;
            eCParticipacion.FechaModificacionParticipacion = drParticipacion.FechaModificacionParticipacion;
            eCParticipacion.EstadoParticipacion = drParticipacion.EstadoParticipacion;
            eCParticipacion.HorasParticipacion = drParticipacion.HorasParticipacion;

            participaciones.Add(eCParticipacion);
        }

        return participaciones;
    }



    public void Insertar_CParticipacion_I(ECParticipacion eCParticipacion)
    {
        adCParticipacion.Insertar_CParticipacion_I(eCParticipacion);
    }

    public void Actualizar_CParticipacion_A(ECParticipacion eCParticipacion)
    {
        adCParticipacion.Actualizar_CParticipacion_A(eCParticipacion);
    }

    public List<ECParticipacion> Obtener_CParticipacion_O_PorUsuario(string idUsuario)
    {
        DTOCParticipacion dtoCParticipacion = adCParticipacion.Obtener_CParticipacion_O_PorUsuario(idUsuario);
        List<ECParticipacion> participaciones = new List<ECParticipacion>();

        foreach (DTOCParticipacion.CParticipacionRow drParticipacion in dtoCParticipacion.CParticipacion.Rows)
        {
            ECParticipacion eCParticipacion = new ECParticipacion();
            eCParticipacion.IdParticipacion = drParticipacion.IdParticipacion;
            eCParticipacion.IdCampaniaParticipacion = drParticipacion.IdCampaniaParticipacion;
            eCParticipacion.IdUsuarioParticipacion = drParticipacion.IdUsuarioParticipacion;
            eCParticipacion.FechaRegistroParticipacion = drParticipacion.FechaRegistroParticipacion;
            eCParticipacion.FechaModificacionParticipacion = drParticipacion.FechaModificacionParticipacion;
            eCParticipacion.EstadoParticipacion = drParticipacion.EstadoParticipacion;
            eCParticipacion.HorasParticipacion = drParticipacion.HorasParticipacion;

            participaciones.Add(eCParticipacion);
        }

        return participaciones;
    }
    public List<ECParticipacion> Obtener_CParticipacion_O_PorCampania(int idCampania)
    {
        DTOCParticipacion dtoCParticipacion = adCParticipacion.Obtener_CParticipacion_O_PorCampania(idCampania);
        List<ECParticipacion> participaciones = new List<ECParticipacion>();

        foreach (DTOCParticipacion.CParticipacionRow drParticipacion in dtoCParticipacion.CParticipacion.Rows)
        {
            ECParticipacion eCParticipacion = new ECParticipacion();
            eCParticipacion.IdParticipacion = drParticipacion.IdParticipacion;
            eCParticipacion.IdCampaniaParticipacion = drParticipacion.IdCampaniaParticipacion;
            eCParticipacion.IdUsuarioParticipacion = drParticipacion.IdUsuarioParticipacion;
            eCParticipacion.FechaRegistroParticipacion = drParticipacion.FechaRegistroParticipacion;
            eCParticipacion.FechaModificacionParticipacion = drParticipacion.FechaModificacionParticipacion;
            eCParticipacion.EstadoParticipacion = drParticipacion.EstadoParticipacion;
            eCParticipacion.HorasParticipacion = drParticipacion.HorasParticipacion;

            participaciones.Add(eCParticipacion);
        }

        return participaciones;
    }

    #endregion
}