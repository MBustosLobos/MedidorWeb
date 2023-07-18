<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidor.aspx.cs" Inherits="MedidorWeb.VerMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row-5">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="tipoMedidorDDL" runat="server"  OnSelectedIndexChanged="tipoMedidorDDL_SelectedIndexChanged" AutoPostBack="true" >
                  <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                 <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaAsistente" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true" 
            CssClass="table table-hover table-bordered"
          
            EmptyDataText="No hay Registros" runat="server">

            <Columns>
                 <asp:BoundField HeaderText="Rut" DataField="Rut" />
                 <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                 <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                 <asp:BoundField HeaderText="Correo" DataField="Correo" />
                 <asp:BoundField HeaderText="Lectura" DataField="Lectura" />
                 <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                 <asp:BoundField HeaderText="Estado" DataField="Estado" />
                 
            </Columns>

        </asp:GridView>
    </div>

</asp:Content>

