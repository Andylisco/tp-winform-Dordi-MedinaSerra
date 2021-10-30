<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Carrito_Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--pone un separador-->
    <hr />

    <asp:GridView ID="dgvArticulos" runat="server" style="table-layout"></asp:GridView>

    <div>
        <a href="/ArticuloForm">AGREGAR ARTICULO</a>
    </div>

</asp:Content>
