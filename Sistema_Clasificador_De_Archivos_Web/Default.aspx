<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web._Default" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <title>Administrador de Archivos</title>
    <!-- Bootstrap core CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
   
    <!-- Custom styles for this template -->
    <link href="Login.css" rel="stylesheet" />
</head>
<body class="text-center">
    <form class="form-signin" runat="server">
        <asp:Label ID="Label1" Font-Size="X-Large" runat="server" Text="Clasificador de archivos"></asp:Label>
        <img class="mb-4" src="imagenes/LOGO 3.png" alt="" width="72" height="72">
        <h1 class="h3 mb-3 font-weight-normal">Inicio de Sesion</h1>
        <asp:TextBox ID="UsuarioTxt" runat="server" CssClass="form-control btn-block" placeholder="Usuario"></asp:TextBox>
        <asp:TextBox ID="ClaveTxt" Type="password" runat="server" CssClass="form-control btn-block" placeholder="Contraseña"></asp:TextBox>
        <asp:Button ID="Acceder_btn" runat="server" Text="Ingresar" OnClick="Acceder_btn_Click" style="background:#007FFF;" CssClass="btn  btn-block"/>
    </form>
</body>
</html>