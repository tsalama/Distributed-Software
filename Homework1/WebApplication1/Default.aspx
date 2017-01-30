<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Enter Information</h1>
        <p>First Name:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>Last Name:
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>Age: <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Generate" />
        </p>
        <p>&nbsp;</p>
        <p>Login ID:
            <asp:Label ID="Label2" runat="server" Font-Bold="True" Text=" "></asp:Label>
        </p>
        <p>Password:
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text=" "></asp:Label>
        </p>
    </div>

    </asp:Content>
