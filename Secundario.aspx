<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secundario.aspx.cs" Inherits="ConversorTemperaturas.Secundario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblGradosCentigrados" runat="server" Text="º Centígrados"></asp:Label>
            <asp:TextBox ID="txtGradosCentigrados" runat="server" Width="60px"></asp:TextBox>
            <asp:TextBox ID="txtGradosFarenheit" runat="server" Width="66px"></asp:TextBox>
            <asp:Button ID="btnConvertir" runat="server" OnClick="btnConvertir_Click" Text="Convertir ºC a ºF" />
        </div>
    </form>
</body>
</html>
