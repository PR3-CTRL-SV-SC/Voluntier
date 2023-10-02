<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampaniasPropuestas.aspx.cs" Inherits="WebForm_Administrador_PCampaniasPropuestas" MasterPageFile="~/PaginaMaestra/MPInicio.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SAgregarCampania.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SModalAgregarCampania.css" rel="stylesheet" />
     <style type="text/css">
        

    .container {
    width: 100%;
    /*max-width: 80%;*/ /* Ajusta el ancho máximo según tus preferencias */
    text-align: center;
    justify-content: center;
    /*background: #1e1e1e;*/
    border-radius: 10px;
    padding: 20px 40px;
    box-sizing: border-box;
    }
    .camp-list {
        list-style: none;
        padding: 0;
    }

    .camp-item {
        margin-bottom: 20px;
        text-align: center;
    }

    .titulo {
        font-weight: bold;
        font-size: 20px; /* Tamaño de fuente del título */
        color: #6c63ff; /* Color del título */
    }

    .descripcion {
        font-size: 16px; /* Tamaño de fuente de la descripción */
        margin-top: 10px;
    }

    .fechas {
        font-size: 14px; /* Tamaño de fuente de las fechas */
    }

    .fecha {
        display: block;
        margin-top: 5px;
    }
     </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h1 class="title">Listado de Campañas</h1>
        <ul class="camp-list">
            <asp:Repeater ID="rptCampañas" runat="server">
                <ItemTemplate>
                    <li class="camp-item">
                        <span class="titulo"><%# Eval("NombreCampaña") %></span>
                        <div class="descripcion"><%# Eval("Descripcion") %></div>
                        <div class="fechas">
                            <span class="fecha">Fecha de Inicio: <%# Eval("FechaInicio", "{0:dd/MM/yyyy}") %> - Fecha de Cierre: <%# Eval("FechaCierre", "{0:dd/MM/yyyy}") %></span>
                        </div>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>
