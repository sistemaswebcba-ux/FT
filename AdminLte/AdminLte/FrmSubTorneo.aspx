<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmSubTorneo.aspx.cs" Inherits="AdminLte.FrmSubTorneo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <div class="container-fluid">
    <div class="card">
      <div class="card-header">
        <ul class="nav nav-tabs card-header-tabs" id="subTorneoTabs" role="tablist">
          <li class="nav-item" role="presentation">
            <button class="nav-link active" id="tab-equipos" data-bs-toggle="tab" data-bs-target="#content-equipos" type="button" role="tab" aria-controls="content-equipos" aria-selected="true">
              Equipos
            </button>
          </li>
          <li class="nav-item" role="presentation">
            <button class="nav-link" id="tab-tabla" data-bs-toggle="tab" data-bs-target="#content-tabla" type="button" role="tab" aria-controls="content-tabla" aria-selected="false">Tabla</button>
          </li>
          <li class="nav-item" role="presentation">
            <button class="nav-link" id="tab-resultados" data-bs-toggle="tab" data-bs-target="#content-resultados" type="button" role="tab" aria-controls="content-resultados" aria-selected="false">ReResultados</button>
          </li>
        </ul>
      </div>
      <div class="card-body">
        <div class="tab-content" id="subTorneoTabsContent">
          <div class="tab-pane fade show active" id="content-equipos" role="tabpanel" aria-labelledby="tab-equipos" tabindex="0">
            <div class="row g-2 align-items-center mb-3">
              <div class="col-auto">
                <asp:Label ID="lblSeleccionar" runat="server" Text="Seleccionar" CssClass="col-form-label"></asp:Label>
              </div>
              <div class="col-auto">
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="btnBuscar_Click" />
              </div>
            </div>

            <asp:GridView ID="Grilla" runat="server"
              CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
              GridLines="None"
              OnRowDataBound="Grilla_RowDataBound" AutoGenerateColumns="False">
              <Columns>
                <asp:TemplateField ItemStyle-Width="40px" HeaderStyle-Width="40px" ItemStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center">
                  <ItemTemplate>
                    <asp:CheckBox ID="chk" runat="server" />
                  </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="IdEquipo" />
                <asp:BoundField DataField="Equipo" HeaderText="Equipo">
                  <HeaderStyle HorizontalAlign="Left" CssClass="text-start" />
                  <ItemStyle HorizontalAlign="Left" CssClass="text-start" />
                </asp:BoundField>
              </Columns>
            </asp:GridView>
          </div>
          <div class="tab-pane fade" id="content-tabla" role="tabpanel" aria-labelledby="tab-tabla" tabindex="0">
            <div class="table-responsive">
              <asp:GridView ID="Grilla2" runat="server"
                CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
                GridLines="None"
                OnRowDataBound="Grilla2_RowDataBound">
              </asp:GridView>
            </div>
          </div>
          <div class="tab-pane fade" id="content-resultados" role="tabpanel" aria-labelledby="tab-resultados" tabindex="0">
            <p class="mb-0">
              Contenido de Resultados.
              
              <div class="table-responsive">
                <asp:GridView ID="Grilla3" runat="server"
                  CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
                  GridLines="None"
                  AutoGenerateColumns="False"
                  OnRowDataBound="Grilla3_RowDataBound">
                  <Columns>
                    <asp:BoundField DataField="fecha" HeaderText="Fecha" ShowHeader="False">
                      <HeaderStyle HorizontalAlign="Left" />
                      <ItemStyle Width="30px" />
                    </asp:BoundField>

                    <asp:BoundField DataField="local" HeaderText="Local">
                      <HeaderStyle HorizontalAlign="Left" Width="150px" />
                      <ItemStyle HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="gl">
                      <HeaderStyle Width="50px" HorizontalAlign="Left" />
                    </asp:BoundField>
                    <asp:BoundField DataField="gv">
                      <HeaderStyle Width="50px" HorizontalAlign="Right" />
                    </asp:BoundField>
                    <asp:BoundField DataField="visitante" HeaderText="Visitante">
                      <HeaderStyle HorizontalAlign="Left" Width="150px" />

                    </asp:BoundField>
                    <asp:BoundField DataField="fechapartido" HeaderText="Dia">
                      <HeaderStyle HorizontalAlign="Left" />
                      <ItemStyle Width="80px" />
                    </asp:BoundField>
                  </Columns>
                </asp:GridView>
              </div>
            </p>
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
