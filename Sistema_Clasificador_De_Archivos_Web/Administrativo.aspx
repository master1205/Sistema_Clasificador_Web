<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Administrativo.Master" CodeBehind="Administrativo.aspx.cs" Inherits="Sistema_Clasificador_De_Archivos_Web.Administrativo" %>

<asp:Content runat="server" ContentPlaceHolderID="MainContent">
            <section class="jumbotron" style="background-color: #3da4f9;">
                <div class="container">
                    <h1>Bienvenido</h1>
                    <p>Administracion de Archivos en la nube</p>
                </div>
            </section>
    <div class="container-fluid">
        <div class="table-responsive">
            <asp:GridView ID="vistaDocumentos" runat="server"   CssClass="table table-responsive table-hover" BackColor="white"  BorderWidth="0px" CellPadding="3" OnSelectedIndexChanged="vistaDocumentos_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="#79e0e7" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ItemStyle-Font-Bold="true" ControlStyle-ForeColor="Black"></asp:CommandField>
                </Columns>
                <HeaderStyle BackColor="#0099cc" Font-Bold="False" Font-Italic="False" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" />
            </asp:GridView>
        </div>
    </div>
    <div class="col-sm-4 mb-3">
        <br />
    </div>
    <div class="col-sm-4 mb-3">
        <br />
        <asp:Button ID="btnRegistra" OnClick="btnRegistra_Click" runat="server" style="background:#0099cc;" Text="Guardar" CssClass="btn btn-primary btn-block" />
    </div>
</asp:Content>
