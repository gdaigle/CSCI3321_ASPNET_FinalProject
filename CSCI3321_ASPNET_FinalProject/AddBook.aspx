<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Add New Book</h3>
    <div class="row">
        <br />
        <div class="col-md-3">
            Book Title:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtTitle" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>
        

        <div class="col-md-3">
            Price:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>
        

        <div class="col-md-3">
            Publish Date:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtPublishDate" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>

        <div class="col-md-3">
            Author:
        </div>
        
        <div class="col-md-9">
            <asp:DropDownList ID="ddlAuthor" runat="server" DataSourceID="sdsAuthor" DataTextField="Name" DataValueField="AuthorID">
            </asp:DropDownList>
            <br />

            <asp:SqlDataSource ID="sdsAuthor" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT AuthorID, [FirstName] + ' ' + [LastName] AS [Name] FROM Authors"></asp:SqlDataSource>
            <br />
        </div>

        <div class="col-md-3">
            Publisher:
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlPublisher" runat="server" DataSourceID="sdsPublisher" DataTextField="PublisherName" DataValueField="PublisherID"></asp:DropDownList> 
            <br />
            <asp:SqlDataSource ID="sdsPublisher" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT PublisherID, PublisherName FROM Publishers"></asp:SqlDataSource>
                <br />
            </div>

        <div class="col-md-3">
            Genre:
        </div>
        <div class="col-md-9">
            <asp:DropDownList ID="ddlGenre" runat="server" DataSourceID="sdsGenre" DataTextField="GenreName" DataValueField="GenreID"></asp:DropDownList>
            <br />
            <asp:SqlDataSource ID="sdsGenre" runat="server" ConnectionString="<%$ ConnectionStrings:DBConnectionString %>" ProviderName="<%$ ConnectionStrings:DBConnectionString.ProviderName %>" SelectCommand="SELECT Genres.* FROM Genres"></asp:SqlDataSource>
            <br />
        </div>
        <div class="col-md-3">
            Word Count:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtWordCount" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>
        <div class="col-md-3">&nbsp;</div>
        <div class="col-md-9">
            <asp:Button ID="btnSubmit" runat="server" Text="Add Book" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
</asp:Content>
