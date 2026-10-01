<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Maestra.Master" AutoEventWireup="true" CodeBehind="FrmInfo.aspx.cs" Inherits="AdminLte.FrmInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
 
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

  <div class="tab-content mt-3" id="myTabContent">
    
    <!-- Pestaña 1 (Activa por defecto) -->
    <asp:Panel ID="pnlHome" runat="server" ClientIDMode="Static" cssClass="tab-pane fade show active" role="tabpanel">
        <h3>Contenido de Inicio</h3>
        <p> <asp:Image ID="IMG" runat="server" Height="80px" ImageUrl="" Width="80px" /></p>
    </asp:Panel>

    <!-- Pestaña 2 -->
    <asp:Panel ID="pnlProfile" runat="server" ClientIDMode="Static" cssClass="tab-pane fade" role="tabpanel">
        <h3>Contenido del Perfil</h3>
        <p>Aquí puedes renderizar controles del servidor como GridViews o TextBoxes.</p>
    </asp:Panel>

</div>
</asp:Content>
