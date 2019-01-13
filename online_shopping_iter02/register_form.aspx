<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register_form.aspx.cs" Inherits="online_shopping_iter02.register_form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <script>
        function ship_add_keypress() {
            if (document.getElementById("chkbox_billing_add").checked == true)
                document.getElementById("txtbox_billing_add").value =
                    document.getElementById("txtbox_shipping_add").value;
        }

        function left_password_verify() {
            if (document.getElementById("txtbox_password").value !=
                document.getElementById("txtbox_password_verify").value) {
                document.getElementById("lbl_password_verify").style.visibility = "visible";
                document.getElementById("txtbox_password_verify").value = "";
            }
            else {
                document.getElementById("lbl_password_verify").style.visibility = "hidden";
            }
        }

        function changed_billing_add() {
            if (document.getElementById("chkbox_billing_add").checked == true) {
                document.getElementById("txtbox_billing_add").disabled = true;
            }
            else {
                document.getElementById("txtbox_billing_add").disabled = false;
            }
            document.getElementById("txtbox_billing_add").value =
                document.getElementById("txtbox_shipping_add").value;
        }
    </script>

    <form id="register_form" runat="server">
        <div>
            E-mail Address
            <asp:TextBox ID="txtbox_email_add" runat="server" TextMode="Email"></asp:TextBox>
            <br />
            Password
            <asp:TextBox ID="txtbox_password" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            Retype Password
            <asp:TextBox ID="txtbox_password_verify" runat="server" TextMode="Password"
                onblur="left_password_verify()"></asp:TextBox>
            <asp:Label ID="lbl_password_verify" runat="server" 
                Text="Password did not match" style="visibility:hidden;"></asp:Label>
            <br />
            Full Name
            <asp:TextBox ID="txtbox_full_name" runat="server"></asp:TextBox>
            <br />
            Contact No
            <asp:TextBox ID="txtbox_contact_no" runat="server"></asp:TextBox>
            <br />
            Shipping Address
            <asp:TextBox ID="txtbox_shipping_add" runat="server" onkeyup="ship_add_keypress()"></asp:TextBox>
            <br />
            Billing Address
            <asp:TextBox ID="txtbox_billing_add" runat="server"></asp:TextBox>
            <asp:CheckBox ID="chkbox_billing_add" runat="server" Text="Same as shipping address" onchange="changed_billing_add()" />
            <br />
            <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click" />
        </div>
    </form>
</body>
</html>
