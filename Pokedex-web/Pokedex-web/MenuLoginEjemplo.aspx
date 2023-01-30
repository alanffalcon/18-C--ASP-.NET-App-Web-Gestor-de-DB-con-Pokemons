<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="MenuLoginEjemplo.aspx.cs" Inherits="Pokedex_web.MenuLoginEjemplo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1>Te logueaste correctamente</h1>

    <asp:Button ID="btnPagina1" runat="server" Text="Button" onclick="btnPagina1_Click" />
    <asp:Button ID="btnPagina2" runat="server" Text="Button" onclick="btnPagina2_Click" />

</asp:Content>
