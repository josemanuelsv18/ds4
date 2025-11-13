<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio_161.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .cal {
            position: absolute;
            top: 50px;
            left: 100px;
            right: 400px;
            height: 500px;
            bottom: 100px;
            background-color: dodgerblue;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="cal">
            <asp:Label ID="label1" Text="CALCULADORA BASICA" runat="server" Style="margin-left: 50px"
                Font-Bold="True" Font-Italic="False" ForeColor="white" Font-Size="25px"></asp:Label>
            <asp:TextBox ID="t" runat="server" Style="margin-left: 50px; margin-top: 24px;"
                Width="75px" Height="40px"></asp:TextBox>
            <asp:Button ID="b1" Text="1" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b1_Click"/>
            <asp:Button ID="b2" Text="2" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b2_Click"/>
            <asp:Button ID="b3" Text="3" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b3_Click"/>
            <asp:Button ID="b4" Text="4" runat="server" Height="75px" Style="margin-left: 0px; margin-top: 90px;" Width="75px" OnClick="b4_Click"/>
            <asp:Button ID="b5" Text="5" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b5_Click"/>
            <asp:Button ID="b6" Text="6" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b6_Click"/>
            <asp:Button ID="b7" Text="7" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b7_Click"/>
            <asp:Button ID="b8" Text="8" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b8_Click"/>
            <asp:Button ID="b9" Text="9" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b9_Click"/>
            <asp:Button ID="b0" Text="0" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="b0_Click"/>
            <asp:Button ID="bsuma" Text="+" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="bsuma_Click"/>
            <asp:Button ID="bresta" Text="-" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="bresta_Click"/>
            <asp:Button ID="bmulti" Text="*" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="bmulti_Click"/>
            <asp:Button ID="bdiv" Text="/" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="bdiv_Click"/>
            <asp:Button ID="bigual" Text="=" runat="server" Height="75px" Style="margin-left: 0px"
                Width="75px" OnClick="bigual_Click"/>
        </div>
    </form>
</body>
</html>
