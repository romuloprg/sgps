<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.AtendimentoPaciente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Atendimento
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Gerenciar Atendimento</h2>
    <% using (Html.BeginForm())
       {%>
    <fieldset>
        <div>
            <table>
                <tr>
                    <th>
                    </th>
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
                    <th>
                        <%: Html.ActionLink("Novo Atendimento", "Create")%>
                    </th>
                </tr>
                <% if (Model != null)
                   { %>
                <% foreach (var item in Model)
                   { %>
                <tr>
                    <td>
                        <%: Html.ActionLink("Editar", "Edit", new { id = item.IdAtendimento })%> |
                        <%: Html.ActionLink("Excluir", "Delete", new { id = item.IdAtendimento })%>
                    </td>
                    <td>
                        <%: item.NomePaciente%>
                    </td>
                    <td>
                        <%: item.MotivoAtendimento%>
                    </td>
                    <td>
                        <%: item.ProvidenciaAtendimento%>
                    </td>
                    <td>
                        <%: Html.Label(String.Format("{0:dd/MM/yyyy}",item.DataAtendimento))%>
                    </td>
                </tr>
                <% }
                   }%>
            </table>
        </div>
    </fieldset>
    <% } %>
</asp:Content>
