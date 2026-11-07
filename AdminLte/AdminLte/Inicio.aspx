<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Maestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="AdminLte.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Estilo/Estilo2.css?v=dark5" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid mt-3">
        <div class="card card-primary">
            <div class="card-header">
                <h3 class="card-title">Tabla de Posiciones</h3>
            </div>
            <div class="card-body p-0">
                <div class="table-responsive container-grid mb-0">
                    <asp:GridView ID="Gridlla" runat="server" translate="no"
                        CssClass="table table-bordered table-hover table-striped table-sm mb-0 w-100 grilla-posiciones"
                        GridLines="None"
                        AutoGenerateColumns="False"
                        Width="100%" OnRowDataBound="Gridlla_RowDataBound" CellPadding="0">
                        <Columns>
                            <asp:BoundField DataField="POS" HeaderText="" />
                            <asp:BoundField DataField="idequipo" HeaderText="idequipo" />
                            <asp:BoundField DataField="EQUIPO" HeaderText="Equipo">
                                <ItemStyle HorizontalAlign="Left" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PTS" HeaderText="Pts">
                                <HeaderStyle CssClass="text-center" />
                                <ItemStyle CssClass="text-center" />
                            </asp:BoundField>
                            <asp:BoundField DataField="PJ" HeaderText="Pj" />
                            <asp:BoundField DataField="G" HeaderText="G" />
                            <asp:BoundField DataField="E" HeaderText="E" />
                            <asp:BoundField DataField="P" HeaderText="P" />
                            <asp:BoundField DataField="GF" HeaderText="Gf" />
                            <asp:BoundField DataField="GC" HeaderText="GC" />
                            <asp:BoundField DataField="DIF" HeaderText="Dif" />
                        </Columns>
                        <HeaderStyle CssClass="table-dark-custom" />
                        <PagerStyle CssClass="pagination-custom" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
