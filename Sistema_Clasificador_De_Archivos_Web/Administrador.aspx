<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, user-scalable=no, initial-scale=1.0, maximun-scale=1.0, minimun-scale=1.0" />
    <title>Administración de Archivos</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Resourse/Estilos.css" rel="stylesheet" />
</head>
<body>
    <header>
        <nav class="navbar navbar-inverse navbar-static-top">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navegacion-fm">
                        <span class="sr-only">Desplegar / Ocultar Menu</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a href="#" class="navbar-brand">Administración de Archivos</a> 
                </div>
                <div class="collapse navbar-collapse" id="navegacion-fm">
                    <ul class="nav navbar-nav">
                        <li><a href="#">Inicio</a> </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">Registros<span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="#">Usuarios</a> </li>
                                <li class="divider"></li>
                                <li><a href="#">Areas</a> </li>
                                <li class="divider"></li>
                                <li><a href="#">Clasificadores/Subclasificadores</a> </li>
                            </ul>
                        </li>
                        <li class="dropdown">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button">Documentos<span class="caret"></span>
                            </a>
                            <ul class="dropdown-menu" role="menu">
                                <li><a href="#">Registrar Documentos</a> </li>
                                <li class="divider"></li>
                                <li><a href="#">Consultar Documentos</a> </li>
                            </ul>
                        </li>
                    </ul>
                </div>
            </div>
        </nav>
    </header>
    <%--Se crea un jumbotron para el mensaje de Bienvenida--%>
    <section class="jumbotron">
        <div class="container">
            <h1>Bienvenido</h1>
            <p>Administracion de Archivos en la nube</p>
        </div>
    </section>
    <%-- Se agregan las librerias del jquery--%>
    <script src="Scripts/jquery-3.3.1.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
</body>
</html>
