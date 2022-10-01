<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCharacterSheetconverter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div id ="characterConvert">
        <!-- page content-->

        <h1>Character Sheet Converter</h1>
        <p>To start, download the character sheet html file. Fill it out using the Firefox Browser. Note that other browsers such as Chrome and Edge will not be able to save The form data.</p>

        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Download HTML File"  />

        <p>Once you have filled out your character, save the html file. Then click the browse button to find and upload your character sheet html file.</p>

        <asp:FileUpload ID="FileUpload1" runat="server" Width="564px" Height="26px" />

        <p>Once your character sheet html file is selected, click on the extract data button. The information from your character sheet will be seperated by "|" and placed in the text box below. Click into the text box and press ctrl-a anc ctrl-c to copy it. Then paste it into the text input field in the VRChat map and press the Run button in game.</p>

        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Extract Data" />

        <asp:TextBox ID="replaceMe" runat="server" mode="multiline" Height="47px" Width="554px"></asp:TextBox>
    </div>

</asp:Content>
