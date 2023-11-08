<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PLogin.aspx.cs"
Inherits="PLogin" %>

<!DOCTYPE html>
<html xmlns:og="http://ogp.me/ns#">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=Edge">
    <meta http-equiv="X-UA-Compatible" content="chrome=1">
    <meta name="keywords" content="universidad, univalle, bolivia, estudiar, sistema informacion, siu, estudar, medicina, sem, vestibular, faculdade, cochabamba, ingenieria, empresas, campus, la paz, trinidad, sucre">
    <meta name="description" content="Universidad del Valle Bolivia, noticias, informacion, facultades, extension, estudiantes internacionales, investigacion, medicina Bolivia">
    <meta property="og:title" content="SIU - Univalle">
    <meta property="og:description" content="S.I.U. Sistema de Información - Univalle">
    <meta property="og:image" content="https://enlace.univalle.edu/san/Imagenes/MasterPage/logo.jpg">
    <title>Servicio de autenticacion Netvalle
    </title>
    <link rel="shortcut icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png" type="image/png">
    <link rel="icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png" type="image/png">
    <link rel="apple-touch-icon" href="https://enlace.univalle.edu/san/Imagenes/MasterPage/apple-touch-icon.png">
    <link rel="author" href="https://plus.google.com/112045553903328672114/posts">
  <style type="text/css">
    body {
      background: #6c63ff;
      font-family: "Muli", sans-serif;
      color: #f0f0f0; /* Cambiamos el color de texto predeterminado a #f0f0f0 */
      margin: 0;
      padding: 0;
      display: flex;
      justify-content: center;
      align-items: center;
      text-align: center;
      width: 100vw;
      height: 100vh;
    }

    .container {
      width: 100%;
      max-width: 20%;
      text-align: center;
      justify-content: center;
      background: #1e1e1e;
      border-radius: 10px;
      padding: 20px 40px;
      box-sizing: border-box;
    }

    h1 {
      font-weight: bold;
    }

    .form-control {
      color: #f0f0f0;
      width: 100%;
      max-width: 100%;
      padding: 10px;
      margin: 10px 0;
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
</head>
<body>
  <div class="container">
    <h1>VOLUNTIER</h1>
      <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
    <form
      runat="server"
      id="submitForm"
      data-parsley-validate=""
      data-parsley-errors-messages-disabled="true"
      novalidate=""
      _lpchecked="1"
    >
      <input
        type="hidden"
        name="_csrf"
        value="7635eb83-1f95-4b32-8788-abec2724a9a4"
      />
      <div class="form-group required">
        <label for="username">Username / Email</label>
        <asp:TextBox
          runat="server"
          type="text"
          class="form-control text-lowercase"
          ID="txtUsername"
          required=""
          name="username"
          value=""
        />
      </div>
      <div class="form-group required">
        <label
          class="d-flex flex-row align-items-center"
          for="password"
          >Password
         </label
        >
        <input
          type="password"
          class="form-control"
          required=""
          id="password"
          name="password"
          value=""
        />
      </div>
      <div class="form-group pt-1">
        <asp:Button runat="server" ID="btnIniciar" OnClick="btnIniciar_Click" class="btn btn-primary btn-block" Text="Iniciar Sesion" type="submit"/>
      </div>
    </form>

  </div>
</body>
</html>
