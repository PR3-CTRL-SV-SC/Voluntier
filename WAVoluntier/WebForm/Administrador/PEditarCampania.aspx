﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PEditarCampania.aspx.cs" Inherits="PEditarCampania" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SAgregarCampania.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SModalAgregarCampania.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <fieldset>

        <div class="divCentro title">
            <label class="lblCampaniaEditAdd">Editar Campaña</label>
            <p class="cerrar">
                <a class="link" href="PGestionCampanias.aspx">X</a>
            </p>
        </div>
        <div class="container">
            <table class="tabla">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblExep" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
                <tr class="ContenedorCampos">
                    <td class="ContenedorLabel">
                        <asp:Label CssClass="textLabel" Text="Nombre de la Campaña:" runat="server"></asp:Label>
                    </td>
                    <td class="ContenedorInput">
                        <asp:TextBox ID="txbNombreCampania" CssClass="textInput" runat="server" oninput="this.value = this.value.toUpperCase();"></asp:TextBox>
                    </td>
                </tr>

                <tr class="ContenedorCampos">
                    <td class="ContenedorLabel">
                        <asp:Label CssClass="textLabel" Text="Descripción:" runat="server"></asp:Label>
                    </td>
                    <td class="ContenedorInput">
                        <asp:TextBox ID="txbDescripcion" CssClass="textInput" runat="server" TextMode="MultiLine" Rows="5"></asp:TextBox>
                    </td>
                </tr>

                <tr class="ContenedorCampos">
                    <td class="ContenedorLabel">
                        <asp:Label CssClass="textLabel" Text="Fecha de Inicio:" runat="server"></asp:Label>
                    </td>
                    <td class="ContenedorInput">
                        <asp:TextBox ID="txbFechaInicio" CssClass="textInput" TextMode="Date" runat="server"></asp:TextBox>
                    </td>
                </tr>

                <tr class="ContenedorCampos">
                    <td class="ContenedorLabel">
                        <asp:Label CssClass="textLabel" Text="Fecha de Cierre:" runat="server"></asp:Label>
                    </td>
                    <td class="ContenedorInput">
                        <asp:TextBox ID="txbFechaFin" CssClass="textInput" TextMode="Date" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <asp:Button ID="btnGuardarCampania" CssClass="btnAddCampain" Text="Guardar Campaña" runat="server" OnClick="btnGuardarCampania_Click" />
        </div>
        <!--Modal-->
        <div class="modal-container" id="modalNotificacionContainer">
            <div class="modal" id="modalNotificacion">
                <div>
                    <div>
                        <div class="divCentro">
                            <asp:Label CssClass="lblCampaniaEditAdd" Text="¿ESTA SEGURO QUE DESEA ACTUALIZAR?" runat="server"></asp:Label>
                        </div>
                        <br />
                        <div class="divIzquierda">
                            <asp:Label CssClass="textLabel" Text="Nombre de Campaña: " runat="server"></asp:Label>
                            <asp:Label CssClass="textInput" ID="lblDatosNombreCampania" runat="server"></asp:Label>
                            <br />
                            <asp:Label CssClass="textLabel" Text="Descripción: " runat="server"></asp:Label>
                            <asp:Label CssClass="textInput" ID="lblDatosDescripcionCampania" runat="server"></asp:Label>
                            <br />
                            <asp:Label CssClass="textLabel" Text="Fecha Inicio: " runat="server"></asp:Label>
                            <asp:Label CssClass="textInput" ID="lblFechaInicio" runat="server"></asp:Label>
                            <br />
                            <asp:Label CssClass="textLabel" Text="Fecha Cierre: " runat="server"></asp:Label>
                            <asp:Label CssClass="textInput" ID="lblFechaCierre" runat="server"></asp:Label>
                            <br />
                        </div>
                        <div class="divCentro">
                            <asp:Label runat="server" ForeColor="Red"  Text="El modificar esta campaña se volvera a esperar confirmacion de administracion"></asp:Label>
                            <br />
                            <asp:Button ID="btnConfirmar" runat="server" Text="ACEPTAR" CssClass="btnMod" OnClick="btnConfirmar_Click"/>
                            <asp:Button ID="btnCancelar" runat="server" Text="CANCELAR" CssClass="btnMod" OnClick="btnCancelar_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script src="../../Guiones/JModalAgregarCampania.js"></script>
        </fieldset>
    </form>
</asp:Content>