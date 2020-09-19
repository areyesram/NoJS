<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List.aspx.cs" Inherits="WebApplication2.Entry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" EmptyDataText="[No data. Add some.]"></asp:GridView>
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
    </form>
</body>
</html>
