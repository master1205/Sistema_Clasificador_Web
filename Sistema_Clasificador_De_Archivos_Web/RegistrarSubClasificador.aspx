<%@ Page Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistrarSubClasificador.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.RegistrarSubClasificador" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container-fluid">
            <ol class="breadcrumb" style="background-color:#B8D8E0">
                <li><a href="#">Inicio</a></li>
                <li class="active" style="color:black">Registros</li>
                <li class="active"style="font-size:large; color:black">Registrar SubClasificador</li>
            </ol>
        </div>
     <div class="container">
        <br />
        <div class="row">
            <div class="col-md-12"">
                <div class="panel panel-default ">
                    <div class="panel-heading text-center" style="background:#0099cc; font-size:x-large"">SubClasificador</div>
                    <div class="panel-body">
                        <div class="row">
                            <div class="col-sm-6 mb-3">
                            <p>Selecciona un Clasificador: </p>
                            <p><asp:DropDownList ID="DropClasificador" runat="server" CssClass="form-control btn-block"></asp:DropDownList ></p>
                        </div>
                            <div class="col-sm-6 mb-3">                           
                        <p><asp:Label ID="Label1" runat="server" Text="Clasificador" CssClass="control-label"></asp:Label></p>
                        <p><asp:TextBox ID="DescripcionTxt" runat="server" CssClass="form-control btn-block" placeHolder="Descripción" AutoCompleteType="Disabled"></asp:TextBox></p>
                        </div>
                        </div>                        
                            <div class="col-sm-4 mb-3">
                                <br />                                
                            </div>
                        <div class="col-sm-4 mb-3">
                                <asp:Button ID="btnRegistra" runat="server" OnClick="btnRegistra_Click" Text="Guardar"  style="background:#0099cc;" CssClass="btn btn-primary btn-block" />
                            </div>
                        </div>
                    </div>
            </div>
        </div>
    </div>
            <div class="container">
        <asp:GridView ID="VistaSubClasificador"  BackColor="White"  OnSelectedIndexChanged="VistaSubClasificador_SelectedIndexChanged" runat="server" CssClass="table table-hover">
             <AlternatingRowStyle BackColor="#79e0e7" />
            <Columns>
                <asp:CommandField ShowSelectButton="True"   headertext="Modificar" ButtonType="Image" SelectImageUrl="Imagenes/Seleccionar.png" SelectText="Editar" ItemStyle-HorizontalAlign="Center" />
            </Columns>
            <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
    </div>
       
</asp:Content>
