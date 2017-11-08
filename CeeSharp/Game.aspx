<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Game.aspx.cs" Inherits="CeeSharp.Game" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="text-center">
        <h1>Game</h1>

        <!-- Intervals section -->
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">Intervals</h3>
            </div>
            <div class="panel-body">
                <asp:LinkButton
                    ID="linkbtn_8ve"
                    runat="server"
                    class="buttonLevelSelect"
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 0: Octaves</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_min2"
                    runat="server"
                    class="buttonLevelSelect"                    
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click"> 
                    <span class="tooltiptext">Level 1: Minor Seconds</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_maj2"
                    runat="server"
                    class="buttonLevelSelect"                 
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">                  
                    <span class="tooltiptext">Level 2: Major Seconds</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_min3"
                    runat="server"
                    class="buttonLevelSelect"                
                    height="50"
                    width = "50" 
                    onClick="LevelSelectBtn_Click" >
                    <span class="tooltiptext">Level 3: Minor Thirds</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_maj3"
                    runat="server"
                    class="buttonLevelSelect"           
                    height="50"
                    width = "50" 
                    onClick="LevelSelectBtn_Click" >                    
                    <span class="tooltiptext">Level 4: Major Thirds</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_p4"
                    runat="server"
                    class="buttonLevelSelect"          
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 5: Perfect Fourths</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_min5"
                    runat="server"
                    class="buttonLevelSelect"         
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 6: Minor Fifths (Tritones)</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_p5"
                    runat="server"
                    class="buttonLevelSelect"          
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 7: Perfect Fifths</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_min6"
                    runat="server"
                    class="buttonLevelSelect"            
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 8: Minor Sixths</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_maj6"
                    runat="server"
                    class="buttonLevelSelect"             
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 9: Major Sixths</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_min7"
                    runat="server"
                    class="buttonLevelSelect"              
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 10: Minor Sevenths</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_maj7"
                    runat="server"
                    class="buttonLevelSelect"                                 
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 11: Major Sevenths</span>
                </asp:LinkButton>
            </div>
        </div>
        
        <!--- Arpeggios Section -->
        <div class="panel panel-default">
            <div class="panel-heading">
                <h3 class="panel-title">Arpeggios</h3>
            </div>
            <div class="panel-body">
                <asp:LinkButton
                    ID="linkbtn_arp_maj7"
                    runat="server"
                    class="buttonLevelSelect"
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 0: Maj7 Arpeggio</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_arp_min7"
                    runat="server"
                    class="buttonLevelSelect"                                                   
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 1: Min7 Arpeggio</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_arp_m7b5"
                    runat="server"
                    class="buttonLevelSelect"                               
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">
                    <span class="tooltiptext">Level 2: Min7b5 Arpeggio</span>
                </asp:LinkButton>
                <asp:LinkButton
                    ID="linkbtn_arp_dom7"
                    runat="server"
                    class="buttonLevelSelect"                           
                    height="50"
                    width = "50"
                    onClick="LevelSelectBtn_Click">                
                    <span class="tooltiptext">Level 3: Dom7 Arpeggio</span>
                </asp:LinkButton>
            </div>
        </div>
        <br />
    </div>
</asp:Content>
