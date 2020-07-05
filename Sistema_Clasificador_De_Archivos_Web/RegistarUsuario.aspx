<%@ Page Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistarUsuario.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.RegistarUsuario" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">    
    <div class="container-fluid">
            <ol class="breadcrumb" style="background-color:#B8D8E0">
                <li><a href="#">Inicio</a></li>
                <li class="active" style="color:black">Usuarios</li>                
                <li class="active"style="font-size:large; color:black">Registrar Usuario</li>
            </ol>
        </div>
        <div class="container-fluid responsive">
        <br />
        <div class="row">
            <div class="col-md-12"">
                <div class="panel panel-default table-responsive">
                    <div class="panel-heading text-center" style="background:#0099cc; font-size:x-large">Usuarios</div>
                    <div class="panel-body" >
                        <div class="row">
                            <div class="col-sm-6 mb-3">
                                <p>
                                    <asp:Label ID="Label1" runat="server" Text="Nombre(s)" CssClass="control-label"></asp:Label></p>
                                <p>
                                    <asp:TextBox ID="NombreTxt" runat="server" CssClass="form-control btn-block" placeHolder="Nombre Completo" AutoCompleteType="Disabled"></asp:TextBox></p>

                            </div>
                            <div class="col-sm-6 mb-3">
                        <p><asp:Label ID="Label2" runat="server" Text="Apellidos" CssClass="control-label"></asp:Label></p>
                        <p><asp:TextBox ID="ApellidosTxt" runat="server" CssClass="form-control btn-block" placeHolder="Apellidos" AutoCompleteType="Disabled"></asp:TextBox></p>
                               </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6 mb-3">
                                <p>Usuario</p>
                                <asp:TextBox ID="UsuarioTxtx" runat="server" CssClass="form-control btn-block" placeholder="Usuario" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                            <div class="col-sm-6 mb-3">
                                <p>Contraseña</p>
                                <asp:TextBox ID="ContraseñaTxt" runat="server" type="password" CssClass="form-control btn-block" placeholder="Contraseña" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-6 mb-3">
                                <p>Telefono</p>
                                <asp:TextBox ID="TelefonoTxt" runat="server" CssClass="form-control btn-block" placeholder="Telefono" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                            <div class="col-sm-6 mb-3">
                                <p>Correo Electronico</p>
                                <asp:TextBox ID="CorreoTxt" runat="server" CssClass="form-control btn-block" placeholder="example@gmail.com" AutoCompleteType="Disabled"></asp:TextBox>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-sm-4 mb-3">
                                <p>Area</p>
                                <p><asp:DropDownList ID="ComboArea" runat="server" CssClass="form-control btn btn-block"></asp:DropDownList></p>
                            </div>
                            <div class="col-sm-4 mb-3">
                                <p>Rol</p>
                                <asp:DropDownList ID="ComboRol" runat="server" CssClass="form-control btn btn-block">
                                </asp:DropDownList>
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
    </div>
    <br />
    <div class="container-fluid">
        <div class="table-responsive">
            <asp:GridView ID="VistaUsuarios"  runat="server" Height="50px" BackColor="White"  CssClass="table table-condensed text-dark table-sm"  OnSelectedIndexChanged="VistaUsuarios_SelectedIndexChanged" OnRowDeleting="VistaUsuarios_RowDeleting">
                <AlternatingRowStyle BackColor="#79e0e7" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True"   headertext="Modificar" ButtonType="Image" SelectImageUrl="Imagenes/Seleccionar.png" SelectText="" >
                    <ItemStyle HorizontalAlign="Center" Wrap="True" VerticalAlign="Top" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Image" headertext="Eliminar" DeleteImageUrl="Imagenes/EliminarGrid.png" SelectImageUrl="Imagenes/EliminarGrid.png" ShowDeleteButton="True" >
                    
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    
                </Columns>
                <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
        </div>  
    </div>
</asp:Content>
