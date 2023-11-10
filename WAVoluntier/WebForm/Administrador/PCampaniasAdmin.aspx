<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampaniasAdmin.aspx.cs" Inherits="WebForm_Administrador_PCampaniasAdmin" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SCampaniasAdmin.css" rel="stylesheet" />

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset class="field">
            <div class="title">
                <asp:Label ID="lblTitulo" runat="server" CssClass="lblTitle"></asp:Label>
                <p class="cerrar">
                    <a class="link" href="PGestionCampanias.aspx">X</a>
                </p>
            </div>
            <div class="container">
                <div class="estado">
                    <asp:Label ID="lblEstado" runat="server" CssClass="lblEstado" Text="PENDIENTE"></asp:Label>
                </div>
                <table class="tablaDatos">
                    <tr class="filaTitulos">
                        <td class="tituloTabla">DESCRIPCION</td>
                        <td class="tituloTabla">FECHAS</td>
                    </tr>
                    <tr>
                        <td class="descripcion">
                            <asp:Label ID="lblDescripcion" runat="server" CssClass="lblDescripcion"></asp:Label>

                        </td>
                        <td class="fechas">
                            <label><b>Fecha de Inicio:</b></label>
                            <asp:Label ID="lblFechaInicio" runat="server" CssClass="fecha"><%# Eval("FechaInicio", "{0:dd/MM/yyyy}") %></asp:Label>
                            <br />
                            <br />
                            <label><b>Fecha de Cierre:</b></label>
                            <asp:Label ID="lblFechaCierre" runat="server" CssClass="fecha"><%# Eval("FechaCierre", "{0:dd/MM/yyyy}") %></asp:Label>
                        </td>
                    </tr>
                </table>
                <fieldset>
                    <legend>Lista de solicitudes</legend>
                    <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>
                    <table ID="tbSolicitudes" class="tablaSolicitudes">
                        <thead>
                            <tr class="filaTitulos">
                                <th class="tituloTabla">
                                    ESTUDIANTE
                                </th>
                                <th class="tituloTabla">
                                    ACCIONES
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                        <asp:Repeater ID="rptSolicitudes" runat="server">
                            <ItemTemplate>
                                <tr class="datosSolicitud">
                                    <td class="nombreSolicitud"><%# Eval("NombreCompleto") %></td>
                                    <td class="acciones">
                                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnCommand="btnAceptar_Command" CommandArgument='<%# Eval("IdUsuarioSolicitud") + "|" + Eval("IdSolicitud") %>' CssClass="btnAceptar" />
                                        <asp:Button ID="btnDenegar" runat="server" Text="Denegar" OnCommand="btnDenegar_Command" CommandArgument='<%# Eval("IdSolicitud") %>' CssClass="btnRechazar" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        </tbody>
                    </table>
                </fieldset>
                <table id="tbResultados" class="tbResultados">
                    <tr>
                        <td class="divLista">
                            <fieldset>
                                <legend>Lista de Aceptados</legend>
                                <table class="tablaSolicitudes">
                                    <thead>
                                        <tr class="filaTitulos">
                                            <th class="tituloTabla">
                                                ESTUDIANTE
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    <asp:Repeater ID="rptAceptados" runat="server">
                                        <ItemTemplate>
                                            <tr class="datosSolicitud">
                                                <td class="nombreSolicitud"><%# Eval("NombreCompleto") %></td>
                                            </tr>
                                        </ItemTemplate>
                                    </asp:Repeater>
                                    </tbody>
                                </table>
                            </fieldset>
                        </td>
                        <td class="divLista">
                            <fieldset>
                                <legend>Lista de Rechazados</legend>
                                <table class="tablaSolicitudes">
                                    <thead>
                                        <tr class="filaTitulos">
                                            <th class="tituloTabla">ESTUDIANTE</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:Repeater ID="rptRechazados" runat="server">
                                            <ItemTemplate>
                                                <tr class="datosSolicitud">
                                                    <td class="nombreSolicitud"><%# Eval("NombreCompleto") %></td>
                                                </tr>
                                            </ItemTemplate>
                                        </asp:Repeater>
                                    </tbody>
                                </table>
                            </fieldset>
                        </td>
                    </tr>
                </table>
            </div>
        </fieldset>
    </form>
</asp:Content>
