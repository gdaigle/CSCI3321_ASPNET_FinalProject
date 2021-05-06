<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddAuthors.aspx.cs" Inherits="CSCI3321_ASPNET_FinalProject.AddAuthors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Add Authors</h3>
    
    <div class="row">
        <br />
        <div class="col-md-3">
            Author's Last Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtLastName" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>

        <div class="col-md-3">
            Author's First Name:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
        </div>

        <div class="col-md-3">
            Author's Gender:
        </div>
        <div class="col-md-9">
            <asp:RadioButtonList ID="rblGender" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
            <br />
        </div>
        <div class="col-md-3">
            Author's Birthday:
        </div>
        <div class="col-md-9">
            <asp:TextBox ID="txtBirthday" runat="server" CssClass="form-control"></asp:TextBox>
            <br />
           <asp:Button ID="btnSubmitAuthor" runat="server" Text="Add Author" CssClass="btn btn-primary" OnClick="btnSubmit_Click" />
        </div>
    
    </div>
</asp:Content>
