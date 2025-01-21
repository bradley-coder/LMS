<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHome.aspx.cs" Inherits="Project.frmHome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-image: url('C:\Users\brad8\Documents\New folder\SmartCoding Background Image.jpg');" >
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnRegistration" runat="server" Text="Register" OnClick="btnRegistration_Click" />
            <asp:Button ID="btnSignIn" runat="server" Text="Sign In" OnClick="btnSignIn_Click" />
            
        </div>
    </form>
</body>
</html>
