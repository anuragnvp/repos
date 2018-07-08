﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewExample.aspx.cs" Inherits="GridView.GridViewExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <sortedascendingcellstyle backcolor="#FFF1D4" />
                <sortedascendingheaderstyle backcolor="#B95C30" />
                <sorteddescendingcellstyle backcolor="#F1E5CE" />
                <sorteddescendingheaderstyle backcolor="#93451F" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
