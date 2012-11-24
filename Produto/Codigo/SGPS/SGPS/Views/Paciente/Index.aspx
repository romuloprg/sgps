<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.paciente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Index
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Index</h2>

    <table>
        <tr>
            <th></th>
            <th>
                idPaciente
            </th>
            <th>
                strNome
            </th>
            <th>
                strCategoria
            </th>
            <th>
                strDataDeNascimento
            </th>
            <th>
                strCpf
            </th>
            <th>
                strEndereco
            </th>
            <th>
                strTelefone
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "Edit", new { id=item.idPaciente }) %> |
                <%: Html.ActionLink("Details", "Details", new { id=item.idPaciente })%> |
                <%: Html.ActionLink("Delete", "Delete", new { id=item.idPaciente })%>
            </td>
            <td>
                <%: item.idPaciente %>
            </td>
            <td>
                <%: item.strNome %>
            </td>
            <td>
                <%: item.strCategoria %>
            </td>
            <td>
                <%: item.strDataDeNascimento %>
            </td>
            <td>
                <%: item.strCpf %>
            </td>
            <td>
                <%: item.strEndereco %>
            </td>
            <td>
                <%: item.strTelefone %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Carregar dados de pacientes", "LerXML") %>
        <%: ViewData["Message"] %>
    </p>

</asp:Content>

