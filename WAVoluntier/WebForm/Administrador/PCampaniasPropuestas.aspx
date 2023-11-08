<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampaniasPropuestas.aspx.cs" Inherits="WebForm_Administrador_PCampaniasPropuestas" MasterPageFile="~/PaginaMaestra/MPInicio.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SCampaniasPropuestas.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form" runat="server">
        <fieldset class="field">
            <div class="title">
                <label class="lblTitle">Campañas Propuestas</label>
                <p class="cerrar">
                    <a class="link" href="PGestionCampanias.aspx">X</a>
                </p>
            </div>
            <div id="divContenedor" runat="server" class="containerLista">
                <fieldset>
                    <legend>Lista de Campañas</legend>
                    <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>
                    <ul class="camp-list">
                        <asp:Repeater ID="rptCampañas" runat="server">
                            <ItemTemplate>
                                <li class="camp-item">
                                    <asp:Label ID="lblNombreCampania" runat="server" CssClass="lblTituloCampania" ><%# Eval("NombreCampania") %></asp:Label>
                                    <div class="lblDescripcion">
                                        <span><%# Eval("DescripcionCampania") %></span>
                                        <table class="containerFechas">
                                            <td class="fecha"><b>Fecha de Inicio:</b> <%# Eval("FechaInicioCampania", "{0:dd/MM/yyyy}") %></td>
                                            <td class="fecha"><b>Fecha de Cierre:</b> <%# Eval("FechaFinCampania", "{0:dd/MM/yyyy}") %></td>
                                        </table>
                                    </div>
                                    <asp:Button ID="btnAceptar" CssClass="btnOpciones" runat="server" Text="Aceptar" OnCommand="btnAceptar_Command" CommandArgument='<%# Eval("IdCampania") + "|" + Eval("NombreCampania") %>' />
                                    <asp:Button ID="btnRechazar" CssClass="btnOpciones" runat="server" Text="Rechazar" OnCommand="btnRechazar_Command" CommandArgument='<%# Eval("IdCampania") + "|" + Eval("NombreCampania") %>' />
                                </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </fieldset>
            </div>
            <%--Modal Aceptar--%>
            <div class="modal-container-notificacion" id="modalNotificacionContainerAceptar">
            <div class="modal-notificacion" id="modalNotificacionAceptar">
                <asp:ImageButton ID="btnCerrarAceptacion" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btnCerrarAceptacion_Click"></asp:ImageButton>
                <div class="contenedor">
                    <p class="LBLContenido centrar">¿ESTA SEGURO/A DE ACEPTAR ESTA CAMPAÑA?</p>
                    <p class="LBLContenido centrar">
                        <b><asp:Label ID="lblCampaniaAceptada" runat="server"></asp:Label></b>
                    </p>
                    <p class="lblAviso">Esta acción no se podrá revertir a futuro</p>
                    <div class="centrar">
                        <asp:Button ID="btnConfirmar" runat="server" CssClass="btnEliminar" Text="Confirmar" OnClick="btnConfirmar_Click"/>
                    </div>
                </div>
            </div>
        </div>
        <%--Modal Aceptar--%>
        <div class="modal-container-notificacion" id="modalNotificacionContainerRechazar">
            <div class="modal-notificacion" id="modalNotificacionRechazar">
                <asp:ImageButton ID="btnCerrarRechazo" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btnCerrarRechazo_Click"></asp:ImageButton>
                <div class="contenedor">
                    <p class="LBLContenido centrar">¿ESTA SEGURO/A DE RECHAZAR ESTA CAMPAÑA?</p>
                    <p class="LBLContenido centrar">
                        <b><asp:Label ID="lblCampaniaRechazada" runat="server"></asp:Label></b>
                    </p>
                    <p class="lblAviso">Esta acción no se podrá revertir a futuro</p>
                    <div class="centrar">
                        <asp:Button ID="btnNegar" runat="server" CssClass="btnEliminar" Text="Confirmar" OnClick="btnNegar_Click" />
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalPropuestaCampaña.js"></script>
        </fieldset>
    </form>
</asp:Content>
