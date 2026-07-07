<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SessionState.aspx.cs" Inherits="StateManagement.SessionState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblCount" runat="server" Text="Count:0"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="lblIncrement" runat="server" Text="Increment" OnClick="lblIncrement_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
