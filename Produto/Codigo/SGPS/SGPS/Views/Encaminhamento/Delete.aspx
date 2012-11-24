<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.EncaminhamentoRelacionado>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Gerenciar Encaminhamentos
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Confirma a exclusão do item?</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
        <table>
            <tr>
                <th>
                    Nome do paciente
                </th>
                <th>
                    Motivo do Encaminhamento
                </th>
                <th>
                    Situação Atual
                </th>
                <th>
                    Data Atendimento
                </th>
                <th>
                    Hospital
                </th>
            </tr>
            <% if (Model != null)
               { %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.Label(item.NomePaciente)%>
                </td>
                <td>
                    <%: Html.Label(item.Motivo)%>
                </td>
                <td>
                    <%: Html.Label(item.SituacaoAtual)%>
                </td>
                <td>
                    <%: Html.Label(String.Format("{0:dd/MM/yyyy}",item.DataEncaminhamento))%>
                </td>
                <td>
                    <%: Html.Label(item.NomeHospital)%>
                </td>
            </tr>
            <%}
               } %>
        </table>
        <div id="partial">
        </div>
        <p>
            <input type="submit" value="Deletar" />
        </p>
    </fieldset>
    <% } %>

</asp:Content>

