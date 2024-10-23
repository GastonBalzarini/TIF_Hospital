<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarMedico.aspx.cs" Inherits="Vistas.AgregarMedico" %>

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
            width: 300px;
        }
        .auto-style4 {
            width: 300px;
            height: 33px;
        }
        .auto-style6 {
            height: 33px;
        }
        .auto-style7 {
            width: 322px;
        }
        .auto-style8 {
            width: 322px;
            height: 33px;
        }
        .auto-style9 {
            width: 300px;
            height: 31px;
        }
        .auto-style10 {
            width: 322px;
            height: 31px;
        }
        .auto-style11 {
            height: 31px;
        }
        .auto-style12 {
            width: 300px;
            height: 77px;
        }
        .auto-style13 {
            width: 322px;
            height: 77px;
        }
        .auto-style14 {
            height: 77px;
        }
        .auto-style15 {
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
                        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Medicos.aspx">Volver</asp:LinkButton>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td>
                        &nbsp;</td>
                    <td class="auto-style15">
                    <asp:Label ID="LblUsuarioLogueado" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="3">
                        <h2> Agregar Medico</h2></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Usuario:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtNuevoUsuario" runat="server" ValidationGroup="grupo2" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtNuevoUsuario" ErrorMessage="Debe ingresar un nombre de Usuario" ForeColor="Red" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Contraseña:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtContrasenia" runat="server" TextMode="Password" ValidationGroup="grupo2" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtContrasenia" ErrorMessage="Debe ingresar una contraseña" ForeColor="Red" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Repita la Contraseña</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtRepContrasenia" runat="server" TextMode="Password" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ErrorMessage="Debe repetir la Contraseña" ForeColor="Red" ControlToValidate="txtRepContrasenia" ValidationGroup="grupo2">*</asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no coinciden" ForeColor="Red" ControlToValidate="txtContrasenia" ValidationGroup="grupo2" ControlToCompare="txtRepContrasenia">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnAgregarUuario" runat="server" Text="Generar Usuario" ValidationGroup="grupo2" OnClick="btnAgregarUuario_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="grupo2" />
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lblAvisoUsuario" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>

                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Legajo:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtLegajo" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtLegajo" ErrorMessage="Debe ingresar el Legajo" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">DNI:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtDNI" runat="server" TextMode="Number" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtDNI" ErrorMessage="Debe ingresar DNI" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Nombre:</td>
                    <td class="auto-style8">
                        <asp:TextBox ID="txtNombre" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtNombre" ErrorMessage="Debe ingresar el Nombre" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Apellido:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtApellido" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtApellido" ErrorMessage="Debe ingresar el Apellido" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Sexo:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlSexo" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="ddlSexo" ErrorMessage="Debe seleccionar el Sexo" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Nacionalidad:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlNac" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="ddlNac" ErrorMessage="Debe seleccionar una nacionalidad" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fecha de nacimiento:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtFechaNac" runat="server" TextMode="Date"  Width="300px" ValidationGroup="grupo1"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtFechaNac" ErrorMessage="Debe ingresar la fecha de nacimiento" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Direccion:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="textDomicilio" runat="server" Width="297px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="textDomicilio" ErrorMessage="Debe ingresar el Domicilio" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Provincia:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlProv" runat="server" Width="300px" ValidationGroup="grupo1" AutoPostBack="True" OnSelectedIndexChanged="ddlProv_SelectedIndexChanged">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="ddlLocalidad" ErrorMessage="Debe seleccionar una Localidad" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Localidad:</td>
                    <td class="auto-style8">
                        <asp:DropDownList ID="ddlLocalidad" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem Value="--Seleccionar--">--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="ddlProv" ErrorMessage="Debe seleccionar una Provincia" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Correo electronico:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtCorreo" runat="server" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCorreo" ErrorMessage="Debe ingresar el Correo Electronico" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="El Correo no es Valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtCorreo" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Telefono:</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtTelefono" runat="server" TextMode="Number" ValidationGroup="grupo1" Width="300px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtTelefono" ErrorMessage="Debe ingresar el numero de Telefono" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Especialidad</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlEspecialidad" runat="server" ValidationGroup="grupo1" Width="300px">
                            <asp:ListItem>--Seleccionar--</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="ddlEspecialidad" ErrorMessage="Debe seleccionar una Especialidad" ForeColor="Red" InitialValue="---Seleccionar---" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnAgregarMedico" runat="server" Text="Agregar" ValidateRequestMode="Enabled" ValidationGroup="grupo1" OnClick="btnAgregarMedico_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="grupo1" />
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="lblAviso" runat="server"></asp:Label>
                        </td>
                    <td class="auto-style14"></td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style7">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        Dias de Atencion:</td>
                    <td class="auto-style7">
                        <asp:CheckBoxList ID="chkDias" runat="server">
                            <asp:ListItem>Lunes</asp:ListItem>
                            <asp:ListItem>Martes</asp:ListItem>
                            <asp:ListItem>Miercoles</asp:ListItem>
                            <asp:ListItem>Jueves</asp:ListItem>
                            <asp:ListItem>Viernes</asp:ListItem>
                            <asp:ListItem>Sabado</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style7">
                        <asp:Button ID="btnAgregarDias" runat="server" Text="Agregar Dias de Atencion" OnClick="btnAgregarDias_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>

                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style7">
                        <asp:Label ID="lblMensajeDA" runat="server"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
