<%@ Page Title="Matriz Diagonal Inversa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_20_2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Matriz $N \times N$ con Diagonal Inversa</h2>
    <hr />

    <div class="row">
        <div class="col-md-4">
            <p>Ingrese la dimensión N de la matriz:</p>
            
            <asp:TextBox ID="txtDimension" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnGenerar" runat="server" Text="Generar Matriz" OnClick="btnGenerar_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    
    <hr />
    
    <h3>Matriz Generada:</h3>
    
    <asp:Label ID="lblMatriz" runat="server"></asp:Label>

</asp:Content>
