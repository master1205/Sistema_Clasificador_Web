<%@ Page Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="Registraráreas.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.Classes.Registraráreas" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">        
            <div class="container-fluid">
                <ol class="breadcrumb" style="background-color:#B8D8E0">
                <li class="breadcrumb-divider:>"><a href="#">Inicio</a></li>
                <li class="active" style="color:black">Registros</li>
                <li class="active"style="font-size:large; color:black">Registrar Área</li>
            </ol>        
    </div>
        <div class="container">
        <br />
        <div class="row">
            <div class="col-md-12"">
                <div class="panel panel-default ">
                    <div class="panel-heading text-center"  style="background:#0099cc;font-size:x-large">Areas</div>
                    <div class="panel-body">
                        
                            <div class="col-sm-6 mb-3">
                                <p><asp:Label ID="Label1" runat="server" Text="Area" CssClass="control-label"></asp:Label></p>
                                <p>
                                    <asp:TextBox ID="txtArea" runat="server" CssClass="form-control btn-block" placeHolder="Descripción" AutoCompleteType="Disabled"></asp:TextBox></p>                              
                            </div>
                        <div class="col-sm-4 mb-3">
                                <br />
                            <p></p>
                                <asp:Button ID="btnRegistra" OnClick="btnRegistra_Click" runat="server" Text="Guardar" style="background:#0099cc;"  CssClass="btn btn-primary btn-block" />
                            </div>
                        </div>
                    </div>
            </div>
        </div>
    </div>
    <div class="container">
        <div class="table-responsive">
            <asp:GridView ID="VistaAreas"  BackColor="White" runat="server" CssClass="table table-hover" OnSelectedIndexChanged="VistaAreas_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#79e0e7" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" headertext="Modificar" ButtonType="Image" SelectImageUrl="Imagenes/Seleccionar.png" SelectText="Editar" ItemStyle-HorizontalAlign="Center" />
                </Columns>
                <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
                </asp:GridView>
        </div>
    </div>
</asp:Content>

