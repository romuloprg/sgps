<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<System.Object>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Gerenciar Atendimento
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Gerenciar Atendimento</h2>
    <table>
        <tr>
            <th></th>
            <th>
                Paciente
            </th>
            <th>
                Motivo
            </th>
            <th>
                Providencia
            </th>
            <th>
                Data Atendimento
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.idAtendimento }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.idAtendimento })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.idAtendimento })%>
            </td>
            <td>
                <%: item.idAtendimento %>
            </td>
            <td>
                <%: item.strNomePaciente %>
            </td>
            <td>
                <%: item.intData %>
            </td>
            <td>
                <%: item.strMotivo %>
            </td>
            <td>
                <%: item.strProvidencia %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>

</asp:Content>

