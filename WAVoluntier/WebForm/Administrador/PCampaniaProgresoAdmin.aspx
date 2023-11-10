<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampaniaProgresoAdmin.aspx.cs" Inherits="WebForm_Administrador_PCampaniaProgresoAdmin" MasterPageFile="~/PaginaMaestra/MPInicio.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SCampaniaProgresoAdmin.css" rel="stylesheet" />

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
                        <td class="tituloTabla">
                            DESCRIPCION
                        </td>
                        <td class="tituloTabla">
                            FECHAS
                        </td>
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
                    <legend>Lista de participantes</legend>
                    <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>
                    <table ID="tbParticipantes" class="tablaSolicitudes">
                        <thead>
                            <tr class="filaTitulos">
                                <th class="tituloTabla">
                                    ESTUDIANTE
                                </th>
                                <th class="tituloTabla">
                                    REGISTRAR TIEMPO
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                        <asp:Repeater ID="rptParticipantes" runat="server">
                            <ItemTemplate>
                                <tr class="datosSolicitud">
                                    <td class="nombreSolicitud"><%# Eval("NombreCompleto") %></td>
                                    <td class="acciones">
                                        <asp:TextBox ID="txtHoras" runat="server" CssClass="txtHoras" TextMode="Number" placeholder="HH" Text='<%# Eval("Horas") %>'></asp:TextBox>
                                        <span><b> : </b></span>
                                        <asp:TextBox ID="txtMinutos" runat="server" CssClass="txtHoras" TextMode="Number" placeholder="MM" Text='<%# Eval("Minutos") %>'></asp:TextBox>
                                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CommandName="Aceptar" OnCommand="btnAceptar_Command" CommandArgument='<%# Eval("IdUsuarioParticipacion") + "|" + Container.ItemIndex %>' CssClass="btnAceptar" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:Repeater>
                        </tbody>
                    </table>
                </fieldset>
            </div>
        </fieldset>
    </form>
</asp:Content>