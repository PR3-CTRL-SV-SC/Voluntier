<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampania.aspx.cs" Inherits="WebForm_Usuario_PCampania" MasterPageFile="~/PaginaMaestra/MPInicio.master" EnableEventValidation="true" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Usuario/SCampania.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset class="field">
            <div class="title">
                <asp:Label ID="lblCampania" runat="server" CssClass="lblCampania"></asp:Label>
                <p class="cerrar">
                    <asp:Button ID="btnAtras" runat="server" CssClass="link" Text="X" OnClick="btnAtras_Click"/>
                </p>
            </div>
            <div class="container">
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
                <div class="ContenedorBoton">
                    <asp:Button ID="btnPostular" CssClass="btnPostular" runat="server" Text="Postular" OnClick="btnPostular_Click" />
                </div>
            </div>
            <%--Modal Aceptar--%>
            <div class="modal-container-notificacion" id="modalNotificacionContainer">
                <div class="modal-notificacion" id="modalNotificacion">
                    <asp:ImageButton ID="btnCerrar" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btnCerrar_Click"></asp:ImageButton>
                    <div class="contenedor">
                        <p class="lblModalTitulo centrar">¿ESTAS SEGURO DE QUERER POSTULARTE A ESTA CAMPAÑA?</p>
                        <p class="LBLContenido centrar">
                            <b><asp:Label ID="lblModalCampania" runat="server"></asp:Label></b>
                        </p>
                        <p class="lblAviso">DESPUES NO PODRAS CANCELAR TU SOLICITUD</p>
                        <div class="centrar">
                            <asp:Button ID="btnConfirmar" runat="server" CssClass="btnConfirmar" Text="Confirmar" OnClick="btnConfirmar_Click" />
                        </div>
                    </div>
                </div>
            </div>
            <script src="../../Guiones/JModalAgregarCampania.js"></script>
        </fieldset>
    </form>
</asp:Content>
