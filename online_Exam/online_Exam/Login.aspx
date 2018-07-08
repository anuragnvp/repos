<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="online_Exam.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="post">
        <table ><tr><td>Username</td><td><asp:TextBox id="txtUserName" runat="server"></asp:TextBox></td></tr>
            <tr><td>Password</td><td><asp:TextBox id="txtPassword" runat="server"></asp:TextBox></td></tr>
            <tr><td>
                <asp:CheckBox ID="CheckBox1" Text="Remember me" runat="server" /></td>
                <td>
                <asp:Button ID="Button1" runat="server" Text="login" OnClick="Button1_Click" /></td></tr>
            <tr><td>
                <asp:Label ID="lblMessage" runat="server" ></asp:Label></td></tr>
        </table>
        
        <h3>If you are new to here please <a href="Register/SIgnup.aspx">Click here </a>for sign up!</h3>
        <asp:Button ID="Button2" runat="server" Text="redirect" OnClick="Button2_Click" />
    </form>
</body>
</html>
