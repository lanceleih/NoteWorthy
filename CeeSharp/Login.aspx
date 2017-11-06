<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.cs" Inherits="CeeSharp.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <div id="login" runat="server" class="col-md-2 col-md-offset-5">
                <asp:Label ID="Label1" runat="server" style="font-size: large" Text="Login"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server">username</asp:TextBox>
                <br />
                <br />
                <asp:TextBox ID="TextBox2" runat="server">password</asp:TextBox>
                <br />
                <br />
                <asp:Button ID="LoginBtn" CssClass="btn btn-success btn-lg" runat="server" style="font-size: small" Text="Login" />
            </div>
        </div>
</asp:Content>
