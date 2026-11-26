<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmFixture.aspx.cs" Inherits="AdminLte.FrmFixture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
<div class="container-fluid mt-3">
<div class="card card-primary">
    <div class="card-header d-flex justify-content-center align-items-center text-center">
        <h3 class="card-title d-flex justify-content-center align-items-center m-0">
          <asp:ImageButton ID="btnSiguiente" runat="server" ImageUrl="~/Imagen/Left.ico" OnClick="btnSiguiente_Click" />
            <asp:Label ID="lblNombre" runat="server" Text="Fecha" CssClass="mx-2"></asp:Label>
          <asp:Label ID="lblFecha" runat="server" Text="Label" CssClass="mx-2"></asp:Label>
          <asp:ImageButton ID="btnAtraz" runat="server" ImageUrl="~/Imagen/Right.ico" OnClick="btnAtraz_Click" /></h3>
    </div>
    <div class="card-body p-0">
        <div class="table-responsive">
            <asp:GridView ID="Grilla" runat="server" AutoGenerateColumns ="false"
                CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
                GridLines="None" >
              <Columns>
                 <asp:BoundField DataField="Local" HeaderText="Local" ItemStyle-HorizontalAlign="Left" ItemStyle-CssClass="text-start" HeaderStyle-HorizontalAlign="Left" HeaderStyle-CssClass="text-start" />
                  <asp:BoundField DataField="gl" HeaderText="gl" ItemStyle-HorizontalAlign="Center" ItemStyle-CssClass="text-center" />
                 <asp:BoundField DataField="gv" HeaderText="gv" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="Visitante" HeaderText="Visitante" ItemStyle-HorizontalAlign="Left" ItemStyle-CssClass="text-start" HeaderStyle-HorizontalAlign="Left" HeaderStyle-CssClass="text-start" />
                    <asp:BoundField DataField="FechaPartido" HeaderText="Fecha" ItemStyle-HorizontalAlign="Center" />

              </Columns>
          </asp:GridView>
        </div>
    </div>
</div>
</div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomScripts" runat="server">
</asp:Content>
