<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="meu.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Usando AspNet</h2>
            <h3>Entrada de Valores</h3>

            <p>

                <p>
                    <span>Valor 1</span>
            <asp:TextBox ID="txtValor1" runat="server" CssClass="valores"></asp:TextBox>
                </p>
                <p>
                    <span>Valor 2</span>
            <asp:TextBox ID="txtValor2" runat="server" CssClass="valores"></asp:TextBox>
                </p>
                <p>
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
                </p>
                <p>
                    <span>Resultado da Soma:</span>
                    <asp:Label ID="lblSoma" runat="server"></asp:Label>
                </p>
        </div>
        <p>
            <span>Resultado da Subtração:</span>
            <asp:Label ID="lblSubtracao" runat="server" CssClass="resultados"></asp:Label>
        </p>
        <p>
           <span> Resultado da Multiplicação:</span>
            <asp:Label ID="lblMultiplicacao" runat="server" CssClass="resultados"></asp:Label>
        </p>
        <p>
            <span>Resultado da Divisão:</span>
            <asp:Label ID="lblDivisao" runat="server" CssClass="resultados"></asp:Label>
        </p>
        <p>
           <span> Resultado do Módulo:</span>
            <asp:Label ID="lblModulo" runat="server" CssClass="resultados"></asp:Label>
        </p>
    </form>
</body>
</html>
