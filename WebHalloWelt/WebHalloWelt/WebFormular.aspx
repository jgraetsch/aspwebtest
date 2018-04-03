<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormular.aspx.cs" Inherits="WebHalloWelt.WebFormular" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <p>Addieren</p>
    <form id="form1" runat="server">
       
            <p><input runat="server" id="zahl1" />Zahl1</p>
            
            <p>
                <input id="zahl2" runat="server" />Zahl2</p>
            <p>
                <input id="Submit1"  runat="server" value="senden" type="submit"/></p>
            
        
    </form>
    <p>
                <asp:Label ID="ergebnis" runat="server" Text="Label"></asp:Label>
            </p>
</body>
</html>
