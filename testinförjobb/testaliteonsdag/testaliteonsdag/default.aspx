<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="testaliteonsdag._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Movies</h1>
            <asp:Literal ID="lblOut" runat="server" />
            <asp:ObjectDataSource ID="odsGenres" runat="server"
                SelectMethod="GetGenres"
                TypeName="testaliteonsdag.Models.MovieTrackerRepository"></asp:ObjectDataSource>
            <asp:DropDownList ID="ddlGenres" runat="server"
                DataSourceID="odsGenres"
                DataTextField="GenreName"
                DataValueField="GenreId"
                ></asp:DropDownList>


        </div>
    </form>
</body>
</html>
