<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.RelatoriosModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Emitir Relatórios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Emitir Relatórios</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <table>
        <tr>
            <th>
                Data de Início
            </th>
            <th>
                Data de Fim
            </th>
            <th>
                Tipo de relatório
            </th>
        </tr>
        <tr>
            <td>
                <%: Html.TextBoxFor(model => model.DtmDataInicio) %>
                <%: Html.ValidationMessageFor(model => model.DtmDataInicio) %>
            </td>
            <td>
                <%: Html.TextBoxFor(model => model.DtmDataFim) %>
                <%: Html.ValidationMessageFor(model => model.DtmDataFim) %>
            </td>
            <td>
                <%: Html.ActionLink("Atendimento", "Atendimento", "Relatorios")%>
                |
                <%: Html.ActionLink("Encaminhamento", "Encaminhamento", "Relatorios")%>
                |
                <%: Html.ActionLink("Material", "Material", "Relatorios")%>
            </td>
        </tr>
    </table>
    <% } %>
</asp:Content>
