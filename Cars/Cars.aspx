<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="Cars.Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 368px">
    <form id="form1" runat="server">
        <div>Make</div>
        <asp:TextBox ID="txtMake" runat="server"></asp:TextBox>
        <div>Model</div>
        <asp:TextBox ID="txtModel" runat="server"></asp:TextBox>
        <div>Year</div>
        <asp:TextBox ID="txtYear" runat="server"></asp:TextBox>
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="margin-bottom: 20px" Text="Add" />
            <asp:DropDownList ID="ddlCars" runat="server" OnSelectedIndexChanged="ddlCars_IndexChanged" AutoPostBack="true"
                style="font-family: 'Courier New', Courier, monospace">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
