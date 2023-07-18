<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarMedidor.aspx.cs" Inherits="MedidorWeb.AgregarMedidor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Agregar Usuarios</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="apellidoTxt">Apellido</label>
                        <asp:TextBox ID="apellidoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="correoTxt">Correo</label>
                        <asp:TextBox ID="correoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="lecturaTxt">Lectura en kw/h</label>
                        <asp:TextBox ID="lecturaTXT" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="estadoTxt">Estado</label>
                        <asp:RadioButtonList ID="estadoRbl" runat="server">
                            <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                            <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <label for="tipoMedidorDDL">Tipo de Medidor</label>
                        <asp:DropDownList ID="tipoMedidorDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-primary" OnClick="ingresarBtn_Click" ID="ingresarBtn" Text="Ingresar" />

                </div>
            </div>
        </div>
    </div>
</asp:Content>

