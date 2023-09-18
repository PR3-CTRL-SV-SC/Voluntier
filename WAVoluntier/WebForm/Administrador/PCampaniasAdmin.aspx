<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PCampaniasAdmin.aspx.cs" Inherits="WebForm_Administrador_PCampaniasAdmin"  %>

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
            background: #2E2E2E;
            color: #f2f2f2;
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


        /* Estilos para la lista de solicitudes */
.solicitudes {
    width: 100%;
    border-collapse: collapse;
    background-color: transparent; /* Sin color de fondo */
    color: #1e1e1e; /* Color de texto */
    border-radius: 10px;
    margin-top: 20px;
}

.solicitudes .nombre-estudiante {
    max-width: 300px; /* Ancho máximo para el nombre del estudiante */
    overflow: hidden;
    text-overflow: ellipsis; /* Recortar texto largo con puntos suspensivos */
    padding: 10px;
    text-align: left;
    border-bottom: 1px solid #555; /* Línea divisoria entre filas */
}

.solicitudes .acciones {
    padding: 10px;
    text-align: right;
    border-bottom: 1px solid #555; /* Línea divisoria entre filas */
}

/* Estilos de los botones dentro de la tabla */
.solicitudes .btn-aceptar,
.solicitudes .btn-denegar {
    background: #6c63ff;
    color: #fff;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    transition: background 0.3s;
    font-size: 14px; /* Tamaño de fuente de los botones */
    margin-right: 5px;
    text-decoration: none; /* Quita la decoración de enlace */
}

.solicitudes .btn-aceptar:hover,
.solicitudes .btn-denegar:hover {
    background: #1e1e1e;
}

.solicitudes .btn-denegar {
    background: #E32828; /* Color de fondo rojo para el botón de denegar */
}

    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblTitulo" CssClass="title" runat="server"></asp:Label>
            <div class="descripcion">
                <asp:Label ID="lblDescripcion" runat="server"></asp:Label>
            </div>
            <div class="fechas">
                <asp:Label ID="lblFechas" runat="server"></asp:Label>
            </div>
            <div class="btn-postular-container"> 
                <a href="#" class="btn-postular">PENDIENTE</a>
            </div>
        </div>
        <div>
            <table class="solicitudes">
                <asp:Repeater ID="rptSolicitudes" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td class="nombre-estudiante"><%# Eval("NombreEstudiante") %></td>
                            <td class="acciones">
                                <asp:Button ID="btnDenegar" runat="server" Text="Denegar" OnClick="btnDenegar_Click" CssClass="btn-denegar" /> 
                                <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" CssClass="btn-aceptar" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </form>
</asp:Content>
