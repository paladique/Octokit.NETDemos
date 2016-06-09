<%@ Page Title="Markdown Maker" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="SimpleMarkdownVB._Default"  Async="true" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
            <h2>Write some Markdown!</h2>
            <p style ="margin: 20px 20px">
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtMkd"></asp:TextBox>
            </p>
            <p>
                <asp:Button Text="Render it!" runat="server" CssClass ="btn btn-default" OnClick="Unnamed2_Click" />
            </p>    
    </div>
    <div class="row">
        <asp:Label runat="server" ID ="lblrendered">
            
        </asp:Label>
    </div>


</asp:Content>
