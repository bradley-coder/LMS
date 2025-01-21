<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmLogin.aspx.cs" Inherits="Project.frmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.5.1/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <br />
    <br />
    <div class="container" style="border-style: solid; border-color: inherit; border-width: medium; width:800px; height: 307px;">
    <form id="form1" runat="server">
        <div style="text-align:center">
        <div>
            
            <asp:Image ID="loginImage" runat="server" ImageUrl="C:\Users\brad8\Documents\New folder\login-935679.png" Height="310px" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="UserName"></asp:Label><br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" class="btn btn-outline-primary" Text="Sign In" />
            <br />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" class="btn btn-outline-pimary" Text="Cancel" />
            <br />
            <asp:PasswordRecovery ID="PasswordRecovery" runat="server" Height="87px"></asp:PasswordRecovery>
            <br />
            <asp:Label ID="lblInvalid" runat="server" Visible="false" Text="Invalid UserName or Password"></asp:Label>
        </div>
    </form>
</body>
</html>
