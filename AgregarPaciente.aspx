<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarPaciente.aspx.cs" Inherits="Vistas.AgregarPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width:100%;
        }
        .auto-style3 {
            width: 300px;
        }
        .auto-style4 {
            width: 322px;
        }
        .auto-style2 {
            text-align:right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Pacientes.aspx">Volver</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style2">
                    <asp:Label ID="LblUsuarioLogueado" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <h2> Agregar Paciente</h2></td>
                </tr>
                <tr>

                    <td class="auto-style3"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style3">DNI:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDNI" runat="server" TextMode="Number" ValidationGroup="grupo1" Width="300px" OnTextChanged="txtDNI_TextChanged"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDNI" ErrorMessage="Debe ingresar DNI" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nombre:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar el Nombre" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Apellido:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtApellido" ErrorMessage="Debe ingresar el Apellido" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Sexo:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlSexo" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlSexo" ErrorMessage="Debe seleccionar el Sexo" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Nacionalidad:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlNac" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlNac" ErrorMessage="Debe seleccionar una nacionalidad" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Fecha de nacimiento:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtFechaNac" runat="server" TextMode="Date"  Width="300px" ValidationGroup="grupo1"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtFechaNac" ErrorMessage="Debe ingresar la fecha de nacimiento" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Direccion:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtDireccion" runat="server" Width="300px" ValidationGroup="grupo1"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Debe ingresar una Direccion" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Provincia:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlProv" runat="server" Width="300px" ValidationGroup="grupo1" AutoPostBack="True" OnSelectedIndexChanged="ddlProv_SelectedIndexChanged">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlLocalidad" ErrorMessage="Debe seleccionar una Localidad" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Localidad:</td>
                    <td class="auto-style4">
                        <asp:DropDownList ID="ddlLocalidad" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlProv" ErrorMessage="Debe seleccionar una Provincia" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Correo electronico:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtCorreo" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debe ingresar el Correo Electronico" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El Correo no es Valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtCorreo" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Telefono:</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Debe ingresar el numero de Telefono" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <asp:Button ID="btnAgregarPaciente" runat="server" Text="Agregar" ValidateRequestMode="Enabled" ValidationGroup="grupo1" OnClick="btnAgregarPaciente_Click" />
                    </td>
                    <td class="auto-style3">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="grupo1" />
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblaviso" runat="server"></asp:Label>
                        </td>
                    <td class="auto-style3"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
