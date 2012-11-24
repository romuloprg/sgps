<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.AtendimentoPaciente>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Atendimento
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Editar Registro</h2>
    <% using (Html.BeginForm()) {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
        <table>
            <tr>
                <th>
                    Nome do Paciente
                </th>
                <th>
                    Motivo Atendimento
                </th>
                <th>
                    Providência
                </th>
            </tr>
            <% foreach (var item in Model)
                   { %>
            <tr>
                <td>
                    <%: Html.LabelFor(model => item.NomePaciente) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => item.MotivoAtendimento) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => item.ProvidenciaAtendimento) %>
                </td>
            </tr>
            <%} %>
        </table>
        <p>
            <input type="submit" value="Salvar" />
        </p>
    </fieldset>
    <% } %>
</asp:Content>
