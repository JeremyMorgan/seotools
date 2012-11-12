<%@ Page Title="" Language="C#" MasterPageFile="~/seotools.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="seotools.blog_ping.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Title" runat="server">Blog Ping Utility</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
    <meta name="title" content="Blog Ping Utility - Jeremy's SEO Tools" />
    <meta name="description" content="Use this utility to ping RPC Update services to let them know you've updated your blog." />
    <link rel="image_src" href="http://seotools.ironfoundry.me/images/blog-ping.jpg" />
    <div class="row">
        <div class="six columns">
            <h2>Blog Ping Utility</h2>
            <p>Use this utility to ping RPC Update services to let them know you've updated your blog.</p>
            <p>You only need to use the base URL. Please don't abuse this.</p>
            <asp:Label ID="LabelMessage" runat="server" Text="" ></asp:Label>
            <p>
                <label>Your Website Name</label>
                <asp:TextBox ID="WebsiteName" runat="server"></asp:TextBox>
                <label>Your URL:</label>
                <asp:TextBox ID="WebsiteUrl" runat="server"></asp:TextBox>           
            </p>
            <ul class="button-group radius">
                <asp:Button ID="Button1" runat="server" Text="Submit" class="button radius"/>
            </ul>
        </div>
    </div>
        <div class="row">
        <asp:Panel ID="ResultPanel" runat="server">
            <div class="six columns">
            <asp:Label ID="LabelResults" runat="server" Text=""></asp:Label>
            </div>            
        </asp:Panel>
            
    </div>
</form>
</asp:Content>
