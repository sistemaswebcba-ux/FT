<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmFechasaspx.aspx.cs" Inherits="AdminLte.FrmFechasaspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
      <div class="container-fluid mt-3">
    <div class="card card-primary">
        <div class="card-header">
            <h3 class="card-title">
              <asp:Label ID="lblTorneo" runat="server" Text="Label"></asp:Label></h3>
        </div>
        <div class="card-body p-0">
            <div class="table-responsive">
                <asp:GridView ID="Grilla" runat="server" 
                    CssClass="table table-bordered table-hover table-striped mb-0 grilla-posiciones"
                    GridLines="None"
                    OnRowDataBound="Grilla_RowDataBound">
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
