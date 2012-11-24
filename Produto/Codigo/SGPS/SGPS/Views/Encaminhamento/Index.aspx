<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.EncaminhamentoRelacionado>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Encaminhamentos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Encaminhamentos</h2>
    <table>
        <tr>
            <th>
            </th>
            <th>
                Nome Hospital
            </th>
            <th>
                Nome Paciente
            </th>
            <th>
                Motivo
            </th>
            <th>
                Situacao Atual
            </th>
            <th>
                Data Encaminhamento
            </th>
            <th>
                <%: Html.ActionLink("Incluir", "Create") %>
            </th>
        </tr>
        <% if (Model != null)
           { %>
        <% foreach (var item in Model)
           { %>
        <tr>
            <td>
                <%: Html.ActionLink("Alterar", "Edit", new { id=item.IdEncaminhamento }) %>
                |
                <%: Html.ActionLink("Excluir", "Delete", new { id=item.IdEncaminhamento })%>
            </td>
            <td>
                <%: item.NomeHospital %>
            </td>
            <td>
                <%: item.NomePaciente %>
            </td>
            <td>
                <%: item.Motivo %>
            </td>
            <td>
                <%: item.SituacaoAtual %>
            </td>
            <td>
                <%: String.Format("{0:g}", item.DataEncaminhamento) %>
            </td>
        </tr>
        <% }
           } %>
    </table>
    <p>
    </p>
</asp:Content>
