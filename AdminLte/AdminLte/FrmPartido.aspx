<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmPartido.aspx.cs" Inherits="AdminLte.FrmPartido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <div >
     <asp:Label runat="server" Text="Torneo"></asp:Label>

   <asp:DropDownList ID="CmbTorneo" runat="server">
   </asp:DropDownList>
   <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
   <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
  </div>
  <div >
     
      <asp:GridView ID="Grilla"  runat="server" AutoGenerateColumns="False" OnRowDataBound="Grilla_RowDataBound">
        <Columns>
            <asp:BoundField DataField="idpartido" />
            <asp:BoundField DataField="idlocal" />
            <asp:BoundField DataField="local" HeaderText="Local">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="204px" />
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:TextBox ID="txtgl" runat="server" Font-Bold="True" Width="20px"></asp:TextBox>
                    <asp:Label ID="lblgl" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField DataField="idvisitante" />
            <asp:BoundField DataField="visitante" HeaderText="Visitante">
                <HeaderStyle HorizontalAlign="Left" />
                <ItemStyle Width="202px" />
            </asp:BoundField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:TextBox ID="txtgv" runat="server" Font-Bold="True" Width="20px"></asp:TextBox>
                    <asp:Label ID="lblgv" runat="server" Text="Label"></asp:Label>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" />
            </asp:TemplateField>
            <asp:BoundField DataField="fechapartido" />
            <asp:BoundField DataField="Jugo" />
            <asp:TemplateField HeaderText="Fecha">
                <ItemTemplate>
                    <asp:TextBox ID="txtNumeroFecha" runat="server" BorderColor="#FFCC66" 
                        Width="80px"></asp:TextBox>
                    
                </ItemTemplate>
            </asp:TemplateField>
         
            <asp:BoundField DataField="gl" />
              <asp:BoundField DataField="gv" />
        </Columns>
      </asp:GridView>
  </div>
  <div>
    &nbsp;<asp:Button ID="btnGrabar" runat="server" Text="Grabar" OnClick="btnGrabar_Click" />
  </div>
 
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomScripts" runat="server">
</asp:Content>
