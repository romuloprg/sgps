<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

    <fieldset>
        <legend>Filtro de pesquisa </legend>
        <div class="display-label">
            <%: Html.Label("Nome: ") %>
            <%: Html.TextBox("namePesquisa") %>
            <input type="submit" value="Pesquisar" name="bttPesquisar" />
            <%: Html.Label("Para pesquisar um determinado cadastro inclua a razão social e pressione o botão Pesquisar")%>
        </div>
    </fieldset>