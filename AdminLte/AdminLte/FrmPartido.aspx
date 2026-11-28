<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmPartido.aspx.cs" Inherits="AdminLte.FrmPartido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  <style>
    .partido-form {
      max-width: 100%;
    }

    .partido-form .form-control,
    .partido-form .form-select {
      min-width: 0;
      max-width: 100%;
    }

    .partido-form .table-responsive {
      max-width: 100%;
    }

    .partido-form .grilla-partido input {
      box-sizing: border-box;
    }

    .partido-form .score-input {
      width: 3.5rem !important;
      min-width: 3rem;
      margin: 0.125rem auto;
      text-align: center;
    }

    .partido-form .match-date-input {
      width: 6.5rem !important;
      min-width: 5rem;
      margin: 0.125rem auto;
      text-align: center;
    }

    @media (max-width: 575.98px) {
      .partido-form {
        padding-right: 0.25rem;
        padding-left: 0.25rem;
      }

      .partido-form .grilla-partido {
        font-size: 0.75rem;
      }

      .partido-form .score-input {
        width: 3rem !important;
        min-width: 2.5rem;
        font-size: 0.8rem;
      }

      .partido-form .match-date-input {
        width: 5.5rem !important;
        min-width: 4.5rem;
        font-size: 0.8rem;
      }
    }
  </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <div class="container-fluid mt-3 partido-form">
    <div class="card card-primary">
      <div class="card-body border-bottom">
        <div class="row g-2 align-items-end">
          <div class="col-12 col-md-6 col-lg-2">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario" CssClass="form-label" AssociatedControlID="txtUsuario"></asp:Label>
            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="col-12 col-md-6 col-lg-2">
            <asp:Label ID="lblClave" runat="server" Text="Clave" CssClass="form-label" AssociatedControlID="txtClave"></asp:Label>
            <asp:TextBox ID="txtClave" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="col-12 col-md-6 col-lg-3">
            <asp:Label runat="server" Text="Torneo" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="CmbTorneo" runat="server" CssClass="form-select"></asp:DropDownList>
          </div>
          <div class="col-12 col-md-6 col-lg-2">
            <asp:Label runat="server" Text="Fecha" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
          </div>
          <div class="col-12 col-lg-auto">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" CssClass="btn btn-primary w-100" />
          </div>
        </div>
      </div>

      <div class="card-body p-0">
        <div class="table-responsive">
          <asp:GridView ID="Grilla" runat="server" AutoGenerateColumns="False" OnRowDataBound="Grilla_RowDataBound"
            CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones grilla-partido"
            GridLines="None">
            <Columns>
              <asp:BoundField HeaderText="IdPar" DataField="idpartido" />
              <asp:BoundField DataField="idlocal" />
              <asp:BoundField DataField="local" HeaderText="Local"
                HeaderStyle-HorizontalAlign="Left" HeaderStyle-CssClass="text-start"
                ItemStyle-HorizontalAlign="Left" ItemStyle-CssClass="text-start" />
              <asp:TemplateField HeaderText="Goles local" HeaderStyle-HorizontalAlign="Center">
                <ItemTemplate>
                  <asp:TextBox ID="txtgl" runat="server" CssClass="form-control form-control-sm score-input"></asp:TextBox>
                  <asp:Label ID="lblgl" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
              </asp:TemplateField>
              <asp:BoundField DataField="idvisitante" />
              <asp:BoundField DataField="visitante" HeaderText="Visitante"
                HeaderStyle-HorizontalAlign="Left" HeaderStyle-CssClass="text-start"
                ItemStyle-HorizontalAlign="Left" ItemStyle-CssClass="text-start" />
              <asp:TemplateField HeaderText="Goles visitante" HeaderStyle-HorizontalAlign="Center">
                <ItemTemplate>
                  <asp:TextBox ID="txtgv" runat="server" CssClass="form-control form-control-sm score-input"></asp:TextBox>
                  <asp:Label ID="lblgv" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
              </asp:TemplateField>
              <asp:BoundField HeaderText="Fecha" DataField="fechapartido" />
              <asp:BoundField DataField="Jugo" />
              <asp:TemplateField HeaderText="Fecha">
                <ItemTemplate>
                  <asp:TextBox ID="txtNumeroFecha" runat="server" CssClass="form-control form-control-sm match-date-input"></asp:TextBox>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
              </asp:TemplateField>
              <asp:BoundField DataField="gl" />
              <asp:BoundField DataField="gv" />
              <asp:TemplateField HeaderText="Goles">
                <ItemTemplate>
                  <asp:Button ID="btnGoles" runat="server" Text="Goles" OnClick="btnGoles_Click" CssClass="btn btn-sm btn-outline-primary" />
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
              </asp:TemplateField>
            </Columns>
          </asp:GridView>
        </div>
      </div>

      <div class="card-body d-flex flex-column flex-md-row align-items-md-center gap-2">
        <asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" CssClass="btn btn-primary" />
        <asp:Label ID="lblMensaje" runat="server" CssClass="mb-0"></asp:Label>
      </div>
    </div>
  </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomScripts" runat="server">
</asp:Content>
