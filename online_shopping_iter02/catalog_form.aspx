<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="catalog_form.aspx.cs" Inherits="online_shopping_iter02.catalog_form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="lnk_profile" runat="server" NavigateUrl="profile_form.aspx">User Profile</asp:HyperLink>
            <asp:ImageButton ID="imgbtn_cart" runat="server" ImageUrl="~/cart_icon.png"
                Height="20" Width="20"/>
            <asp:Button ID="btn_logout" runat="server" Text="Log-out" />
            <asp:HyperLink ID="lnk_login" runat="server" NavigateUrl="login_form.aspx">Log-in</asp:HyperLink>
            <br />
            <asp:TextBox ID="txtbox_search" runat="server"></asp:TextBox>
            <asp:Button ID="btn_search" runat="server" Text="Search" OnClick="btn_search_Click" />
            <br />

            <asp:Label ID="lbl_sort" runat="server" Text="Sort By: "/>
            <asp:DropDownList ID="drplst_sort" runat="server" 
                OnSelectedIndexChanged="drplst_sort_SelectedIndexChanged" 
                AutoPostBack="True" >
                <asp:ListItem>Product ID</asp:ListItem>
                <asp:ListItem>Price (Low to High)</asp:ListItem>
                <asp:ListItem>Price (High to Low)</asp:ListItem>
            </asp:DropDownList>
            
            <br />

            <br />

              <div class="col-sm-3" id="div_product_01" runat="server">
    <div class="panel panel-info">
      <div class="panel-heading"><a href="./item.aspx?id=1"><h3 align="center">Gameboy</h3></a></div>
      <div class="panel-body">
          <asp:LinkButton ID="lnk_product_01" runat="server" OnClick="lnk_product_01_Click">Product 1 Name</asp:LinkButton>
                    <br />
                    <asp:Label ID="lbl_prod_01_price" runat="server" Text="P 11.99" Font-Bold="True"/>  
                
          <button type="button" class="btn btn-success">Add to cart</button>
      </div>
    </div>
                </div>
            <div class="col-sm-3" id="div_product_02" runat="server">
    <div class="panel panel-info">
      <div class="panel-heading"><a href="./item.aspx?id=1"><h3 align="center">Gameboy</h3></a></div>
      <div class="panel-body">
          <asp:LinkButton ID="lnk_product_02" runat="server" OnClick="lnk_product_01_Click">Product 1 Name</asp:LinkButton>
                    <br />
                    <asp:Label ID="lbl_prod_02_price" runat="server" Text="P 11.99" Font-Bold="True"/>  
                
          <button type="button" class="btn btn-success">Add to cart</button>
      </div>
    </div>
                </div>

            <div class="col-sm-3" id="div_product_03" runat="server">
    <div class="panel panel-info">
      <div class="panel-heading"><a href="./item.aspx?id=1"><h3 align="center">Gameboy</h3></a></div>
      <div class="panel-body">
          <asp:LinkButton ID="lnk_product_03" runat="server" OnClick="lnk_product_01_Click">Product 1 Name</asp:LinkButton>
                    <br />
                    <asp:Label ID="lbl_prod_03_price" runat="server" Text="P 11.99" Font-Bold="True"/>  
                
          <button type="button" class="btn btn-success">Add to cart</button>
      </div>
    </div>
                </div>

            <div class="col-sm-3" id="div_product_04" runat="server">
    <div class="panel panel-info">
      <div class="panel-heading"><a href="./item.aspx?id=1"><h3 align="center">Gameboy</h3></a></div>
      <div class="panel-body">
          <asp:LinkButton ID="lnk_product_04" runat="server" OnClick="lnk_product_01_Click">Product 1 Name</asp:LinkButton>
                    <br />
                    <asp:Label ID="lbl_prod_04_price" runat="server" Text="P 11.99" Font-Bold="True"/>  
                
          <button type="button" class="btn btn-success">Add to cart</button>
      </div>
    </div>
                </div>

            <div class="col-sm-3" id="div_product_05" runat="server">
    <div class="panel panel-info">
      <div class="panel-heading"><a href="./item.aspx?id=1"><h3 align="center">Gameboy</h3></a></div>
      <div class="panel-body">
          <asp:LinkButton ID="lnk_product_05" runat="server" OnClick="lnk_product_01_Click">Product 1 Name</asp:LinkButton>
                    <br />
                    <asp:Label ID="lbl_prod_05_price" runat="server" Text="P 11.99" Font-Bold="True"/>  
                
          <button type="button" class="btn btn-success">Add to cart</button>
      </div>
    </div>
                </div>

            
            
            
            <asp:Label ID="lbl_no_match" Text="No matches found" runat="server" />
            <asp:Button ID="btn_previous" runat="server" Text="<" />
            <asp:Label ID="lbl_page" runat="server" Text="1" />
            <asp:Button ID="btn_next" runat="server" Text=">" />
        </div>
            </form>
</asp:Content>