<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="product_form.aspx.cs" Inherits="online_shopping_iter02.product_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="lnkbtn_profile" Text="User Profile" runat="server" />
            <asp:ImageButton ID="imgbtn_cart" ImageUrl="~/cart_icon.png" Height="20" 
                Width="20" runat="server" />
            <asp:Button ID="btn_logout" Text="Log-out" runat="server" />
            <asp:LinkButton ID="lnkbtn_login" Text="Log-in" runat="server" 
                OnClick="lnkbtn_login_Click" />

            <br />

            <asp:Label ID="lbl_name" Text="Product Name" Font-Bold="True" runat="server" />
            <br />
            <asp:Label ID="lbl_price" Text="P 12.34" runat="server" />
            
            <br />

            <asp:Button ID="btn_minus" Text="-" runat="server" OnClick="btn_minus_Click" />
            <asp:Label ID="lbl_amount" Text="1" runat="server" />
            <asp:Button ID="btn_plus" Text="+" runat="server" OnClick="btn_plus_Click" />
            
            <br />
            <asp:Button ID="btn_add" Text="Add to Cart" runat="server" OnClick="btn_add_Click" />
        </div>
    </form>
</ asp:Content>
