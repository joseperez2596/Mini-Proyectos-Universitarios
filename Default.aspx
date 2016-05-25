<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <br />
        Numero: <asp:TextBox ID="txtNumero" runat="server"></asp:TextBox>
        &nbsp;<p>
            Este numero es:
            <asp:Label ID="txtNaturaleza" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="cmdCalcular" runat="server" OnClick="cmdCalcular_Click" Text="Calcular" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="cmdLimpiar" runat="server" OnClick="cmdLimpiar_Click" Text="Limpiar" />
        </p>
    </form>
</body>
</html>
