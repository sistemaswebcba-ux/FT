<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmInfoxEquipo.aspx.cs" Inherits="AdminLte.FrmInfoxEquipo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <div class="container-fluid">
    <div class="card">
      <div class="d-flex align-items-center gap-3 mb-3">
        <asp:Image ID="ImgEquipo" runat="server" CssClass="rounded me-2" />
        <asp:Label ID="lblEquipo" runat="server" Font-Bold="True"></asp:Label>
      </div>
      <div class="card-header">
        <ul class="nav nav-tabs card-header-tabs" id="infoxEquipoTabs" role="tablist">
          <li class="nav-item" role="presentation">
            <button class="nav-link active" id="tab-general" data-bs-toggle="tab" data-bs-target="#content-general" type="button" role="tab" aria-controls="content-general" aria-selected="true">General</button>
          </li>
          <li class="nav-item" role="presentation">
            <button class="nav-link" id="tab-local" data-bs-toggle="tab" data-bs-target="#content-local" type="button" role="tab" aria-controls="content-local" aria-selected="false">Frecuencia</button>
          </li>
          <li class="nav-item" role="presentation">
            <button class="nav-link" id="tab-visitante" data-bs-toggle="tab" data-bs-target="#content-visitante" type="button" role="tab" aria-controls="content-visitante" aria-selected="false">Partidos</button>
          </li>
        </ul>
      </div>
      <div class="card-body">
        <div class="tab-content" id="infoxEquipoTabsContent">
          <div class="tab-pane fade show active" id="content-general" role="tabpanel" aria-labelledby="tab-general" tabindex="0">
            <div class="table-responsive">
              <asp:GridView ID="Grilla" runat="server"
                CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
                GridLines="None"
                AutoGenerateColumns="False">
                <Columns>
                  <asp:BoundField DataField="condicion" HeaderText="Condición">
                    <HeaderStyle HorizontalAlign="Left" CssClass="text-start" />
                    <ItemStyle HorizontalAlign="Left" CssClass="text-start" />
                  </asp:BoundField>
                  <asp:BoundField DataField="pj" HeaderText="PJ" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="pts" HeaderText="Pts" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="g" HeaderText="G" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="e" HeaderText="E" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="p" HeaderText="P" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="gf" HeaderText="GF" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="gc" HeaderText="GC" ItemStyle-HorizontalAlign="Center" />
                  <asp:BoundField DataField="dif" HeaderText="Dif" ItemStyle-HorizontalAlign="Center" />
                </Columns>
              </asp:GridView>
            </div>
          </div>
          <div class="tab-pane fade" id="content-local" role="tabpanel" aria-labelledby="tab-local" tabindex="0">
            <div class="d-flex flex-wrap gap-3">
              <div class="table-responsive flex-grow-1">
                <h5 class="mt-0 mb-2 text-center">General</h5>
                <asp:GridView ID="GrillaGeneral" runat="server" CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones" AutoGenerateColumns="False">
                  <Columns>
                    <asp:BoundField DataField="RESULTADO" HeaderText="RESULTADO" />
                    <asp:BoundField DataField="FRECUENCIA" HeaderText="FRECUENCIA" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="VEP" HeaderText="VEP" />
                    <asp:BoundField DataField="%" HeaderText="%" />
                  </Columns>
                </asp:GridView>
              </div>
              <div class="table-responsive flex-grow-1">
                <h5 class="mt-0 mb-2 text-center">Local</h5>
                <asp:GridView ID="GrillaLocal" runat="server" CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones" AutoGenerateColumns="False">
                  <Columns>
                    <asp:BoundField DataField="RESULTADO" HeaderText="RESULTADO" />
                    <asp:BoundField DataField="FRECUENCIA" HeaderText="FRECUENCIA" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="VEP" HeaderText="VEP" />
                    <asp:BoundField DataField="%" HeaderText="%" />
                  </Columns>
                </asp:GridView>
              </div>
              <div class="table-responsive flex-grow-1">
                <h5 class="mt-0 mb-2 text-center">Visitante</h5>
                <asp:GridView ID="GrillaVisitantes" runat="server" CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones" AutoGenerateColumns="False">
                  <Columns>
                    <asp:BoundField DataField="RESULTADO" HeaderText="RESULTADO" />
                    <asp:BoundField DataField="FRECUENCIA" HeaderText="FRECUENCIA" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                    <asp:BoundField DataField="VEP" HeaderText="VEP" />
                    <asp:BoundField DataField="%" HeaderText="%" />
                  </Columns>
                </asp:GridView>
              </div>
            </div>
          </div>
          <div class="tab-pane fade" id="content-visitante" role="tabpanel" aria-labelledby="tab-visitante" tabindex="0">
            <div class="table-responsive">
            <asp:GridView ID="GrillaPartidos" runat="server" CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones" AutoGenerateColumns="False">
              <Columns>
                <asp:BoundField DataField="fecha" HeaderText="Fecha" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="Local" HeaderText="Local" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
                <asp:BoundField DataField="gl" HeaderText="gl" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" />
                <asp:BoundField DataField="gv" HeaderText="gv" />
               <asp:BoundField DataField="visitante" HeaderText="Visitante" ItemStyle-HorizontalAlign="Left" HeaderStyle-HorizontalAlign="Left" />
                  <asp:BoundField DataField="fechapartido" HeaderText="Fecha" />
              </Columns>
            </asp:GridView>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomScripts" runat="server">
</asp:Content>
