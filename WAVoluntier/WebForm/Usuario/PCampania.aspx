<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampania.aspx.cs" Inherits="WebForm_Usuario_PCampania" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

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

        .title {
            font-weight: bold;
            color: #1e1e1e;
            font-size: 24px; /* Tamaño de fuente del título */
        }

        .descripcion {
            font-size: 16px; /* Tamaño de fuente de la descripción */
            margin-top: 10px;
        }

        .fechas {
            font-size: 14px; /* Tamaño de fuente de las fechas */
            margin-bottom: 15px;
            font-weight: bold;
        }

        .btn-postular {
            background: #6c63ff;
            color: #fff;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background 0.3s;
            font-size: 16px; /* Tamaño de fuente del botón */
            margin-top: 10px;
            text-decoration: none; /* Quita la decoración de enlace */
        }

        .btn-postular:hover {
            background: #1e1e1e;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Label ID="lblTitulo" CssClass="title" runat="server"></asp:Label>
        <div class="descripcion">
            <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
        </div>
        <div class="fechas">
            <asp:Label ID="lblFechas" runat="server"></asp:Label>
        </div>
        <div class="btn-postular-container"> 
            <a href="#" class="btn-postular">POSTULAR</a>
        </div>
    </div>
</asp:Content>
