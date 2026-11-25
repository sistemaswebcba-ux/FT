<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Master2.master" AutoEventWireup="true" CodeBehind="FrmFixture.aspx.cs" Inherits="AdminLte.FrmFixture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="HeaderContent" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
  <asp:ImageButton ID="btnSiguiente" runat="server" ImageUrl="~/Imagen/Left.ico" OnClick="btnSiguiente_Click" />
<asp:Label ID="lblFecha" runat="server" Text="Label"></asp:Label>
<asp:ImageButton ID="btnAtraz" runat="server" ImageUrl="~/Imagen/Right.ico" OnClick="btnAtraz_Click" />
   <asp:GridView ID="Grilla" runat="server" AutoGenerateColumns ="false" >
     <Columns>
        <asp:BoundField DataField="Local" HeaderText="Local" ItemStyle-HorizontalAlign="Center" />
         <asp:BoundField DataField="gl" HeaderText="gl" ItemStyle-HorizontalAlign="Center" />
        <asp:BoundField DataField="gv" HeaderText="gv" ItemStyle-HorizontalAlign="Center" />
         <asp:BoundField DataField="Visitante" HeaderText="Visitante" ItemStyle-HorizontalAlign="Center" />
           <asp:BoundField DataField="FechaPartido" HeaderText="Fecha" ItemStyle-HorizontalAlign="Center" />

     </Columns>
 </asp:GridView>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="FooterContent" runat="server">
   
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="BottomScripts" runat="server">
</asp:Content>
