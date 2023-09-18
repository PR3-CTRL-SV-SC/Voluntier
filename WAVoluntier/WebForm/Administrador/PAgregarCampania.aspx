<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PAgregarCampania.aspx.cs" Inherits="PAgregarCampania" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SAgregarCampania.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SModalAgregarCampania.css" rel="stylesheet" />
     <style type="text/css">
        

        .container {
            width: 100%;
            /*max-width: 40%;*/
            text-align: left; /* Alinear el contenido a la izquierda */
            /*background: #1e1e1e;*/
            border-radius: 10px;
            padding: 20px;
            box-sizing: border-box;
        }

        h1 {
            font-weight: bold;
            margin-bottom: 20px; /* Agregamos espacio inferior al título */
        }

        .form-group {
            margin-bottom: 20px; /* Agregamos espacio inferior a cada grupo de formulario */
        }

        label {
            display: block; /* Hacer que las etiquetas ocupen una línea completa */
            font-weight: bold;
            margin-bottom: 5px; /* Agregamos espacio inferior a las etiquetas */
        }

        .form-control {
            color: #f0f0f0;
            width: 100%;
            padding: 10px;
            background-color: #1e1e1e;
            border-radius: 10px;
            border: 1px solid #f0f0f0;
            box-sizing: border-box;
        }

        .form-control:focus {
            background-color: #1e1e1e;
            border-color: #6c63ff;
        }

        .btn {
            width: 100%;
            background: #6c63ff;
            color: #fff;
            padding: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            transition: background 0.3s;
        }

        .btn:hover {
            background: #1e1e1e;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
        <div class="container">
            <h1>Formulario de Agregar Campaña</h1>
            <div class="form-group">
                <label for="txbNombreCmpania">Nombre de la Campaña:</label>
                <asp:TextBox ID="txbNombreCmpania" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txbDescripcion">Descripción:</label>
                <asp:TextBox ID="txbDescripcion" CssClass="form-control" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txbFechaInicio">Fecha de Inicio:</label>
                <asp:TextBox ID="txbFechaInicio" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txbFechaFin">Fecha de Cierre:</label>
                <asp:TextBox ID="txbFechaFin" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnGuardarCampania" CssClass="btn btn-primary" Text="Guardar Campaña" runat="server" OnClick="btnIniciar_Click" />
            </div>
        </div>
    </form>
</asp:Content>