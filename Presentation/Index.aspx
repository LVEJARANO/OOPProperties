<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Presentation.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Carro 1"></asp:Label><br />
            <asp:Label ID="Label1" runat="server" Text="Ingresar el Color:"></asp:Label>
            <asp:TextBox ID="TBColor1" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label2" runat="server" Text="Ingresar el Cilindraje:"></asp:Label>
            <asp:TextBox ID="TBCilindraje1" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label3" runat="server" Text="Ingresar el Modelo:"></asp:Label>
            <asp:TextBox ID="TBModelo1" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblMsj1" runat="server" Text=""></asp:Label><br />
            <asp:Label ID="Label5" runat="server" Text="Carro 2"></asp:Label><br />
            <asp:Label ID="Label6" runat="server" Text="Ingresar el Color:"></asp:Label>
            <asp:TextBox ID="TBColor2" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label7" runat="server" Text="Ingresar el Cilindraje:"></asp:Label>
            <asp:TextBox ID="TBCilindraje2" runat="server"></asp:TextBox><br />
             <asp:Label ID="Label8" runat="server" Text="Ingresar el Modelo:"></asp:Label>
            <asp:TextBox ID="TBModelo2" runat="server"></asp:TextBox><br />
            <asp:Label ID="LblMsj2" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="BtnEnviar" runat="server" Text="Enviar" OnClick="BtnEnviar_Click" />
        </div>
    </form>
</body>
</html>
