<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="InGame.aspx.cs" Inherits="CeeSharp.InGame" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--
        COMP4952 Project
        Author: Teah Elaschuk

        InGame page: Work in progress
        displays the game type and level at the moment
    -->
    <div class="container text-center">
        <asp:Label ID="Label_title" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Table ID="Table_fretboard" class="fretboard" runat="server" >
        </asp:Table>
    </div>
    <br />
    <br />
    <div class="container">       
        <asp:Label ID="Label_tprevious" runat="server" Text="Current Note: "></asp:Label>
        <asp:Label ID="Label_previous" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label_ttarget" runat="server" Text="Target: "></asp:Label>
        <asp:Label ID="Label_target" runat="server" Text=""></asp:Label>
    </div>

   
</asp:Content>

