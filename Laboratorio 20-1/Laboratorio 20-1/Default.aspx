<%@ Page Title="Tabla de Multiplicar" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_20_1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Tabla de Multiplicar hasta el 25</h2>
    <hr />

    <div class="row">
        <div class="col-md-4">
            <p>Ingrese un número:</p>
            
            <asp:TextBox ID="txtNumero" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            <br />
            
            <asp:Button ID="btnCalcular" runat="server" Text="Mostrar Tabla" OnClick="btnCalcular_Click" CssClass="btn btn-primary" />
        </div>
    </div>
    
    <hr />
    
    <h3>Resultado:</h3>
    
    <asp:Label ID="lblResultado" runat="server"></asp:Label>

</asp:Content>
