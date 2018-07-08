<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DEMO.aspx.cs" Inherits="WebApplication2.DEMO" %>
<--%@ Register src="~/MyNewControl.ascx" TagPrefix="TWebControl" TagName="WebControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <TWebControl:WebControl ID="Header" runat="server"></TWebControl:WebControl>

        </div>
     </form>
</body>
</html>
