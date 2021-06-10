<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MembersMain.aspx.cs" Inherits="SessionManagement.MembersMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member's Main Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Member's Main Page</h2>
            <asp:Label ID="lblUser" runat="server" Font-Size="Large" />
            <div style="float: right; width: 300px; padding: 5px; text-align: center;">
                <asp:Button ID="btnLogIn" runat="server" Text="Next Page" OnClick="NextPage_Click" />
            </div>

        </div>
    </form>
</body>
</html>
