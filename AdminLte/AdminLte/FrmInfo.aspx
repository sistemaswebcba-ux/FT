<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Maestra.Master" AutoEventWireup="true" CodeBehind="FrmInfo.aspx.cs" Inherits="AdminLte.FrmInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div>
    <div class="container text-center border p-3">
      <!-- Primera Fila (1 sola columna completa) -->
      <div class="row bg-light border-bottom p-3">
        <asp:Label ID="lblEquipo" runat="server" Text="Label"></asp:Label></h3>
    <div class="col-12"></div>
      </div>

      <!-- Segunda Fila (1 sola columna completa) -->
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
          <asp:Image ID="IMG" runat="server" Height="80px" ImageUrl="" Width="80px" />
        </div>
      </div>
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
        </div>
      </div>
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
          <asp:Label ID="lblTorneo1" runat="server" Text="Label"></asp:Label>
        </div>
      </div>
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
          <asp:GridView ID="Grilla1" runat="server" translate="no"
            CssClass="table table-custom table-hover table-bordered table-striped table-responsive-sm table-sm text-wrap grilla-compacta grid-sin-espacios "
            GridLines="None"
            AutoGenerateColumns="False"
            Width="100%" CellPadding="0" OnRowDataBound="Grilla1_RowDataBound">

            <Columns>
              <asp:BoundField DataField="Condicion" HeaderText="">
                <HeaderStyle CssClass="p-0 " Width="150px" />
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="20px" />
              </asp:BoundField>
              <asp:BoundField DataField="condicion" HeaderText="idequipo" />
              <asp:BoundField DataField="pj" HeaderText="Pj">
                <ItemStyle Width="20px" HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="pts" HeaderText="Pts">
                <HeaderStyle CssClass="px-1 text-center" Width="10px" />
                <ItemStyle CssClass="px-1 text-center" Width="10px" HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="G" HeaderText="G">
                <ItemStyle Width="10px" HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="E" HeaderText="E">
                <ItemStyle Width="10px" />
              </asp:BoundField>
              <asp:BoundField DataField="P" HeaderText="P">
                <ItemStyle Width="10px" HorizontalAlign="Left" />
              </asp:BoundField>
              <asp:BoundField DataField="GF" HeaderText="Gf">
                <ItemStyle Width="20px" />
              </asp:BoundField>
              <asp:BoundField DataField="GC" HeaderText="GC">
                <ItemStyle Width="20px" />
              </asp:BoundField>
              <asp:BoundField DataField="DIF" HeaderText="Dif">
                <ItemStyle Width="20px" />
              </asp:BoundField>
            </Columns>

            <HeaderStyle CssClass="table-dark-custom" />
            <PagerStyle CssClass="pagination-custom" />
          </asp:GridView>
        </div>
      </div>
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
          <asp:Label ID="lblTorneo2" runat="server" Text="Label"></asp:Label>
        </div>
      </div>
      <div class="row bg-light border-bottom p-3">
        <div class="col-12">
          <asp:GridView ID="Grilla2" runat="server" translate="no"
  CssClass="table table-custom table-hover table-bordered table-striped table-responsive-sm table-sm text-wrap grilla-compacta grid-sin-espacios "
  GridLines="None"
  AutoGenerateColumns="False"
  Width="100%" CellPadding="0" OnRowDataBound="Grilla2_RowDataBound">

  <Columns>
    <asp:BoundField DataField="Condicion" HeaderText="">
      <HeaderStyle CssClass="p-0 " Width="150px" />
      <HeaderStyle HorizontalAlign="Left" />
      <ItemStyle Width="20px" />
    </asp:BoundField>
    <asp:BoundField DataField="condicion" HeaderText="idequipo" />
    <asp:BoundField DataField="pj" HeaderText="Pj">
      <ItemStyle Width="20px" HorizontalAlign="Left" />
    </asp:BoundField>
    <asp:BoundField DataField="pts" HeaderText="Pts">
      <HeaderStyle CssClass="px-1 text-center" Width="10px" />
      <ItemStyle CssClass="px-1 text-center" Width="10px" HorizontalAlign="Left" />
    </asp:BoundField>
    <asp:BoundField DataField="G" HeaderText="G">
      <ItemStyle Width="10px" HorizontalAlign="Left" />
    </asp:BoundField>
    <asp:BoundField DataField="E" HeaderText="E">
      <ItemStyle Width="10px" />
    </asp:BoundField>
    <asp:BoundField DataField="P" HeaderText="P">
      <ItemStyle Width="10px" HorizontalAlign="Left" />
    </asp:BoundField>
    <asp:BoundField DataField="GF" HeaderText="Gf">
      <ItemStyle Width="20px" />
    </asp:BoundField>
    <asp:BoundField DataField="GC" HeaderText="GC">
      <ItemStyle Width="20px" />
    </asp:BoundField>
    <asp:BoundField DataField="DIF" HeaderText="Dif">
      <ItemStyle Width="20px" />
    </asp:BoundField>
  </Columns>

  <HeaderStyle CssClass="table-dark-custom" />
  <PagerStyle CssClass="pagination-custom" />
</asp:GridView>
        </div>
      </div>
      <div class="row bg-white p-3">
        <div class="col-4">
        </div>
        <div class="col-4">
        </div>
        <div class="col-4"></div>
      </div>
      <!-- Tercera Fila (3 columnas iguales: 12 / 3 = 4) -->
      <div class="row bg-white p-3">
        <div class="col-4 border-end">
        </div>
        <div class="col-4 border-end">
        </div>
        <div class="col-4">Fila 3 - Columna 3</div>
      </div>
    </div>

  </div>

  <ul class="nav nav-tabs" id="tabMenu" role="tablist">
    <li class="nav-item" role="presentation">
      <button class="nav-link active" id="tab1-btn" data-bs-toggle="tab" data-bs-target="#tab1" type="button" role="tab" aria-controls="tab1" aria-selected="true">
        <i class="bi bi-person-fill me-2"></i>Datos Personales
      </button>
    </li>
    <li class="nav-item" role="presentation">
      <button class="nav-link" id="tab2-btn" data-bs-toggle="tab" data-bs-target="#tab2" type="button" role="tab" aria-controls="tab2" aria-selected="false">
        <i class="bi bi-gear-fill me-2"></i>Configuración
      </button>
    </li>
  </ul>


</asp:Content>
