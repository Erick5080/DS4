<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_17_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div>
           
            <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
                AllowSorting="true" AllowPaging="true"
                DataKeyNames="ProductID"
                AutoGenerateEditButton="true"
                Runat="Server"/>

            <asp:SqlDataSource ID="MyDataSource1" runat="Server"
                ConnectionString="data source=DESKTOP-HAE2KFA\SQLEXPRESS ;initial catalog=Northwind; persist security info= True;
                Integrated Security=SSPI;"
                Providername="System.Data.SqlClient"
                SelectCommand="Select ProductID, ProductName, UnitPrice From Products"
                UpdateCommand="Update Products Set [ProductName]=@ProductName, [UnitPrice]=@UnitPrice Where [ProductId]=@ProductId">
             </asp:SqlDataSource>

        </div>


</asp:Content>
