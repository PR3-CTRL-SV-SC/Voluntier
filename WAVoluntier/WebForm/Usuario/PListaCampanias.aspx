<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PListaCampanias.aspx.cs" Inherits="WebForm_Usuario_PListaCampanias" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/SListaCampanias.css" rel="stylesheet" />
    <link href="../../Estilo/Usuario/SOrganizacionUsuario.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form" runat="server">
    <asp:ScriptManager ID="ContentPlaceHolder1_ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:Timer ID="timerControl" Enabled="true" Interval="30000" OnTick="timerControl_Tick" runat="server"></asp:Timer>
        <fieldset class="field">
            <div class="title">
                <label class="lblTitle">Listado de Campañas</label>
                <p class="cerrar">
                    <a class="link" href="PMenuEstudiante.aspx">X</a>
                </p>
            </div>
            <div id="div1" runat="server" class="containerLista">
                <fieldset>
                    <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>
                    <ul class="camp-list">
                        <asp:Repeater ID="rptCampañas" runat="server" >
                            <ItemTemplate>
                                <li class="camp-item">
                                    <span class="lblTituloCampania"><%# Eval("NombreCampania") %></span>
                                    <div class="lblDescripcion">
                                        <span><%# Eval("DescripcionCampania") %></span>
                                        <table class="containerFechas">
                                            <td class="fecha"><b>Fecha de Inicio:</b> <%# Eval("FechaInicioCampania", "{0:dd/MM/yyyy}") %></td>
                                            <td class="fecha"><b>Fecha de Cierre:</b> <%# Eval("FechaFinCampania", "{0:dd/MM/yyyy}") %></td>
                                        </table>
                                        <asp:Button ID="btnVer" CssClass="btnVer" runat="server" Text="Ver informacion" OnCommand="btnVer_Command" CommandArgument='<%# Eval("IdCampania")%>' />
                                    </div>
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </fieldset>
            </div>
        </fieldset>
    </form>
</asp:Content>
