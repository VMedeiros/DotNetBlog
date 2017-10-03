<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Blog.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>   
            <asp:TextBox ID="TextBox1" runat="server" Width="451px"></asp:TextBox>

        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button_Click" Text="Cadastrar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Listar" />
        </p>
    </form>
</body>
</html>
