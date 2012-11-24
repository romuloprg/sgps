<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.material>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Estoque de Materiais
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <% Html.RenderPartial("MenuBarNav"); %>
    </div>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Excluir Cadastro </legend>
        <div class="display-label">
            <%: Html.Label("Nome: ") %>
            <%: Html.TextBox("namePesquisa") %>
            <input type="submit" value="Pesquisar" name="bttPesquisar" />
        </div>
    </fieldset>
    <% } %>
    <fieldset>
        <legend>Resultado da Pesquisa</legend>
        <table>
            <tr>
                <th>
                </th>
                <th>
                    Descrição Material
                </th>
                <th>
                    Quantidade Material
                </th>
            </tr>
            <% if (Model != null)
               { %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.ActionLink("Excluir", "Delete", new { id = item.idMaterial })%>
                </td>
                <td>
                    <%: item.strDesMat%>
                </td>
                <td>
                    <%: item.strQtdMat%>
                </td>
            </tr>
            <% }
               } %>
        </table>
        </fieldset>
</asp:Content>
