<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.profissional>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Profissional
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Editar Cadastro</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
        <table>
            <tr>
                <th>
                    <%: Html.Label("Nome") %>
                </th>
                <th>
                    <%: Html.Label("CPF") %>
                </th>
                <th>
                    <%: Html.Label("Cargo") %>
                </th>
                <th>
                    <%: Html.Label("Horario") %>
                </th>
                <th>
                    <%: Html.Label("Escala") %>
                </th>
            </tr>
            <tr>
                <td>
                    <%: Html.TextBoxFor(model => model.strNome) %>
                    <%: Html.ValidationMessageFor(model => model.strNome) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strCPF) %>
                    <%: Html.ValidationMessageFor(model => model.strCPF) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strCargo) %>
                    <%: Html.ValidationMessageFor(model => model.strCargo) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.dtmHorario, String.Format("{0:t}", Model.dtmHorario)) %>
                    <%: Html.ValidationMessageFor(model => model.dtmHorario) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strEscala) %>
                    <%: Html.ValidationMessageFor(model => model.strEscala) %>
                </td>
                <td>
                    <input type="submit" value="Alterar" />
                </td>
                <td>
                    <input type="button" id="btnCancelarHospital" value="Cancelar" onclick="javascript:history.back(-1);" />
                </td>
            </tr>
        </table>
        <p>
            <%: ViewData["Message"] %>
        </p>
    </fieldset>
    <% } %>
</asp:Content>
