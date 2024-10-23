<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModificarMedico.aspx.cs" Inherits="Vistas.ModificarMeidco" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 214px;
        }
        .auto-style3 {
            width: 100%;
            height: 158px;
        }
        .auto-style4 {
            width: 296px;
        }
        .auto-style5 {
            width: 211px;
        }
        .auto-style6 {
            width: 283px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/VistaMedico.aspx">Volver</asp:LinkButton>
                    </td>
                    <td class="auto-style5">&nbsp;</td>
                    <td>
                    <asp:Label ID="LblUsuarioLogueado" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Modificar Usuario y Contraseña de Medico"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style3">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ingresar Usuario Nuevo:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtUsuarioNuevo" runat="server" Width="220px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUsuarioNuevo" runat="server" ControlToValidate="txtUsuarioNuevo" ErrorMessage="Ingrese Usuario Nuevo" ForeColor="Red" ValidationGroup="g2">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Repetir Usuario Nuevo:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtRepUsuario" runat="server" Width="220px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvRepUsuarioNuvo" runat="server" ControlToValidate="txtRepUsuario" ErrorMessage="Repita el Usuario Nuevo" ForeColor="Red" ValidationGroup="g2">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="btnModificarUsuario0" runat="server" Text="Modificar Usuario" OnClick="btnModificarUsuario_Click" ValidationGroup="g2" />
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="grupo1" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Ingrese la nueva contraseña:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtContraseña" runat="server" Width="220px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="txtContraseña" ErrorMessage="Ingrese una contraseña" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Repita la contraseña:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtContraseña2" runat="server" Width="220px"></asp:TextBox>
                    <asp:CompareValidator ID="cmpContraseña" runat="server" ControlToCompare="txtContraseña" ControlToValidate="txtContraseña2" ErrorMessage="Las contraseñas no coinciden" ForeColor="Red" ValidationGroup="grupo1">*</asp:CompareValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="grupo1" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="btnModificarContra" runat="server" Text="Modificar Contraseña" OnClick="btnModificarContra_Click" />
                </td>
                <td>
                    <asp:Label ID="lblAviso" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
