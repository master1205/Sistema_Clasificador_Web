<%@ Page Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="RegistrarDocumentos.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.RegistrarDocumentos" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    <div class="container-fluid">
            <ol class="breadcrumb" style="background-color:#B8D8E0">
                <li><a href="#">Inicio</a></li>
                <li class="active" style="color:black">Documentos</li>
                <li class="active"style="font-size:large; color:black">Registrar Documentos</li>
            </ol>
    </div>
        <div class="container">
        <br />
        <div class="row">
            <div class="col-md-12"">
                <div class="panel panel-default ">
                    <div class="panel-heading text-center" style="background:#0099cc; font-size:x-large">Documentos</div>
                    <div class="panel-body">
                        <p><asp:Label ID="Label1" runat="server" Text="Remitente" CssClass="control-label"></asp:Label></p>
                        <p><asp:TextBox ID="RemitenteTxt" runat="server" CssClass="form-control btn-block" placeHolder="Remitente" AutoCompleteType="Disabled"></asp:TextBox></p>
                        <p><asp:Label ID="Label2" runat="server" Text="Asunto" CssClass="control-label"></asp:Label></p>
                        <p><asp:TextBox ID="AsuntoTxt" runat="server" CssClass="form-control btn-block" placeHolder="Asunto" AutoCompleteType="Disabled"></asp:TextBox></p>
                        <p><asp:Label ID="Label3" runat="server" Text="Descripción" CssClass="control-label"></asp:Label></p>
                        <p><asp:TextBox ID="DescripcionTxt" runat="server" CssClass="form-control btn-block" placeHolder="Descripción" AutoCompleteType="Disabled"></asp:TextBox></p>
                        <div class="row">
                            <div class="col-sm-4 mb-3">
                                <p>Area</p>
                                <p><asp:DropDownList ID="ComboArea" runat="server" CssClass="form-control btn btn-block"></asp:DropDownList></p>
                            </div>
                            <div class="col-sm-4 mb-3">
                                <p>Clasificador</p>
                                <p><asp:DropDownList ID="ComboClasificador" AutoPostBack="true" OnSelectedIndexChanged="ComboClasificador_SelectedIndexChanged"  runat="server" CssClass="form-control btn btn-block" ></asp:DropDownList></p>
                            </div>
                            <div class="col-sm-4 mb-3">
                                <p>SubClasificador</p>
                                <p><asp:DropDownList ID="ComboSubClasificador" runat="server" CssClass="form-control btn btn-block"></asp:DropDownList></p>
                            </div>
                        </div>
                        <div class="row">                            
                            <div class="col-sm-4 mb-3">
                                <p>Copia Para:</p>
                                <p><asp:DropDownList ID="ComboCopia" runat="server" CssClass="form-control btn btn-block"></asp:DropDownList></p>
                            </div>
                            <div class="col-sm-4 mb-3">
                                <p>Subir Archivo</p>
                                <asp:FileUpload ID="file" runat="server" type="file" accept="application/pdf" CssClass="form-control btn-block" />
                            </div>
                            <div class="col-sm-4 mb-3">
                                <!-- Button trigger modal -->
                                <br />
                                <p></p>
                    <button type="button"  style="background:#0099cc;" class="btn btn-primary btn-block" data-toggle="modal" data-target="#exampleModal">
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
                                    <p>¿Desea Registra el Documento?</p>
                                </div>
                                <div class="modal-footer">
                                    <asp:Button ID="Button1" runat="server" Text="Cerrar" data-dismiss="modal" CssClass="btn btn-secondary" />
                                    <asp:Button ID="btnRegistrar" runat="server" Text="Subir Archivos" CssClass="btn btn-primary" OnClick="btnRegistrar_Click" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <br />
             </div>
           </div>                        
         </div>
       </div>
     </div>
   </div>
 </div>
</asp:Content>