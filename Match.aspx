<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Match.aspx.cs" Inherits="Exercice.Match" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Calenderier</h2>
            <h2>Botola pro 2021</h2>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" Visible="False"></asp:Calendar>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <h3>Changer la date et click sur le button pour le modifier</h3>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Changer Date" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
