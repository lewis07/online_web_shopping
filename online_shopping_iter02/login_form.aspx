<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_form.aspx.cs" Inherits="online_shopping_iter02.login_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
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
</body>
</html>
