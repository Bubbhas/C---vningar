<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Leker.About" %>

<asp:Content runat="server" ID="content" ContentPlaceHolderID="MainContent">

    <div>
        <h1>Genres</h1>
        <asp:Literal ID="lblOut" runat="server" />
        <asp:ObjectDataSource ID="odsGenres" runat="server"
            SelectMethod="GetGenres"
            TypeName="Leker.Models.MovieTrackerRepository"></asp:ObjectDataSource>
        <%--<asp:DropDownList ID="ddlGenres" runat="server"--%>
        <asp:CheckBoxList runat="server"
            DataSourceID="odsGenres"
            DataTextField="GenreName"
            DataValueField="GenreId">
        </asp:CheckBoxList>
        <%-- ></asp:DropDownList>--%>

        <asp:Button ID="Button1" runat="server" Text="See movies" Width="212px" />



        <asp:Literal ID="Literal1" runat="server" />

           
        <table id="MovieTable">
            <tr>
                <th>Movie Name</th>
                <th>Rating</th>
                <th>Genre</th>
            </tr>
             <asp:ObjectDataSource ID="odsMoviesGenre" runat="server" 
                SelectMethod="GetMoviesByGenreId" 
                TypeName="Leker.Models.MovieTrackerRepository"></asp:ObjectDataSource>
            <tr id="TableTR">

            </tr>
        </table>
      

        <h1>Movies</h1>
        <asp:Literal ID="lblOutMovie" runat="server" />
        <asp:ObjectDataSource ID="odsMovies" runat="server"
            SelectMethod="GetMovies"
            TypeName="Leker.Models.MovieTrackerRepository"></asp:ObjectDataSource>
        <asp:DropDownList ID="ddlMovies" runat="server"
            DataSourceID="odsMovies"
            DataTextField="MovieName"
            DataValueField="MovieId">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlMovieRating" runat="server"
            DataSourceID="odsMovies"
            DataTextField="Rating"
            DataValueField="MovieId">
        </asp:DropDownList>

    </div>


</asp:Content>

