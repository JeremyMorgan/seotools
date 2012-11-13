<%@ Page Title="" Language="C#" MasterPageFile="~/seotools.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Seotools.server_header_checker.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Title" runat="server">Server Header Checker
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <meta name="description" content="This is a free tool to check your server headers. You can check your expires settings and look for malformed header information, both of which can affect search engine crawlers.">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <h2>Server Header Checker</h2>
        <p>This is a tool to check your server headers. You can check your expires settings and look for malformed header information, both of which can affect search engine crawlers.</p>
            <label>Your URL:</label>
                <asp:TextBox ID="WebsiteUrl" runat="server" Columns="50" Width="300px"></asp:TextBox>
            <ul class="button-group radius">
                <asp:Button ID="Button1" runat="server" Text="Submit" class="button radius" TabIndex="1"/>
            </ul>
    <asp:Label ID="LabelDisplay" runat="server"></asp:Label>
    </form>
</asp:Content>
