<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AsignacionDeTurnos.aspx.cs" Inherits="Vistas.Turnos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Asignación de Turnos</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        /* Otras estilos aquí */
        .auto-style2 {
            width: 426px;
        }
        .auto-style3 {
            width: 352px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlPaginaPrincipal" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                    </td>
                    <td colspan="4">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style8" colspan="6">
                        <asp:Label ID="lblUsuarioMed" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Asignación de Turnos"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBuscar1" runat="server" Text="Especialidad:"></asp:Label>
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:DropDownList ID="ddlEspecialidad" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidad_SelectedIndexChanged" CausesValidation="True">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ControlToValidate="ddlEspecialidad" ErrorMessage="Seleccionar Especialidad" ForeColor="Red" InitialValue="0" ValidationGroup="1"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style41">&nbsp;</td>
                    <td class="auto-style33">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBuscar2" runat="server" Text="Médico:"></asp:Label>
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:DropDownList ID="ddlMedico" runat="server" OnSelectedIndexChanged="ddlMedico_SelectedIndexChanged" AutoPostBack="True" CausesValidation="True">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvMedico" runat="server" ControlToValidate="ddlMedico" ErrorMessage="Seleccionar Medico" ForeColor="Red" InitialValue="0" ValidationGroup="1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBuscar" runat="server" Text="Día y Hora:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:RadioButtonList ID="rbDiaYHora" runat="server" CausesValidation="True"></asp:RadioButtonList>
                    </td>
                    <td class="auto-style2">
                        <asp:RequiredFieldValidator ID="rfvDiaYHora" runat="server" ControlToValidate="rbDiaYHora" ErrorMessage="Seleccionar Dia y Hora" ForeColor="Red" ValidationGroup="1"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="lblBuscar3" runat="server" Text="Ingresar DNI del Paciente:"></asp:Label>
                    </td>
                    <td class="auto-style2" colspan="2">
                        <asp:DropDownList ID="ddlPacientes" runat="server" CausesValidation="True" ValidationGroup="1"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvPaciente" runat="server" ControlToValidate="ddlPacientes" ErrorMessage="Seleccionar Paciente" ForeColor="Red" InitialValue="0" ValidationGroup="1"></asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style43">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style43">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="btnAsignar" runat="server" Text="Asignar Turno" OnClick="btnAsignar_Click" ValidationGroup="1" />
                    </td>
                    <td class="auto-style43">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                    <td class="auto-style43">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="btnVerTurnos" runat="server" OnClick="btnVerTurnos_Click" Text="Ver Turnos Asignados" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style2" colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style53" colspan="6">
                        <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" OnPageIndexChanging="gvTurnos_PageIndexChanging">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:TemplateField HeaderText="Médico">
                                    <ItemTemplate>
                                        <asp:Label ID="lblMedico" runat="server" Text='<%# Eval("Nombre_Medico") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Especialidad">
                                    <ItemTemplate>
                                        <asp:Label ID="lblEspecialidad" runat="server" Text='<%# Eval("Nombre_ES") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Día">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_dia0" runat="server" Text='<%# Eval("Dia_TUR") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Hora">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_hora0" runat="server" Text='<%# Eval("Hora_TUR") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Paciente">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Nombre0" runat="server" Text='<%# Eval("Nombre_Paciente") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="DNI">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_DNI0" runat="server" Text='<%# Eval("Dni_Paciente_TUR") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Observación">
                                    <ItemTemplate>
                                        <asp:Label ID="lbl_it_Observa" runat="server" Text='<%# Eval("Observacion_TUR") %>'></asp:Label>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:TemplateField HeaderText="Asistencia">
                                    <ItemTemplate>
                                        <asp:CheckBox ID="ch_it_asis" runat="server" Checked='<%# Eval("Asistencia_TUR") %>' Enabled="False" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <RowStyle BackColor="#E3EAEB" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
