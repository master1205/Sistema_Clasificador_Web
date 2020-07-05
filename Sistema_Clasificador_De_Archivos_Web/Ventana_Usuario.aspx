<%@ Page Language="C#" MasterPageFile="~/Responsable.Master" AutoEventWireup="true" CodeBehind="Ventana_Usuario.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.Ventana_Usuario" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent" ID="Users">
    <div class="container">
        <div class="row">
            <div class="container-fluid">
                <asp:Label ID="Error" runat="server" Text=""></asp:Label>
                <div class="col-sm-3 mb-3">
                    <p><asp:DropDownList ID="Drop1" OnSelectedIndexChanged="btnBuscaState_Click" AutoPostBack="true" runat="server"  CssClass="form-control btn-block">
                        <asp:ListItem Value="Seleccione una Opción:" />
                        <asp:ListItem Value="Todos" />
                        <asp:ListItem Value="Registrados" />
                        <asp:ListItem Value="Aceptados" />
                        <asp:ListItem Value="Rechazados" />
                        </asp:DropDownList></p>
                </div>
                </div>
            <div class="col-sm-3 mb-3">
                <asp:Button ID="btnTodos" OnClick="btnTodos_Click" CssClass="btn btn-primary  btn-lg btn-block" runat="server" Text="Todos" />
                <br />
            </div>
            <div class="col-sm-3 mb-3">
                <asp:Button ID="btnAceptados" OnClick="btnAceptados_Click" CssClass="btn btn-primary  btn-lg btn-block" runat="server" Text="Aceptados" />
                <br />
            </div>
            <div class="col-sm-3 mb-3">
                <asp:Button ID="btnProgreso" OnClick="btnProgreso_Click" CssClass="btn btn-primary  btn-lg btn-block" runat="server" Text="Progreso" />
                <br />
            </div>
        </div>

    </div>
    <div class="container-fluid">
        <div class="table-responsive">
            <asp:GridView ID="vistaDocumentos" runat="server" CssClass="table table-hover" BorderColor="#E7E7FF" OnRowDeleted="vistaDocumentos_RowDeleted1" OnRowEditing="vistaDocumentos_RowEditing1" OnSelectedIndexChanged="vistaDocumentos_SelectedIndexChanged1" >
                 <AlternatingRowStyle BackColor="#79e0e7" />
                <Columns>
                    <asp:CommandField ButtonType="Image" HeaderText="Descargar" SelectImageUrl="Imagenes/Descargar.png" ShowSelectButton="True" >
                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Top" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Image" EditImageUrl="Imagenes/Aceptar.png" HeaderText="Aceptar" ShowEditButton="True" >
                    <HeaderStyle HorizontalAlign="Center" />
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                    <asp:CommandField ButtonType="Image" DeleteImageUrl="Imagenes/Rechazar.png" HeaderText="Rechazar" InsertImageUrl="Imagenes/Rechazar.png" ShowDeleteButton="True">
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:CommandField>
                </Columns>
                 <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
        </asp:GridView>
        </div>
    </div>
    <div class="container">
        <div class="row">
            <div class="container-fluid">
                <div class="col-sm-3 mb-3">
                    <!-- Button trigger modal -->
                    <button type="button"  class="btn btn-primary  btn-lg btn-block" data-toggle="modal" data-target="#exampleModal">
                        Aceptar
                    </button>
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
                                    <asp:Button ID="Button2"  runat="server" OnClick="Button2_Click" Text="Guardar Cambios" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
                <div class="col-sm-3 mb-3">
                    <!-- Button trigger modal -->
                    <button type="button" class="btn btn-primary btn-lg btn-block" data-toggle="modal" data-target="#exampleModal1">
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
                                    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Guardar Cambios" CssClass="btn btn-primary" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
                </div>
                <div class="col-sm-3 mb-3">
                    <!-- Button trigger modal -->
            <button type="button" class="btn btn-primary btn-lg btn-block"; data-toggle="modal" data-target="#exampleModal2">
                Descargar
            </button>
            <!-- Modal -->
            <div class="modal fade" id="exampleModal2" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel2" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="exampleModalLabel2">Rechazar Documento</h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div class="modal-body">
                            <p>El documento se descargara de GoogleDrive</p>
                            <p>¿Desea Continuar Con La Operación?</p>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="Button5" runat="server" Text="Cerrar" data-dismiss="modal" CssClass="btn btn-secondary" />
                            <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Guardar Cambios" CssClass="btn btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
                    <br />
                </div>
            </div>
        </div>
    </div>    
</asp:Content>
