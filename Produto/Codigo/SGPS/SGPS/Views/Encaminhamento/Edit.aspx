<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.encaminhamento>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Encaminhamentos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Alterar dados</h2>
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
            <% if (Model != null){ %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.DropDownListFor(model => item.idPaciente, (IEnumerable<SelectListItem>)ViewData["idPaciente"])%>
                    <%: Html.ValidationMessageFor(model => item.idPaciente)%>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => item.strMotivo)%>
                    <%: Html.ValidationMessageFor(model => item.strMotivo)%>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => item.strSituacaoAtual)%>
                    <%: Html.ValidationMessageFor(model => item.strSituacaoAtual)%>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => item.dtmDataEncaminhamento)%>
                </td>
                <td>
                    <%: Html.DropDownListFor(model => item.idHospital, (IEnumerable<SelectListItem>)ViewData["idHospital"])%>
                </td>
            </tr>
            <%}} %>
        </table>
        <p>
            <input type="submit" value="Atualizar" />
        </p>
    </fieldset>
    <% } %>
</asp:Content>
