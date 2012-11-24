<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
  <div id="menucontainer">
       <ul id="menu">
           <li> <%: Html.ActionLink("Pesquisa", "Index", "Atendimento")%></li>
           <li> <%: Html.ActionLink("Cadastrar", "Create", "Atendimento")%></li>
           <li> <%: Html.ActionLink("Excluir", "Index2", "Atendimento")%></li> 
       </ul>
  </div>