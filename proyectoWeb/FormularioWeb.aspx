<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioWeb.aspx.cs" Inherits="proyectoWeb.FormularioWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>

<body>
    <h1>Ejemplo LinQ</h1>
    <br />
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="cboNombres" runat="server"></asp:DropDownList>

            <asp:Button ID="btnEjemplo1" runat="server" Text="Mostrar todos los clientes" OnClick="btnEjemplo1_Click" />
            <br />
            <br />
            <asp:Button ID="btnEjemplo2" runat="server" Text="Mostrar clientes y reservaciones" OnClick="btnEjemplo2_Click" />
            <br />
            <br />

            <asp:GridView ID="grdClientes" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                <FooterStyle BackColor="White" ForeColor="#000066" />
                <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                <RowStyle ForeColor="#000066" />
                <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#007DBB" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#00547E" />
            </asp:GridView>

        </div>
    </form>

</body>
</html>
