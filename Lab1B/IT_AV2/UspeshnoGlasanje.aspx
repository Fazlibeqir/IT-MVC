<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UspeshnoGlasanje.aspx.cs" Inherits="IT_AV2.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Успешно Гласање</h2>
    <h3>Ви благодариме за учеството
во акцијата за избор на најинтересен предмет на ФИНКИ, Вашопт избор беше
        <asp:Label ID="finkiPredmet" runat="server" class="text-success" Text=""></asp:Label>. Резултатите од гласањето ќе ги
добиете по електронска пошта, на
        <asp:Label ID="lblemail" class="text-success" runat="server" Text=""></asp:Label>.</h3>

</asp:Content>
