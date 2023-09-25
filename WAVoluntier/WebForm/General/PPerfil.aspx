<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PPerfil.aspx.cs" Inherits="WebForm_General_PPerfil" MasterPageFile="~/PaginaMaestra/MPInicio.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../Estilo/Administrador/SAgregarCampania.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,400,700,800&display=swap" rel="stylesheet">
    <link href="../../Estilo/Administrador/SModalAgregarCampania.css" rel="stylesheet" />
     <style type="text/css">
        

        .container {
            width: 100%;
            text-align: center;
            justify-content: center;
            border-radius: 10px;
            padding: 20px 40px;
            box-sizing: border-box;
        }

        .perfil-info {
            list-style: none;
            padding: 0;
        }

        .perfil-item {
            margin-bottom: 20px;
            text-align: center;
        }

        .nombre-usuario {
            font-weight: bold;
            font-size: 20px;
            color: #6c63ff;
        }

        .detalle {
            font-size: 16px;
            margin-top: 10px;
        }

        .dato {
            display: block;
            margin-top: 5px;
        }
     </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
            <h1 class="title">Perfil del Usuario</h1>
            <ul class="perfil-info">
                <li class="perfil-item">
                    <asp:Label ID="lblNombreUsuario" runat="server"></asp:Label>
                    <div class="detalle">
                        <asp:Label ID="lblCarrera" runat="server"></asp:Label>
                        <asp:Label ID="lblSede" runat="server"></asp:Label>
                        <asp:Label ID="lblHorasRegistradas" runat="server"></asp:Label>
                    </div>
                </li>
                <!-- Puedes agregar más elementos de perfil según sea necesario -->
            </ul>
        </div>
</asp:Content>