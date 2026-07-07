<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="StateManagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCount" runat="server" Text="Count"></asp:Label>
            <asp:Button ID="btnIncrement" runat="server" Text="Increment" OnClick="btnIncrement_Click" />   
        </div>
    </form>
</body>
</html>
