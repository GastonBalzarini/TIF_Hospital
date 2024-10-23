<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaMedico.aspx.cs" Inherits="Vistas.VistaMedico" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

    .auto-style1 {
        width: 135%;
        height: 63px;
    }
    .auto-style3 {
        width: 339px;
    }
    .auto-style4 {
        width: 337px;
    }
    .auto-style5 {
        width: 418px;
    }
    .auto-style6 {
        height: 23px;
    }
    .auto-style7 {
        width: 1000px;
    }
    .auto-style8 {
        width: 250px;
    }
    .auto-style9 {
        width: 135%;
    }
    .auto-style10 {
        width: 336px;
    }
        .auto-style11 {
            width: 404px;
        }
        .auto-style12 {
            margin-left: 31px;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hlPaginaPrincipal" runat="server" NavigateUrl="~/Inicio.aspx">Pagina Inicio</asp:HyperLink>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style5">
                        <asp:Label ID="lblUsuarioLogueado" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6" colspan="3">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        <br />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="lblUsuarioMed" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="USUARIO MÉDICO"></asp:Label>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
        <table class="auto-style7">
            <tr>
                <td class="auto-style8">Buscar paciente por DNI:</td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtBuscar" runat="server" Width="291px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
                    <asp:Button ID="btnVerTodos" runat="server" CssClass="auto-style12" OnClick="btnVerTodos_Click" Text="Ver todos" />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style11">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">Filtrar por:</td>
                <td class="auto-style11">
                    &nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cambiar Usuario y Contraseña" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Sexo</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlSexo" runat="server" Width="182px" AutoPostBack="True" OnSelectedIndexChanged="ddlSexo_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            </table>
        <br />
        <asp:GridView ID="gvTurnos" runat="server" AutoGenerateColumns="False" AutoGenerateEditButton="True" OnRowCancelingEdit="gvTurnos_RowCancelingEdit" OnRowEditing="gvTurnos_RowEditing" OnRowUpdating="gvTurnos_RowUpdating" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="5">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Dia">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_it_dia" runat="server" Text='<%# Eval("Dia_TUR") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_dia" runat="server" Text='<%# Eval("Dia_TUR") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hora">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_it_hora" runat="server" Text='<%# Eval("Hora_TUR") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_hora" runat="server" Text='<%# Eval("Hora_TUR") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Nombre" runat="server" Text='<%# Eval("Nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="DNI">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Eval("Dni_Paciente_TUR") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_DNI" runat="server" Text='<%# Eval("Dni_Paciente_TUR") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Fecha de Nacimiento">
                    <EditItemTemplate>
                        <asp:Label ID="lbl_it_fechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_PAC") %>'></asp:Label>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_fechaNac" runat="server" Text='<%# Eval("Fecha_Nacimiento_PAC") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Observacion">
                    <EditItemTemplate>
                        <asp:TextBox ID="txt_it_obs" runat="server"></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lbl_it_Observa" runat="server"  Text='<%# Eval("Observacion_TUR") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Asistencia">
                    <ItemTemplate>
                        <asp:CheckBox ID="ch_it_asis" runat="server" Checked='<%# Eval("Asistencia_TUR") %>' OnCheckedChanged="CheckBox1_CheckedChanged"  AutoPostBack="true"/>
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
        <br />
        <table class="auto-style9">
            <tr>
                <td class="auto-style10">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
   
</body>
</html>