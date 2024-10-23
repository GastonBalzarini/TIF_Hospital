<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Informes.aspx.cs" Inherits="Vistas.Informes" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style11 {
            height: 23px;
        }
        .auto-style12 {
            width: 1271px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style19 {
            width: 266px;
        }
        .auto-style23 {
            width: 253px;
            height: 23px;
        }
        .auto-style30 {
            width: 130px;
        }
        .auto-style32 {
            width: 283px;
        }
        .auto-style33 {
            width: 293px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style19">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td>
                    <asp:Label ID="LblUsuarioLogueado" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Underline="False" Text="Informes"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td colspan="2">
                    Informe del paciente con DNI:</td>
                <td class="auto-style33">
                    <asp:TextBox ID="txtPac" runat="server" CssClass="auto-style14" TextMode="Number" Width="252px"></asp:TextBox>
                </td>
                <td class="auto-style30">&nbsp;<asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" ValidateRequestMode="Disabled" />
                </td>
                <td class="auto-style32">Informe segun sexo:</td>
                <td>
                    <asp:DropDownList ID="ddlSexo" runat="server" CssClass="auto-style14" AutoPostBack="True" OnSelectedIndexChanged="ddlSexo_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
                <td class="auto-style33">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPac" ErrorMessage="Debe completar con un DNI" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style30">&nbsp;</td>
                <td class="auto-style32">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <asp:Label ID="lblAusentes" runat="server"></asp:Label>
                </td>
                <td class="auto-style32">
                    <asp:Label ID="lblAusentesSexo" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style23">
                    <asp:Chart ID="InfPaciente" runat="server" Height="250px" Width="322px">
                        <series>
                            <asp:Series Name="Series1">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                </td>
                <td class="auto-style11" colspan="3"></td>
                <td colspan="2">
                    <asp:Chart ID="infSexo" runat="server">
                        <series>
                            <asp:Series Name="Series1">
                            </asp:Series>
                        </series>
                        <chartareas>
                            <asp:ChartArea Name="ChartArea1">
                            </asp:ChartArea>
                        </chartareas>
                    </asp:Chart>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
