<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BrittishCouncil.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    
    <style>
		#body {
			max-width: 700px
		}
	</style>
    
    <H2>Lets get you logged in!</H2>
            <table class="form">
            <tr>
                <td><h3>Email Address</h3></td>
                <td><asp:TextBox ID="TextBoxUserName" runat="server" MaxLength="1000"></asp:TextBox><td>
            </tr>
            <tr>
                <td></td>
                <td><h4><asp:Label ID="LabelAlertEmail" runat="server" Text=" "></asp:Label></h4></td>
            </tr>
            <tr>
                <td><h3>Password</h3></td>
                <td><asp:TextBox ID="TextBoxPassword" runat="server" MaxLength="1000" TextMode="Password"></asp:TextBox></td>
            </tr>
            <tr>
                <td></td>
                <td><h4><asp:Label ID="LabelAlertPassword" runat="server" Text=" "></asp:Label></h4></td>
            </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click" /></td>
            </tr>
                </td>
            </tr>
        </table>
</asp:Content>
