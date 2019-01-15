<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="cart_form.aspx.cs" Inherits="online_shopping_iter02.cart_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div class="main_div">
            <div id="div_table" runat="server">
                <div class="cart_header">
                    <p class="header_name">PRODUCT NAME (Quantity)</p>
                    <p class="header_price">PRICE</p>
                </div>

                <div id="purchase_01" class="div_purchase_odd" runat="server">
                    <asp:Label ID="lbl_name_01" Text="Purchase 1 Name (1)" class="lbl_name" runat="server" />
                    <asp:Button ID="btn_remove_01" Text="X" class="btn_remove" runat="server" OnClick="btn_remove_01_Click" />
                    <asp:Label ID="lbl_price_01" Text="P 12.34" class="lbl_price" runat="server" />                
                </div>
                <div id="purchase_02" class="div_purchase_even" runat="server">
                    <asp:Label ID="lbl_name_02" Text="Purchase 2 Name (2)" class="lbl_name" runat="server" />
                    <asp:Button ID="btn_remove_02" Text="X" class="btn_remove" runat="server" OnClick="btn_remove_02_Click" />
                    <asp:Label ID="lbl_price_02" Text="P 56.78" CssClass="lbl_price" runat="server" />
                </div>
                <div id="purchase_03" class="div_purchase_odd" runat="server">
                    <asp:Label ID="lbl_name_03" Text="Purchase 3 Name (1)" class="lbl_name" runat="server" />
                    <asp:Button ID="btn_remove_03" Text="X" class="btn_remove" runat="server" OnClick="btn_remove_03_Click" />
                    <asp:Label ID="lbl_price_03" Text="P 90.12" CssClass="lbl_price" runat="server" />
                </div>
                <div id="purchase_04" class="div_purchase_even" runat="server">
                    <asp:Label ID="lbl_name_04" Text="Purchase 4 Name (3)" class="lbl_name" runat="server" />
                    <asp:Button ID="btn_remove_04" Text="X" class="btn_remove" runat="server" OnClick="btn_remove_04_Click" />
                    <asp:Label ID="lbl_price_04" Text="P 34.56" CssClass="lbl_price" runat="server" />
                </div>
                <div id="purchase_05" class="div_purchase_odd" runat="server">
                    <asp:Label ID="lbl_name_05" Text="Purchase 5 Name (1)" class="lbl_name" runat="server" />
                    <asp:Button ID="btn_remove_05" Text="X" class="btn_remove" runat="server" OnClick="btn_remove_05_Click" />
                    <asp:Label ID="lbl_price_05" Text="P 78.90" CssClass="lbl_price" runat="server" />
                </div>

                <div class="total_div">
                    <asp:Button ID="btn_back" Text="<" class="btn_page" runat="server" OnClick="btn_back_Click" />
                    <asp:Button ID="btn_next" Text=">" class="btn_page" runat="server" OnClick="btn_next_Click" />
                    <asp:Label ID="lbl_total" Text="P 123.45" class="lbl_total" runat="server" />
                    <p class="total_label">TOTAL</p>
                </div>

                <div>
                    <asp:Button ID="btn_checkout" Text="Check-out" runat="server" 
                        style="float: right;"/>
                </div>
            </div>
        </div>

    </form>
    <style>
        .cart_header {
            height: 30px;
        }
        .header_name {
            float: left;
            font-weight: bold;
        }
        .header_price {
            float: right;
            font-weight: bold;
            margin-right: 13px;
        }

        .main_div {
            width: 400px;
            margin: 0 auto;
        }

        .div_purchase_odd {
            height: 30px;
            background-color: #CFCFC4;
        }
        .div_purchase_even {
            height: 30px;
        }
        .lbl_name {
            float: left;
        }
        .lbl_price {
            float: right;
        }
        .btn_remove {
            margin-left: 5px;
            float: right;
        }

        .total_div {
            height: 30px;
            background-color: #77DD77;
        }
        .btn_page {
            float: left;
        }
        .lbl_total {
            float: right;
            margin-right: 13px;
        }
        .total_label {
            float: right;
            margin-right: 5px;
            font-weight: bold;
        }
    </style>
</asp:Content>