<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebCharacterSheetconverter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
    </div>
    <div>
    <asp:FileUpload ID="FileUpload1" runat="server" />

        <div>
        </div>
    </div>

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Open HTML File" />

    <asp:TextBox ID="replaceMe" runat="server" mode="multiline" Height="16px" Width="399px"></asp:TextBox>
    <div>
    </div>

</asp:Content>
