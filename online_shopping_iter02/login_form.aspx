<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="login_form.aspx.cs" Inherits="online_shopping_iter02.login_form" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
        <div>
        	E-mail Address 
			<asp:TextBox ID="txtbox_email" runat="server" TextMode="Email"></asp:TextBox>
			<br />
			Password
			<asp:TextBox ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
			<br />
            <asp:Label ID="lbl_error" runat="server"></asp:Label>
            <br />
			<asp:Button ID="btn_login" Text="Log-in" runat="server" OnClick="btn_login_Click" />
        	<br />
			<a href="register_form.aspx">Register</a>
			<br />
        </div>
    </form>
</asp:Content>

