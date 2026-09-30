<%@ Page Title="" Language="C#" MasterPageFile="~/dist/forms/Maestra.Master" AutoEventWireup="true" CodeBehind="FrmEquipos.aspx.cs" Inherits="AdminLte.FrmEquipos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="class="container-fluid p-0 class-vh-100">
      <div class="row g-0 fila-pantalla">
            <div class="col-2 border d-flex align-items-center justify-content-center">
               <asp:ImageButton ID="Img1" runat="server" Width="50px" Height="50px"
     ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center">
              <asp:ImageButton ID="Img2" runat="server" Width="50px" Height="50px"
    ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center">
               <asp:ImageButton ID="Img3" runat="server" Width="50px" Height="50px"
     ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center">
              <asp:ImageButton ID="Img4" runat="server" Width="50px" Height="50px"
    ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center">
              <asp:ImageButton ID="Img5" runat="server" Width="50px" Height="50px"
    ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center">
               <asp:ImageButton ID="Img6" runat="server" Width="50px" Height="50px"
     ImageUrl="" />
            </div>
        </div>
      <div class="row g-0 fila-pantalla">
          <div class="col-2 border d-flex align-items-center justify-content-center">
     <asp:ImageButton ID="Img7" runat="server" Width="50px" Height="50px" ImageUrl="" />
  </div>
  <div class="col-2 border d-flex align-items-center justify-content-center">
     <asp:ImageButton ID="Img8" runat="server" Width="50px" Height="50px" ImageUrl="" />
  </div>
  <div class="col-2 border d-flex align-items-center justify-content-center">
   <asp:ImageButton ID="Img9" runat="server" Width="50px" Height="50px" ImageUrl="" />
  </div>
  <div class="col-2 border d-flex align-items-center justify-content-center">
     <asp:ImageButton ID="Img10" runat="server" Width="50px" Height="50px" ImageUrl="" />
  </div>
  <div class="col-2 border d-flex align-items-center justify-content-center">
   <asp:ImageButton ID="Img11" runat="server" Width="50px" Height="50px" ImageUrl="" />
  </div>
  <div class="col-2 border d-flex align-items-center justify-content-center">
     <asp:ImageButton ID="Img12" runat="server" Width="50px" Height="50px" ImageUrl="" />   
  </div>
</div>
       <div class="row g-0 fila-pantalla">
            <div class="col-2 border d-flex align-items-center justify-content-center">
              <asp:ImageButton ID="Img13" runat="server" Width="50px" Height="50px" ImageUrl="" />
            </div>
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img14" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img15" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img16" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center">  <asp:ImageButton ID="Img17" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"><asp:ImageButton ID="Img18" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
        </div>
       <div class="row g-0 fila-pantalla">
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img19" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"><asp:ImageButton ID="Img20" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img21" runat="server" Width="50px" Height="50px" ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"><asp:ImageButton ID="Img22" runat="server" Width="50px" Height="50px"
    ImageUrl="" /> </div>
            <div class="col-2 border d-flex align-items-center justify-content-center"> <asp:ImageButton ID="Img23" runat="server" Width="50px" Height="50px"
     ImageUrl="" /></div>
            <div class="col-2 border d-flex align-items-center justify-content-center"><asp:ImageButton ID="Img24" runat="server" Width="50px" Height="50px"
    ImageUrl="" /></div>
        </div>
     <div class="row g-0 fila-pantalla">
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x1</div>
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x2</div>
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x3</div>
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x4</div>
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x5</div>
            <div class="col-2 border d-flex align-items-center justify-content-center">Celda 2x6</div>
        </div>
  </div>  
  <div>
        <table id="trTeam" width="150px" border="0"
    style="background-color: #D7DBDE;">
    <tr>
        <td style="background-color: #E97D73" colspan="4">

            <asp:Label ID="lblCategoria" runat="server" Text="Primera División"
                CssClass="Texto" Font-Bold="False" ForeColor="White"></asp:Label>

        </td>
    </tr>
    <tr id="trTeam14" runat="server">
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td style="width: 40px; height: 40px;" align="center">
            
        </td>
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td>
            
        </td>
    </tr>
    <tr id="trTeam58" runat="server">
        <td style="width: 40px; height: 40px;" align="center">
            
        </td>
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td>
            
        </td>
    </tr>
    <tr id="trTeam912" runat="server">
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td style="width: 40px; height: 40px;" align="center">
          
        </td>
        <td style="width: 40px; height: 40px;" align="center">
            
        </td>
        <td>
           
        </td>
    </tr>
    <tr id="trTeam1316" runat="server">
        <td style="width: 40px; height: 40px;" align="center">
            
        </td>
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td style="width: 40px; height: 40px;" align="center">
           
        </td>
        <td>
           
        </td>
    </tr>
    <tr id="trTeam1720" runat="server">
        <td style="width: 50px; height: 50px;" align="center">
           
        </td>
        <td style="width: 50px; height: 50px;" align="center">
            
        </td>
        <td style="width: 50px; height: 50px;" align="center">
           
        </td>
        <td>
            
        </td>
    </tr>
    <tr id="trTeam2124" runat="server">
        <td style="width: 50px; height: 50px;" align="center">
           
        </td>
        <td style="width: 50px; height: 50px;" align="center">
            
        </td>
        <td style="width: 50px; height: 50px;" align="center">
           
        </td>
        <td>
            
        </td>
    </tr>
    <tr id="trTeam2528" runat="server">
        <td style="width: 50px; height: 50px;" align="center">
            <asp:ImageButton ID="Img25" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
        <td style="width: 50px; height: 50px;" align="center">
            <asp:ImageButton ID="Img26" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
        <td style="width: 50px; height: 50px;" align="center">
            <asp:ImageButton ID="Img27" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
        <td>
            <asp:ImageButton ID="Img28" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
    </tr>
    <tr id="trTeam2930" runat="server">
        <td>
            <asp:ImageButton ID="Img29" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
        <td>
            <asp:ImageButton ID="Img30" runat="server" Width="50px" Height="50px"
                ImageUrl="" />
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td colspan="4">Fechas </td>
    </tr>
    <tr>
        <td colspan="4" align="center">
            <table style="width: 150px" border="0">
                <tr id="trFecha1a5" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton1" runat="server" Font-Size="Medium">1</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton2" runat="server" Font-Size="Medium">2</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton3" runat="server" Font-Size="Medium">3</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton4" runat="server" Font-Size="Medium">4</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton5" runat="server" Font-Size="Medium">5</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha6a10" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton6" runat="server" Font-Size="Medium">6</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton7" runat="server" Font-Size="Medium">7</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton8" runat="server" Font-Size="Medium">8</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton9" runat="server" Font-Size="Medium">9</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton10" runat="server" Font-Size="Medium">10</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha11a15" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton11" runat="server" Font-Size="Medium">11</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton12" runat="server" Font-Size="Medium">12</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton13" runat="server" Font-Size="Medium">13</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton14" runat="server" Font-Size="Medium">14</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton15" runat="server" Font-Size="Medium">15</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha16a20" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton16" runat="server" Font-Size="Medium">16</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton17" runat="server" Font-Size="Medium">17</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton18" runat="server" Font-Size="Medium">18</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton19" runat="server" Font-Size="Medium">19</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton20" runat="server" Font-Size="Medium">20</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha21a25" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton21" runat="server" Font-Size="Medium">21</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton22" runat="server" Font-Size="Medium">22</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton23" runat="server" Font-Size="Medium">23</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton24" runat="server" Font-Size="Medium">24</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton25" runat="server" Font-Size="Medium">25</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha26a30" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton26" runat="server" Font-Size="Medium">26</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton27" runat="server" Font-Size="Medium">27</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton28" runat="server" Font-Size="Medium">28</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton29" runat="server" Font-Size="Medium">29</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton30" runat="server" Font-Size="Medium">30</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha31a35" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton31" runat="server" Font-Size="Medium">31</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton32" runat="server" Font-Size="Medium">32</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton33" runat="server" Font-Size="Medium">33</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton34" runat="server" Font-Size="Medium">34</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton35" runat="server" Font-Size="Medium">35</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trFecha36a40" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton36" runat="server" Font-Size="Medium">36</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton37" runat="server" Font-Size="Medium">37</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton38" runat="server" Font-Size="Medium">38</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton39" runat="server" Font-Size="Medium">39</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton40" runat="server" Font-Size="Medium">40</asp:LinkButton>
                    </td>
                </tr>
                <tr id="trfecha41a42" runat="server">
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton41" runat="server" Font-Size="Medium">41</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center">
                        <asp:LinkButton ID="LinkButton42" runat="server" Font-Size="Medium">42</asp:LinkButton>
                    </td>
                    <td style="width: 300px" align="center"></td>
                    <td style="width: 300px" align="center"></td>
                    <td style="width: 300px" align="center"></td>
                </tr>
            </table>
        </td>
    </tr>
</table>
</div>
</asp:Content>
