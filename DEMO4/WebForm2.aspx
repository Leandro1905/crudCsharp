<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="DEMO4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID<br />
            <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
            <br />
            <br />
            NOMBRE<br />
            <asp:TextBox ID="TxtNombre" runat="server" Width="324px"></asp:TextBox>
            <br />
            <br />
            BARRIO<br />
            <asp:TextBox ID="TxtBarrio" runat="server" Width="323px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnGrabar" runat="server" OnClick="BtnGrabar_Click" Text="GRABAR" Width="99px" />
        </div>
    </form>
</body>
</html>
