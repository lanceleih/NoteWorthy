<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Achievements.aspx.cs" Inherits="CeeSharp.Achievements" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
            <div id="achievements" runat="server">
                
                <div class="row">
                    <div class="col-xs-6" style="left: 0px; top: 0px; width: 34%" >
                        <asp:Image ID="ProfilePic" CssClass="pull-right" runat="server" Height="110px" ImageUrl="~/Icons/003-profile.png" />
                    </div>
                    <div class="col-xs-6">
                        <asp:Label ID="Label1" runat="server" style="font-size: medium" Text="Your Achievements"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <ul class="list-inline">
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                            <li><img src="Icons/002-success.png" height="75" /></li>
                        </ul>

                    </div>
                </div>
                
            </div>
        </div>
</asp:Content>
