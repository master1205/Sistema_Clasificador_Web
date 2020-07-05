<%@ Page Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="ConsultaDocumentosA.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.ConsultaDocumentosA" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="Users">
    
    <div class="container-fluid">        
            <ol class="breadcrumb" style="background-color:#B8D8E0">
                <li><a href="#">Inicio</a></li>
                <li class="active" style="color:black" >Documentos</li>
                <li class="active"style="font-size:large; color:black">Consultar Documentos</li>
            </ol>
        </div>
    <div class="container-fluid">
        <asp:Label ID="Error" runat="server" Text="Label"></asp:Label>
        <div class="row">
            <div class="container-fluid">
                <div class="col-sm-2 mb-3">
                    <p><asp:DropDownList ID="Drop1"  AutoPostBack="true" runat="server"  CssClass="form-control btn-block" OnSelectedIndexChanged="btnBuscaState_Click">
                        <asp:ListItem Value="Seleccione una Opción:" />
                        <asp:ListItem Value="Todos" />
                        <asp:ListItem Value="Registrados" />
                        <asp:ListItem Value="Aceptados" />
                        <asp:ListItem Value="Rechazados" />
                        </asp:DropDownList></p>
                </div>
                <div class="col-sm-3 mb-4">
                    <!-- Button trigger modal -->
                    <button type="button" class="btn btn-primary btn-block"  style="background:#0099cc;" data-toggle="modal" data-target="#exampleModal">
                        Aceptar</button>
                    <!-- Modal -->
                    <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel">Aceptar Documento</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div>
                                <div class="modal-body">
                                    <p>¿Desea Aceptar el documento?</p>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button1" runat="server" Text="Cerrar" data-dismiss="modal" CssClass="btn btn-secondary" />
                                    <asp:Button ID="Button2" runat="server" Text="Guardar Cambios" OnClick="Button2_Click" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
                <div class="col-sm-3 mb-3">
                    <!-- Button trigger modal -->
                    <button type="button" class="btn btn-primary btn-block" style="background:#0099cc;" data-toggle="modal" data-target="#exampleModal1">
                        Rechazar
                    </button>
                    <!-- Modal -->
                    <div class="modal fade" id="exampleModal1" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel1" aria-hidden="true">
                        <div class="modal-dialog" role="document">
                            <div class="modal-content">
                                <div class="modal-header">
                                    <h5 class="modal-title" id="exampleModalLabel1">Rechazar Documento</h5>
                                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                        <span aria-hidden="true">&times;</span>
                                    </button>
                                </div> 
                                <div class="modal-body">
                                    <p>Al Rechazar el documento se borrara de GoogleDrive</p>
                                    <p>¿Desea Continuar Con La Operación?</p>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button3" runat="server" Text="Cerrar" data-dismiss="modal" CssClass="btn btn-secondary" />
                                    <asp:Button ID="Button4" runat="server" Text="Guardar Cambios" OnClick="Button4_Click" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
    <div class="container-fluid">
        <div class="table-responsive">
            <asp:GridView ID="vistaDocumentos" runat="server" CssClass="table table-hover" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" OnSelectedIndexChanged="vistaDocumentos_SelectedIndexChanged" OnRowDataBound="vistaDocumentos_RowDataBound" OnRowDeleted="vistaDocumentos_RowDeleted" OnRowEditing="vistaDocumentos_RowEditing">
                <AlternatingRowStyle BackColor="#79e0e7" />
                <Columns> 
                    <asp:CommandField ButtonType="Image" headertext="Descargar" ShowSelectButton="True" ItemStyle-Font-Bold="true" SelectImageUrl="Imagenes/Descargar.png" SelectText="">
                        <ControlStyle ForeColor="Black"></ControlStyle>
                        <ItemStyle Font-Bold="True"  HorizontalAlign="Center" Wrap="True" VerticalAlign="Top"></ItemStyle>
                    </asp:CommandField>
                    
                    
                    <asp:CommandField ButtonType="Image"  HeaderText="Aceptar" ShowEditButton="True" EditImageUrl="Imagenes/Aceptar.png">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    
                    <asp:CommandField ButtonType="Image" DeleteImageUrl="Imagenes/Rechazar.png" HeaderText="Rechazar" ShowDeleteButton="True">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    
                </Columns>
                <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>            
        </div>
    </div>
</asp:Content>

