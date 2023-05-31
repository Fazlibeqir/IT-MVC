<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Najava.aspx.cs" Inherits="IT_AV2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="continer">

        <asp:Table ID="Table1" runat="server" CellPadding="100" CellSpacing="0">

            <asp:TableRow>
                <asp:TableCell>Корисничко име</asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="name" runat="server"></asp:TextBox>

                </asp:TableCell>
                <asp:TableCell>
                    <asp:RequiredFieldValidator ID="nameVal"
                        class="text-danger"
                        runat="server"
                        ControlToValidate="name"
                        ErrorMessage="Внесете име"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator runat="server"
                        ID="regexKi"
                        class="text-danger"
                        ControlToValidate="name"
                        ValidationExpression="\S*[\^!-]\S*"
                        ErrorMessage="Невалиден Формат"></asp:RegularExpressionValidator>
                </asp:TableCell>

            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                       Лозинка  
                </asp:TableCell>
                <asp:TableCell>
                    <asp:TextBox ID="password" type="password" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1"
                        runat="server"
                        class="text-danger"
                        ControlToValidate="password"
                        ErrorMessage="Внесете лозинка"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2"
                        runat="server"
                        class="text-danger"
                        ControlToValidate="password"
                        ValidationExpression="^[a-zA-Z0-9]{8,18}$"
                        ErrorMessage="Внеси Лозинка"></asp:RegularExpressionValidator>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                      Email:
                </asp:TableCell>
                <asp:TableCell>

                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell>
                    <asp:RequiredFieldValidator ID="emailVal"
                        runat="server"
                        class="text-danger"
                        ControlToValidate="email"
                        ErrorMessage="Внесете емаил"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                        runat="server"
                        ControlToValidate="email"
                        class="text-danger"
                        ErrorMessage="Невалиден формат"
                        ValidationExpression="\w+@\w+\.\w+"></asp:RegularExpressionValidator>

                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>
                    <asp:Button ID="button" runat="server" Text="Најавете се" OnClick="button_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>

    </div>
</asp:Content>
