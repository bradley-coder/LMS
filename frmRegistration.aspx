<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmRegistration.aspx.cs" Inherits="Project.frmRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
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
    <div class="container" style="border:solid; width:800px;">
    <form id="frmRegistration" autocomplete="off" runat="server">
        <div style="text-align:center">
        <div>            
            <asp:Label ID="lblName" runat="server" Text="Name:"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" class="form-control"  runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="lblSurName"  runat="server" Text="SurName:"></asp:Label>
            <br />
            <asp:TextBox ID="txtSurName" class="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmail" class="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox ID="txtPassword" class="form-control" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblUserRole" runat="server" Text="User Role Description"></asp:Label>
            <br />
            <asp:DropDownList ID="cmbUserRole" class="form-control" runat="server"></asp:DropDownList>
            <br />
            <asp:Button ID="btnSubmit" runat="server"  Onclick="btnSubmit_Click" class="btn btn-outline-primary" Text="Submit/Register"/>
            <br />
            <asp:Label ID="lblMessage" runat="server" Text="Already Have an account? Click SIgn In"></asp:Label>
            <br />
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" class="btn btn-outline-primary" Text="Sign In"  />
            <br />
            <asp:Label ID="lblRegistrationSuccess" runat="server" Visible="false" style="color:darkblue" Text="You have Successfully Registered!"></asp:Label>
            <br />
            <asp:Label ID="lblRegistrationFailed" runat="server" Visible="false" style="color:red" Text="Registration Failed!Please try Again"></asp:Label>
        </div>
    </form>
        </div>
</body>
</html>
