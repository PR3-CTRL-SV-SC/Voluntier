<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PMenuEstudiante.aspx.cs" Inherits="PMenuEstudiante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/General/SMenu.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%" align="center">
                <tr>
                    <td>
                        <fieldset style="width: 98%" align="center">
                            <legend style="text-align: left"></legend>
                            <table width="100%">
                                <tr id="ContentPlaceHolder1_CURecursosEstudiante_TRMenu">
                                    <td style="width: 45%; vertical-align: top">
                                        <fieldset>
                                            <legend style="text-align: left">
                                                <span id="LBLLengend" class="cssLegend">Opciones</span>
                                            </legend>
                                            <div id="tblLinks" runat="server">
                                                <table cellpadding="0" cellspacing="0" style="border-width: 0;" runat="server">
                                                    <tr class="LBLContenido">
                                                        <td class="LBLContenido">
                                                            <a href="../Usuario/PListaCampanias.aspx" class="Opcion">Campañas disponibles                                              
                                                            <h8 id="H1" runat="server">
                                                                <b>
                                                                    <font color='red'>- Nuevo</font>
                                                                </b>
                                                            </h8>
                                                            </a>
                                                        </td>
                                                    </tr>
                                                    <tr class="LBLContenido">
                                                        <td class="LBLContenido">
                                                            <a href="../Usuario/PMisCampanias.aspx" class="Opcion">Mis solicitudes                                                
                                                            <h8 id="H2" runat="server">
                                                                <b>
                                                                    <font color='red'>- Nuevo</font>
                                                                </b>
                                                            </h8>
                                                            </a>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </div>
                                        </fieldset>
                                    </td>
                                    <td style="width: 70%; height: 100%; vertical-align: top"></td>
                                </tr>
                                <tr>
                                    <td style="width: 100%; vertical-align: top" colspan="2"></td>
                                </tr>
                            </table>
                        </fieldset>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>


