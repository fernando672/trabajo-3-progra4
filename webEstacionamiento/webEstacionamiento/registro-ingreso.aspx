<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro-ingreso.aspx.cs" Inherits="webEstacionamiento.registro_ingreso" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="puroEstilo.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="centro">
    
        Registro de Ingreso de Vehiculos<br />
        <br />
        Ingrese la Patente :
        <asp:TextBox ID="txtPatente" runat="server" class="textbox"></asp:TextBox> 
        <br />
        <br />
        <asp:Label ID="lblHora" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" class="boton" />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <a href="Main.aspx">Volver</a></div>
    </form>
</body>
</html>
