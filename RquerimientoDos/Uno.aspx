<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Uno.aspx.cs" Inherits="RquerimientoDos.Uno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="dpl" runat="server"></asp:DropDownList>
            <asp:Button ID="btn" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:GridView ID="dv" runat="server"></asp:GridView>
            
        </div>
        
        
    </form>
</body>
</html>
