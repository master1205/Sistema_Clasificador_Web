<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio_Sesion.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.Inicio_Sesion" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Administrador de Archivos</title>
    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <style>
        .bd-placeholder-img {
            font-size: 1.125rem;
            text-anchor: middle;
            -webkit-user-select: none;
            -moz-user-select: none;
            -ms-user-select: none;
            user-select: none;
        }

        @media (min-width: 768px) {
            .bd-placeholder-img-lg {
                font-size: 3.5rem;
            }
        }
    </style>
    <!-- Custom styles for this template -->
    <link href="Login.css" rel="stylesheet" />
    <link rel="icon" type="image/png" href="imagenes/favicon.ico"/>
</head>
    <body class="text-center">
    <form class="form-signin " runat="server">
        <asp:Label ID="Label1" Font-Size="X-Large" runat="server" Text="Clasificador de archivos"></asp:Label>
        <img class="mb-4" src="imagenes/LOGO 3.png" alt="" width="72" height="72">
        <h1 class="h3 mb-3 font-weight-normal">Inicio de sesion</h1>
        <asp:TextBox ID="UsuarioTxt"  runat="server" CssClass="form-control btn-block" placeholder="Usuario"></asp:TextBox>
        <asp:TextBox ID="ClaveTxt" Type="password" runat="server" CssClass="form-control btn-block" placeholder="Contraseña"></asp:TextBox>
        <asp:Button ID="Acceder_btn" ForeColor="White" runat="server" OnClick="Accederbtn_Click" Text="Ingresar" style="background:#007FFF;" CssClass="btn  btn-block"/>
    </form>
</body>
</html>