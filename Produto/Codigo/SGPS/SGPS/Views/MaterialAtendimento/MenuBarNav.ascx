<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
    <div id="menucontainer">
        <ul id="menu">
            <li>
                <%: Html.ActionLink("Pesquisa", "Index", "MaterialAtendimento")%></li>
            <li>
                <%: Html.ActionLink("Cadastrar", "Create", "MaterialAtendimento")%></li>
            <li>
                <%: Html.ActionLink("Excluir", "Index2", "MaterialAtendimento")%></li>
        </ul>
    </div>
