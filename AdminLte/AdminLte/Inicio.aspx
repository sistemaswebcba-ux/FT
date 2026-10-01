<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Maestra.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="AdminLte.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive  container-grid">
  <asp:GridView ID="Gridlla" runat="server" translate="no" 
        CssClass="table table-custom table-hover table-bordered table-striped table-responsive-sm table-sm text-wrap grilla-compacta grid-sin-espacios " 
        GridLines="None" 
        AutoGenerateColumns="False" 
        Width="100%" OnRowDataBound="Gridlla_RowDataBound" CellPadding="0">
        
        <Columns>
            <asp:BoundField DataField="POS" HeaderText="" >
              <HeaderStyle CssClass="p-0 " Width="10px" />
              <HeaderStyle HorizontalAlign="Left" />
              <ItemStyle Width="20px"  />
            </asp:BoundField>
            <asp:BoundField DataField="idequipo"  HeaderText="idequipo" />
            <asp:BoundField DataField="EQUIPO"  HeaderText="Equipo" >
               <ItemStyle  Width="200px" HorizontalAlign="Left" />
           </asp:BoundField>
            <asp:BoundField DataField="PTS"  HeaderText="Pts" >
                <HeaderStyle CssClass="px-1 text-center" Width="10px" />
               <ItemStyle CssClass="px-1 text-center" Width="10px" HorizontalAlign="Left"  />
            </asp:BoundField>
            <asp:BoundField DataField="PJ"  HeaderText="Pj" >
               <ItemStyle Width="20px" HorizontalAlign="Left"  />
           </asp:BoundField>
            <asp:BoundField DataField="G" HeaderText="G"  >
               <ItemStyle Width="10px" HorizontalAlign="Left"  />
           </asp:BoundField>
            <asp:BoundField DataField="E" HeaderText="E" >
               <ItemStyle Width="10px" />
           </asp:BoundField>
            <asp:BoundField DataField="P" HeaderText="P" >
               <ItemStyle Width="10px" HorizontalAlign="Left" />
           </asp:BoundField>
            <asp:BoundField DataField="GF" HeaderText="Gf" >
               <ItemStyle Width="20px"  />
               </asp:BoundField>
            <asp:BoundField DataField="GC" HeaderText="GC" >
               <ItemStyle Width="20px"  />
               </asp:BoundField>
            <asp:BoundField DataField="DIF" HeaderText="Dif" >
               <ItemStyle Width="20px"  />
               </asp:BoundField>
        </Columns>
        
        <HeaderStyle CssClass="table-dark-custom" />
        <PagerStyle CssClass="pagination-custom" />
    </asp:GridView>
     </div>
</asp:Content>
