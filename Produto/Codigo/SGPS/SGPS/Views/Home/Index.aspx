<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Home Page
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <%: ViewData["Message"] %></h2>
<%--    <% if (Request.IsAuthenticated)
       { %>
--%>    <p>
        Selecione o módulo que pretende navegar:
    </p>
    <div id="Div1" class="logo" runat="server">
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/Images/LOGO SGPS - Copy.png"
            Width="400px" HotSpotMode="Navigate" ImageAlign="Middle">
            <asp:RectangleHotSpot AlternateText="Ir para módulo de Hospital" Bottom="73" HotSpotMode="Navigate"
                Left="90" Right="190" NavigateUrl="/Hospital" />
            <asp:RectangleHotSpot AlternateText="Ir para módulo Atendimento" Bottom="73" Left="215"
                NavigateUrl="/Atendimento" Right="330" HotSpotMode="Navigate" />
            <asp:RectangleHotSpot AlternateText="Ir para módulo Encaminhamento" Bottom="150"
                NavigateUrl="/Encaminhamento" Right="150" Top="75" HotSpotMode="Navigate" />
            <asp:RectangleHotSpot AlternateText="Ir para módulo Paciente" Bottom="225" Left="300"
                NavigateUrl="/Paciente" Right="390" Top="150" HotSpotMode="Navigate" />
            <asp:RectangleHotSpot AlternateText="Ir para módulo Profissional" Bottom="400" Left="130"
                NavigateUrl="/Profissional" Right="230" Top="225" HotSpotMode="Navigate" />
            <asp:RectangleHotSpot AlternateText="Ir para módulo Estoque de Material" Bottom="400"
                Left="250" NavigateUrl="/MaterialAtendimento" Right="340" Top="226" HotSpotMode="Navigate" />
        </asp:ImageMap>
    </div>
<%--    <%}
       else
       { %>
    <p>
        É necessário autenticação no sistema para visualizar os módulos.
        <%: Html.ActionLink("Clique aqui", "LogOn", "Account") %>
    </p>
    <%} %>
--%></asp:Content>
