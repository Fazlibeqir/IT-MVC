<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Glasaj.aspx.cs" Inherits="IT_AV2.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="continer">

        <asp:Image ID="finki" runat="server" src="C:\Users\Beqir\Desktop\finki.png" />
        <div>
            <asp:ListBox ID="listProf" runat="server" Visible="false"></asp:ListBox>
            <asp:Label ID="lblProfesor" runat="server" Text=""></asp:Label>
        </div>
        <div>
            <asp:ListBox ID="lbPredmeti" runat="server" OnSelectedIndexChanged="lbPredmeti_SelectedIndexChanged" AutoPostBack="True"></asp:ListBox>
            <asp:ListBox ID="lbKrediti" runat="server"></asp:ListBox>
        </div>
        <asp:Button ID="voteButton" runat="server" Text="Гласајте" OnClick="vote" />
        <hr />
        <asp:Table ID="table" runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    Предмет:  
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox ID="addDelPredmeti" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Кредити:
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox ID="addDelKrediti" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="add" runat="server" Text="Додади" OnClick="add_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button ID="delete" runat="server" Text="Избриши" OnClick="delete_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
            </asp:TableRow>
            <asp:TableRow></asp:TableRow>
        </asp:Table>
    </div>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>

        </asp:ListItem>
    </asp:RadioButtonList>

    <asp:TextBox ID="TextBox1" runat="server"/>

</asp:Content>
