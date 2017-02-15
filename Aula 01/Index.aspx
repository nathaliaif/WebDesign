<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Usando AspNet</h2>
            <h3>Entrada de Valores</h3>
        <p>&nbsp;</p>
        <p>Valor 1
            <asp:TextBox ID="txtValor1" runat="server"></asp:TextBox>
        </p>
        <p>Valor 2
            <asp:TextBox ID="txtValor2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
        </p>
        <p>Resultado da Soma: <asp:Label ID="lblSoma" runat="server"></asp:Label>
        </p>
            
    </div>
        <p>
            Resultado da Subtração:
            <asp:Label ID="lblSubtracao" runat="server"></asp:Label>
        </p>
        <p>
            Resultado da Multiplicação:
            <asp:Label ID="lblMultiplicacao" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;Reultado da Divisão:
            <asp:Label ID="lblDivisao" runat="server"></asp:Label>
        </p>
        <p>
            Resultado do Módulo:
            <asp:Label ID="lblModulo" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
