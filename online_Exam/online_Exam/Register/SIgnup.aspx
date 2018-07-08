<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SIgnup.aspx.cs" Inherits="online_Exam.SIgnup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
        <div id="Header"><h1>Please fill your detail's for signup</h1></div>
        <div>
        <table><tr><td>
        <asp:Label ID="lbl_Name" runat="server" Text="Enter your Name:"></asp:Label></td>
        <td><asp:TextBox ID="TextBox_Fname" runat="server"></asp:TextBox>
            <asp:Label ID="lblFNaneError" runat="server" ></asp:Label></td>
        <td><asp:TextBox ID="TextBox_Lname" runat="server"></asp:TextBox>
            <asp:Label ID="lblLNaneError" runat="server" ></asp:Label></td></tr>
            <tr><td>
                <asp:RadioButton ID="RadioButton1" Checked="true" GroupName="gender" text="Male" runat="server" />
                <asp:RadioButton ID="RadioButton2" text="Female" GroupName="gender" runat="server" />
                <asp:RadioButton ID="RadioButton3" text="Unknown" GroupName="gender" runat="server" />
            </td></tr>
           <tr><td><asp:Label ID="lbl_Email" runat="server" Text="Enter your Email:"></asp:Label>
               </td>
        <td><asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox><asp:Label ID="lblEmailError" runat="server" ></asp:Label></td></tr>
         <tr><td><asp:Label ID="lbl_Contact" runat="server" Text="Contact number"></asp:Label></td>
             <td><asp:TextBox ID="TextBox_Contact" runat="server"></asp:TextBox><asp:Label ID="lblContacError" runat="server" ></asp:Label></td>
         </tr>
            <tr>
                <td>
                    <asp:Label ID="lblB_Password" runat="server" Text="Password" ></asp:Label></td>
                
                <td>
                    <asp:TextBox ID="TextBox_Password" runat="server" TextMode="Password"></asp:TextBox><asp:Label ID="lblPasswordError" runat="server" ></asp:Label></td>
            </tr>
                    <tr><td>
                <asp:Label ID="lbl_CnfPassword" runat="server" Text="Confirm Password" ></asp:Label></td>
                        <td><asp:TextBox ID="TextBox_CnfPassword" runat="server" TextMode="Password"></asp:TextBox><asp:Label ID="lblCnfPasswordError" runat="server" ></asp:Label></td></tr>
            <tr><td>
                <asp:Button ID="Button_Submit" runat="server" Text="Submit" OnClick="Button_Submit_Click1" /></td></tr>
            </table></div>
         </form>
</body>
</html>
