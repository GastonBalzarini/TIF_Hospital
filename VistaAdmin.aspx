<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VistaAdmin.aspx.cs" Inherits="Vistas.VistaAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
         * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        .Encabezado {
            width: 100%;
            height: 60px;
            background: url(data:image/jpeg;base64,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);
            
        }
        .Titulo {
            width: 100%;
            height: 40px;
            text-align: center;
        }
        .Seleccion{
            width: 100%;
            height: 700px;
            text-align: center;
        }
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align:right;
            height: 20px;
        }
        .auto-style3 {
            height: 20px;
            width: 485px;
        }
        .auto-style4 {
            height: 20px;
            width: 767px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="Encabezado">
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <br />
            <asp:HyperLink ID="hlPaginaPrincipal" runat="server" NavigateUrl="~/Inicio.aspx" Font-Bold="True" Font-Size="X-Large" style="padding:20px">Pagina Inicio</asp:HyperLink>
                    </td>
                    <td class="auto-style4"></td>
                    <td class="auto-style2">
                        <br />
                        <asp:Label ID="lblUsuarioLogueado" runat="server" Font-Bold="True" Font-Size="X-Large"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div class="Titulo">
            <asp:Label ID="lblUsuarioMed" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="BIENVENIDO ADMINISTRADOR"></asp:Label>
        </div>
        <div class="Seleccion">

            <asp:Image ID="Image1" runat="server" Height="230px" ImageUrl="~/imagenes/paciente.png" Width="220px" />
            <asp:Image ID="Image2" runat="server" Height="230px" ImageUrl="~/imagenes/turnos.png" style="margin-left:50px" Width="200px" />

            <br />

            <br />
            <asp:LinkButton ID="lbPacientes" runat="server" Font-Bold="True" Font-Size="X-Large" PostBackUrl="~/Pacientes.aspx" >Pacientes</asp:LinkButton>

            <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Size="X-Large" PostBackUrl="~/AsignacionDeTurnos.aspx" style="margin-left:170px" >Turnos</asp:LinkButton>

            <br />
            <br />
            <asp:Image ID="Image3" runat="server" Height="230px" ImageUrl="~/imagenes/medico.png" Width="220px" />

            <asp:Image ID="Image4" runat="server" Height="230px" ImageUrl="~/Imagenes/reporte.jpg" Width="220px" style="margin-left:50px" />

            <br />
            <br />
            <asp:LinkButton ID="lbMedicos" runat="server" Font-Bold="True" Font-Size="X-Large" PostBackUrl="~/Medicos.aspx">Médicos</asp:LinkButton>
            <asp:LinkButton ID="lbInformes" runat="server" Font-Bold="True" Font-Size="X-Large" style="margin-left:170px" PostBackUrl="~/Informes.aspx" >Informes</asp:LinkButton>

        </div>
    </form>
</body>
</html>
