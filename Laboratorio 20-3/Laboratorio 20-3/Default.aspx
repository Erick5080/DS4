<%@ Page Title="Gestión de Laptops" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio_20_3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gestión de Productos (Laptops)</h2>
    <hr />

    <div class="row">
        <div class="col-md-6">
            
            <div class="input-group mb-3">
                <span class="input-group-text">Buscar por Id:</span>
                <asp:TextBox ID="tstId" runat="server" CssClass="form-control" placeholder="Ingrese ID"></asp:TextBox>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-info" />
            </div>

            <hr />

            <div class="mb-3">
                <asp:Label runat="server">Id</asp:Label>
                <asp:TextBox ID="txtId" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server">Nombre</asp:Label>
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server">Precio</asp:Label>
                <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number" Enabled="false"></asp:TextBox>
            </div>
            <div class="mb-3">
                <asp:Label runat="server">Stock</asp:Label>
                <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" TextMode="Number" Enabled="false"></asp:TextBox>
            </div>

            <div class="d-flex justify-content-between mt-4">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" OnClick="btnNuevo_Click" CssClass="btn btn-success" />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" OnClick="btnGuardar_Click" Enabled="false" CssClass="btn btn-primary" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" Enabled="false" CssClass="btn btn-danger" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btnCancelar_Click" Enabled="false" CssClass="btn btn-secondary" />
                <asp:Button ID="btnSalir" runat="server" Text="Salir" OnClick="btnSalir_Click" CssClass="btn btn-light" />
            </div>

            <hr />
            <asp:Label ID="lblMensaje" runat="server" EnableViewState="false" CssClass="mt-3"></asp:Label>
        </div>
    </div>
</asp:Content>