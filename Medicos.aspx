<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Medicos.aspx.cs" Inherits="Vistas.Medicos" %>

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
            width: 1482px;
        }
        .auto-style3 {
            width: 99%;
            height: 110px;
        }
        .auto-style4 {
            margin-left: 50px;
        }
        .auto-style5 {
            margin-left: 28px;
        }
        .auto-style6 {
            margin-left: 37px;
        }
        .auto-style7 {
            width: 173px;
        }
        .auto-style8 {
            width: 291px;
        }
        .auto-style9 {
            width: 173px;
            height: 58px;
        }
        .auto-style10 {
            width: 291px;
            height: 58px;
        }
        .auto-style11 {
            height: 58px;
        }
        .auto-style12 {
            margin-left: 36px;
        }
        .auto-style13 {
            text-align:right;
        }
        .auto-style14 {
            width: 173px;
            height: 99px;
        }
        .auto-style15 {
            width: 291px;
            height: 99px;
        }
        .auto-style16 {
            height: 99px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="hpPagPri" runat="server" NavigateUrl="~/VistaAdmin.aspx">Pagina Principal</asp:HyperLink>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="LblUsuarioLogueado" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <table class="auto-style3">
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="MEDICOS"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td>&nbsp;Buscar por Nombre o Apellido:<asp:TextBox ID="txtBuscarMed" runat="server" CssClass="auto-style5" Width="219px"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" CssClass="auto-style4" Text="Buscar" Width="68px" OnClick="btnBuscar_Click" />
                    &nbsp;<asp:Button ID="btnVerTodos" runat="server" CssClass="auto-style6" Text="Ver todos" OnClick="btnVerTodos_Click" />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblaviso" runat="server"></asp:Label>
                    </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style14">
                    <asp:Label ID="Label2" runat="server" Text="Filtrar por:"></asp:Label>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Sexo:"></asp:Label>
                </td>
                <td class="auto-style15">
                    <asp:RadioButtonList ID="rbSexo" runat="server" AutoPostBack="True" OnSelectedIndexChanged="rbSexo_SelectedIndexChanged">
                        <asp:ListItem Value="F">Femenino</asp:ListItem>
                        <asp:ListItem Value="M">Masculino</asp:ListItem>
                        <asp:ListItem Value="N">No binario</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td class="auto-style16">
                    <asp:Label ID="Label4" runat="server" Text="Provincia:"></asp:Label>
                    <asp:DropDownList ID="ddlProvincias" runat="server" AutoPostBack="True" CssClass="auto-style12" OnSelectedIndexChanged="ddlProvincias_SelectedIndexChanged">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Label ID="Label5" runat="server" Text="Especialidad:"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:DropDownList ID="ddlEspecialidades" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged">
                        <asp:ListItem>--Seleccionar--</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="auto-style11"></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnAgregarMedico" runat="server" OnClick="btnAgregarMedico_Click" Text="Agregar nuevo Medico" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="gvMedicos" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="gvMedicos_RowCancelingEdit" OnRowEditing="gvMedicos_RowEditing" OnRowUpdating="gvMedicos_RowUpdating" OnRowDataBound="gvMedicos_RowDataBound" OnRowCommand="gvMedicos_RowCommand" AllowPaging="True" OnPageIndexChanging="gvMedicos_PageIndexChanging" PageSize="5" CellPadding="4" ForeColor="#333333" GridLines="None" AllowSorting="True">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField CommandName="eventoEliminar" Text="Eliminar" />
                <asp:TemplateField HeaderText="Legajo">
                    <EditItemTemplate>
                        <asp:Label ID="lblLegajo" runat="server" Text='<%# Eval("Legajo_MED") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblLegajo" runat="server" Text='<%# Eval("Legajo_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Dni">
                    <EditItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("Dni_MED") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDni" runat="server" Text='<%# Eval("Dni_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNombre" runat="server"  Text='<%# Eval("Nombre_MED") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNombre" ErrorMessage="El campo no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNombre" runat="server" Text='<%# Eval("Nombre_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Apellido">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtApellido" runat="server" Text='<%# Eval("Apellido_MED") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtApellido" ErrorMessage="El campo Apellido no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblApellido" runat="server" Text='<%# Eval("Apellido_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Sexo">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirSexo" runat="server" >
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_sexo" runat="server" Text='<%# Eval("Id_Sexo_MED") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblSexo" runat="server" Text='<%# Eval("Sexo") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nacionalidad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirNacionalidad" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_Nac" runat="server" Text='<%# Eval("Id_Nacionalidad_MED") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblNacionalidad" runat="server" Text='<%# Eval("Nacionalidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de Nacimiento">
                    <EditItemTemplate>
                        <asp:Label ID="lblFechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_MED") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblFechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Direccion">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Eval("Direccion_MED") %>'></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDireccion" ErrorMessage="El campo direccion no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblDireccion" runat="server" Text='<%# Eval("Direccion_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Provincia">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirProvincia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dllElegirProvincia_SelectedIndexChanged">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_Prov" runat="server" Text='<%# Eval("Cod_Provincia_MED") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblProvincia" runat="server" Text='<%# Eval("Provincia") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Localidad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirLocalidad" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_Loc" runat="server" Text='<%# Eval("Cod_Localidad_MED") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblLocalidad" runat="server" Text='<%# Eval("Localidad") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Correo Electronico">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCorreoElectronico" runat="server" Text='<%# Eval("Correo_Electronico_MED") %>'></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreoElectronico" ErrorMessage="El correo no es valido" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblCorreoElect" runat="server" Text='<%# Eval("Correo_Electronico_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Telefono">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTelefono" runat="server" Text='<%# Eval("Telefono_MED") %>' TextMode="Number"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTelefono" ErrorMessage="El campo Telefono no puede quedar vacio" ForeColor="Red">*</asp:RequiredFieldValidator>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblTelefono" runat="server" Text='<%# Eval("Telefono_MED") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Especialidad">
                    <EditItemTemplate>
                        <asp:DropDownList ID="dllElegirEspecialidad" runat="server">
                        </asp:DropDownList>
                        <asp:Label ID="lbl_ed_it_Esp" runat="server" Text='<%# Eval("Id_Especialidad_MED") %>' Visible="False"></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEspecialidad" runat="server" Text='<%# Eval("Especialidad") %>'></asp:Label>
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
