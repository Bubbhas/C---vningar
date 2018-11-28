<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="KMP._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Hello World!</h1>

            <asp:Literal ID="lblOut" runat="server" />

            <asp:ObjectDataSource ID="odsCats" runat="server" 
                SelectMethod="GetCategories" 
                TypeName="KMP.Models.NewmakersRepository"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
