<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PGestionCampanias.aspx.cs" Inherits="PGestionCampanias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SGestionCampanias.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <form runat="server">
            <div class="titulo title">
                <b>CAMPAÑAS DE SERVICIO SOCIAL</b>
                <p class="cerrar">
                    <a class="link" href="PMenuAdministrador.aspx">X</a>
                </p>
            </div>
            <div>
                <fieldset>
                    <div class="contenedorBoton">
                        <asp:Button ID="btnCrearCampania" CssClass="btnVentanas" runat="server" Text="CREAR CAMPAÑA" OnClick="btnCrearCampania_Click"/>
                        <asp:Button ID="btnCampaniasPropuestas" CssClass="btnVentanas" runat="server" Text="CAMPAÑAS PROPUESTAS" OnClick="btnCampaniasPropuestas_Click"/>
                    </div>
                    <hr />
                    <div class="contenedorBoton">
                        <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>
                    </div>
                    <asp:GridView ID="gvListaCampanias" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" OnRowCommand="gvListaCampanias_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="IdCampania" HeaderText="ID" Visible="false"/>
                            <asp:BoundField DataField="NombreCampania" HeaderText="NOMBRE" ItemStyle-CssClass="colCampania"/>
                            <asp:BoundField Visible="false" DataField="DescripcionCampania" HeaderText="DESCRIPCION"  />
                            <asp:BoundField Visible="false" DataField="FechaInicioCampania" HeaderText="FECHAINICIO" DataFormatString="{0:d}" />
                            <asp:BoundField Visible="false" DataField="FechaFinCampania" HeaderText="FECHAFIN" DataFormatString="{0:d}"/>
                            <asp:BoundField DataField="EstadoTexto" HeaderText="ESTADO"  ItemStyle-CssClass="colEstado"/>
                            <asp:TemplateField ItemStyle-CssClass="colOpciones">
                                <ItemTemplate>
                                    <asp:Button CssClass="btnOpciones" runat="server" CommandName="btnInformacion" Text="Ver" CommandArgument='<%# Eval("IdCampania") + "|" + Eval("EstadoCampania") %>' />
                                    <asp:Button CssClass="btnOpciones" runat="server" CommandName="btnActualizar" Text="Actualizar" CommandArgument='<%# Eval("IdCampania") %>' />
                                    <asp:Button CssClass="btnOpciones" runat="server" CommandName="btnEliminar" Text="Eliminar" CommandArgument='<%# Eval("IdCampania") + "|" + Container.DataItemIndex %>' />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </fieldset>
            </div>
            <div class="modal-container-notificacion" id="modalNotificacionContainer">
                <div class="modal-notificacion" id="modalNotificacion">
                    <asp:ImageButton ID="btnCerrar" CssClass="btnCerrar" ImageUrl="~/Imagenes/close.png" runat="server" OnClick="btCerrar_Click"></asp:ImageButton>
                    <div class="contenedor">
                        <p class="LBLContenido centrar">¿ESTA SEGURO/A DE ELIMINAR ESTA CAMPAÑA?</p>
                        <p class="LBLContenido centrar"><b><asp:Label ID="lblCampaniaEliminar" runat="server"></asp:Label></b></p>
                        <p class="LBLContenido centrar"><asp:Label ID="lblExep" runat="server" ForeColor="Red">Esta acción no se podrá revertir a futuro</asp:Label></p>
                        <div class="centrar">
                            <asp:Button ID="btnEliminar" runat="server" CssClass="btnEliminar" Text="Eliminar" OnClick="btnEliminar_Click"/>
                        </div>
                    </div>
                </div>
            </div>
            <script src="../../Guiones/JModalEliminarCampania.js"></script>
        </form>
    </fieldset>
</asp:Content>


