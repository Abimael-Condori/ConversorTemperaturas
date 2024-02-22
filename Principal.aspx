<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="ConversorTemperaturas.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Conversor de Temperaturas</title>
    <link rel="stylesheet"  type="text/css" href="ESTILOS/estilo1.css" />
    <script src="SCRIPTS/script.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="pagina">
            <div class="encabezado">
                <h1>Conversor de Temperaturas</h1>
            </div>
            
            <div class="cuerpo">
                <asp:Label ID="LblGCent" runat="server" Text="Grados Centígrados" CssClass="elemento"></asp:Label>
                <asp:TextBox ID="txtGCent" runat="server" CssClass="elemento"></asp:TextBox>
                <asp:Label ID="lblGFar" runat="server" Text="Grados Farenheit" CssClass="elemento"></asp:Label>
                <asp:TextBox ID="txtGFar" runat="server" CssClass="elemento"></asp:TextBox>

                <asp:Button ID="btnCalcular" runat="server" Text="Convertir a..." CssClass="elemento1" OnClick="btnCalcular_Click" />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar"  CssClass="elemento1" OnClick="btnLimpiar_Click" />
            </div>
        </div>
    </form>
</body>
</html>
