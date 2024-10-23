<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pacientes.aspx.cs" Inherits="Vistas.Pacientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

    .auto-style1 {
        width: 100%;
        height: 63px;
    }
    .auto-style14 {
        width: 320px;
    }
    .auto-style4 {
        width: 337px;
    }
    .auto-style5 {
        text-align:right;
        width: 418px;
    }
    .auto-style6 {
        height: 23px;
    }
    .auto-style10 {
        width: 100%;
    }
    .auto-style15 {
        width: 231px;
        height: 114px;
    }
    .auto-style16 {
        width: 153px;
        height: 114px;
    }
    .auto-style17 {
        height: 114px;
    }
    .auto-style11 {
        width: 231px;
    }
    .auto-style12 {
        width: 153px;
    }
        .auto-style18 {
            width: 150px;
            height: 114px;
        }
        .auto-style19 {
            width: 150px;
        }
        .auto-style20 {
            width: 231px;
            height: 23px;
        }
        .auto-style21 {
            width: 153px;
            height: 23px;
        }
        .auto-style22 {
            width: 150px;
            height: 23px;
        }
        .auto-style23 {
            margin-left: 41px;
        }
    </style>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style14">
                        <asp:HyperLink ID="hlPaginaPrincipal" runat="server" NavigateUrl="~/VistaAdmin.aspx">Volver</asp:HyperLink>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblUsuarioMed" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="PACIENTES"></asp:Label>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">&nbsp;&nbsp;
                        <asp:Label ID="lblBuscar" runat="server" Text="Buscar por DNI:"></asp:Label>
                        <asp:TextBox ID="txtBuscar" runat="server" CssClass="auto-style23"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnVerTodos" runat="server" Text="Ver todos" OnClick="btnVerTodos_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblaviso" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style15">&nbsp;&nbsp;
                                    <asp:Label ID="Label1" runat="server" Text="Filtrar por:"></asp:Label>
                                    <br />
                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label2" runat="server" Text="Sexo"></asp:Label>
                                </td>
                                <td class="auto-style16">
                                    <br />
                                    <br />
                                    <br />
                                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="True">
                                        <asp:ListItem Value="F">Femenino</asp:ListItem>
                                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                                        <asp:ListItem Value="N">No binario</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                                <td class="auto-style16">
                                    Localidad</td>
                                <td class="auto-style18">
                                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style17">
                                    &nbsp;</td>
                                <td class="auto-style17"></td>
                                <td class="auto-style17"></td>
                                <td class="auto-style17"></td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                                <td class="auto-style19">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style20">
                                    <asp:Button ID="btnAgregarPaciente" runat="server" OnClick="btnAgregarPaciente_Click" Text="Agregar Nuevo Paciente" ValidateRequestMode="Disabled" Width="266px" />
                                </td>
                                <td class="auto-style21">&nbsp;</td>
                                <td class="auto-style6" colspan="2">
                                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" />
                                </td>
                                <td class="auto-style6"></td>
                                <td class="auto-style6"></td>
                                <td class="auto-style6"></td>
                                <td class="auto-style6"></td>
                            </tr>
                            <tr>
                                <td class="auto-style20">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                                <td class="auto-style21">&nbsp;</td>
                                <td class="auto-style22">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                                <td class="auto-style6">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowDataBound="GridView1_RowDataBound" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowCancelingEdit="GridView1_RowCancelingEdit" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" PageSize="5" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField CommandName="eventoEliminar" Text="Eliminar" />
                <asp:TemplateField HeaderText="DNI">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_ed_it_DNI" runat="server" Text='<%# Eval("Dni_PAC") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Eval("Dni_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_ed_it_Nombre" runat="server" Text='<%# Eval("Nombre_PAC") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_ed_it_Nombre" ErrorMessage="El campo no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Eval("Nombre_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Apellido">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_ed_it_Apellido" runat="server" Text='<%# Eval("Apellido_PAC") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_ed_it_Apellido" ErrorMessage="El campo no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Apellido" runat="server" Text='<%# Eval("Apellido_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sexo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirSexo" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_sexo" runat="server" Text='<%# Eval("Id_Sexo_PAC") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Sexo" runat="server" Text='<%# Eval("Sexo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nacionalidad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirNacionalidad" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_nac" runat="server" Text='<%# Eval("Id_Nacionalidad_PAC") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nacionalidad" runat="server" Text='<%# Eval("Nacionalidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de nacimiento">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_ed_it_FechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_PAC") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_FechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Direccion">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_ed_it_Direccion" runat="server" Text='<%# Eval("Direccion_PAC") %>'>></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_ed_it_Direccion" ErrorMessage="El campo Direccion no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Direccion" runat="server" Text='<%# Eval("Direccion_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Provincia">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlElegirProv" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlElegirProv_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_Prov" runat="server" Text='<%# Eval("Cod_Provincia_PAC") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Prov" runat="server" Text='<%# Eval("Provincia") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Localidad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlElegirLocalidad" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_loc" runat="server" Text='<%# Eval("Cod_Localidad_PAC") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Localidad" runat="server" Text='<%# Eval("Localidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Correo Electronico">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_ed_it_Correo" runat="server" Text='<%# Eval("Correo_Electronico_PAC") %>'></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txt_ed_it_Correo" ErrorMessage="El Correo no es Valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Correo" runat="server" Text='<%# Eval("Correo_Electronico_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Telefono">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_ed_it_Telefono" runat="server" TextMode="Number" Text='<%# Eval("Telefono_PAC") %>'>></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_ed_it_Telefono" ErrorMessage="El campo no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Telefono" runat="server" Text='<%# Eval("Telefono_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
    </form>
  
  
</body>
</html>
