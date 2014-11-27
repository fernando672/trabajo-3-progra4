<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro-egresos.aspx.cs" Inherits="webEstacionamiento.registro_egresos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>El terrible de estacionamiento!</title>
    <link href="puroEstilo.css" rel="stylesheet" />
    <style type="text/css">
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="centro">
    
        Registro de Salida<br />
        <br />
        Ingrese la Patente :<asp:TextBox ID="txtPatente" runat="server" class="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" CssClass="boton" /> 
            
        <br />
        <br />
        Hora de Llegada :
        <asp:Label ID="lblHora" runat="server"></asp:Label>
        <br />
        <br />
        Segundos Cobrados :
        <asp:Label ID="lblSegundos" runat="server" Text=""></asp:Label>
        <br />
        <br />
        Monto a Cancelar : <asp:Label ID="lblMonto" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnCobrar" runat="server" OnClick="btnCobrar_Click" Text="Cobrar" CssClass="boton" Width="202px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCancelar" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" CssClass="boton" />
    
    </div>
    </form>
</body>
</html>
