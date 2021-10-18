<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ArticuloForm.aspx.cs" Inherits="Carrito_Web.ArticuloForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
        .DivMargin {
            margin: 10px;
        }
        
    </style>

    <div class="DivMargin">
        <asp:Label ID="lbl_Codigo" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="txt_Codigo" runat="server"></asp:TextBox>
    </div>
    <div class="DivMargin">
        <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="txt_Nombre" runat="server"></asp:TextBox>
    </div>
    <div class="DivMargin">
        <asp:Label ID="lbl_Descripcion" runat="server" Text="Descripcion"></asp:Label>
        <asp:TextBox ID="txt_Descripcion" runat="server"></asp:TextBox>
    </div>
    <div class="DivMargin">
        <asp:Label ID="lbl_Categoria" runat="server" Text="Categoria"></asp:Label>
        <asp:DropDownList ID="cbx_Categoria" runat="server"></asp:DropDownList>
    </div>
    <div class="DivMargin">
        <asp:Label ID="lbl_Marca" runat="server" Text="Marca"></asp:Label>
          <asp:DropDownList ID="cbx_Marca" runat="server"></asp:DropDownList>
    </div>
    <div class="DivMargin">
        <asp:Label ID="lbl_Precio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="txt_Precio" runat="server"></asp:TextBox>
    </div>
     <div class="DivMargin">
        <asp:Label ID="lbl_URLImagen" runat="server" Text="URL Imagen"></asp:Label>
        <asp:TextBox ID="txt_URLImagen" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Button Text="Grabar Articulo" ID="btnGrabar" OnClick="btnGrabar_Click" runat="server" />
    </div>
    

</asp:Content>
