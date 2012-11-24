<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<SGPS.Models.profissional>" %>
<% using (Html.BeginForm())
   {%>
<%: Html.ValidationSummary(true) %>
<fieldset>
    <legend>Incluir novo cadastro de Profissional</legend>
    <table>
        <tr>
            <th>
                Nome
            </th>
            <th>
                CPF
            </th>
            <th>
                Cargo
            </th>
            <th>
                Horario
            </th>
            <th>
                Escala
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
                <%: Html.TextBoxFor(model => model.dtmHorario) %>
                <%: Html.ValidationMessageFor(model => model.dtmHorario) %>
            </td>
            <td>
                <%: Html.TextBoxFor(model => model.strEscala) %>
                <%: Html.ValidationMessageFor(model => model.strEscala) %>
            </td>
            <td>
                <input type="submit" value="Incluir" />
            </td>
        </tr>
    </table>
</fieldset>
<% } %>