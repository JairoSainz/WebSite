<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="proyectoFinal.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1300px;
            border-collapse: collapse;
            height: 134px;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style22 {
            width: 276px;
            height: 36px;
        }
        .auto-style23 {
            width: 277px;
            height: 36px;
        }
        .auto-style26 {
            width: 276px;
            height: 37px;
        }
        .auto-style27 {
            width: 277px;
            height: 37px;
        }
        .auto-style30 {
            height: 36px;
            width: 364px;
        }
        .auto-style31 {
            height: 36px;
            width: 365px;
        }
        .auto-style32 {
            height: 37px;
            width: 364px;
        }
        .auto-style33 {
            height: 37px;
            width: 365px;
        }
        .auto-style34 {
            width: 277px;
            height: 37px;
            text-align: right;
        }
        .auto-style35 {
            width: 277px;
            height: 36px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="3" class="auto-style1">
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style31">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style35">
                        <asp:Label ID="Label1" runat="server" Text="Usuario"></asp:Label>
                    </td>
                    <td class="auto-style30">
                        <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style31">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style34">
                        <asp:Label ID="Label2" runat="server" Text="Contraseña"></asp:Label>
                    </td>
                    <td class="auto-style32">
                        <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style33">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style26">&nbsp;</td>
                    <td class="auto-style27">&nbsp;</td>
                    <td class="auto-style32">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Entrar" />
                    </td>
                    <td class="auto-style33">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
