<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_154.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Suma de dos números</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Número 1:
                <asp:TextBox ID="txtNum1" runat="server"></asp:TextBox>
            </p>
            <p>
                Número 2:
                <asp:TextBox ID="txtNum2" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnSumar" runat="server" Text="Sumar" OnClick="btnSumar_Click" />
            </p>
            <p>
                <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>