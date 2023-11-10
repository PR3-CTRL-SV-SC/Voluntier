<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/MPInicio.master" AutoEventWireup="true" CodeFile="PMisCampanias.aspx.cs" Inherits="WebForm_Usuario_PMisCampanias" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../../Estilo/Usuario/SMisCampanias.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form" runat="server">
        <fieldset class="field">
            <div class="title">
                <label class="lblTitle">MIS CAMPAÑAS</label>
                <p class="cerrar">
                    <a class="link" href="PMenuEstudiante.aspx">X</a>
                </p>
            </div>
            <div id="div1" runat="server" class="containerLista">
                <fieldset>
                    <div class="estado">
                        <asp:Label ID="lblHoras" runat="server" CssClass="lblHoras"></asp:Label>
                    </div>

                    <div class="contenedorBotones">
                        <asp:Button ID="btnPendientes" CssClass="btnOpciones" runat="server" Text="Pendientes" OnClick="btnPendientes_Click"/>
                        <asp:Button ID="btnAprobados" CssClass="btnOpciones" runat="server" Text="Aprobados" OnClick="btnAprobados_Click"/>
                        <asp:Button ID="btnRechazados" CssClass="btnOpciones" runat="server" Text="Rechazados" OnClick="btnRechazados_Click"/>
                    </div>
                    <asp:Label ID="lblOpciones" runat="server" CssClass="lblOpcion"></asp:Label>
                    <hr />
                    <asp:Label ID="lblNotificacion" runat="server" CssClass="lblNotificacion"></asp:Label>

                    
                    <asp:GridView ID="gvListaCampanias" CssClass="gridview" runat="server" CellPadding="10" ShowHeaderWhenEmpty="True" AutoGenerateColumns="False" >
                        <Columns>
                            <asp:BoundField DataField="IdCampania" HeaderText="ID" Visible="false"/>
                            <asp:BoundField DataField="NombreCampania" HeaderText="CAMPAÑA" HeaderStyle-CssClass="colTitulo" ItemStyle-CssClass="colCampania" />
                            <asp:BoundField DataField="EstadoCampania" HeaderText="ESTADO" HeaderStyle-CssClass="colTitulo" ItemStyle-CssClass="colSolicitud" />
                            <asp:BoundField DataField="EstadoSolicitud" HeaderText="SOLICITUD" HeaderStyle-CssClass="colTitulo" ItemStyle-CssClass="colSolicitud" Visible="false"/>
                            <asp:BoundField DataField="HorasParticipacion" HeaderText="HORAS" HeaderStyle-CssClass="colTitulo" ItemStyle-CssClass="colHora" />
                            <asp:TemplateField HeaderStyle-CssClass="colTitulo">
                                <ItemTemplate >
                                    <asp:Button CssClass="btnVer" runat="server" OnCommand="btnVer_Command" Text="Ver" CommandArgument='<%# Eval("IdCampania") %>'/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </fieldset>
            </div>
        </fieldset>
    </form>
</asp:Content>
