<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<SGPS.Models.hospital>" %>
<% using (Html.BeginForm())
   {%>
<%: Html.ValidationSummary(true) %>
<fieldset>
    <legend>Incluir novo cadastro de Hospital</legend>
    <table>
        <tr>
            <th>
                Razão Social
            </th>
            <th>
                CNPJ
            </th>
            <th>
                Endereço
            </th>
            <th>
                Telefone
            </th>
        </tr>
        <tr>
            <td>
                <%: Html.TextBoxFor(model => model.strRazaoSocial) %>
                <%: Html.ValidationMessageFor(model => model.strRazaoSocial) %>
            </td>
            <td>
                <%: Html.TextBoxFor(model => model.strCNPJ) %>
                <%: Html.ValidationMessageFor(model => model.strCNPJ) %>
            </td>
            <td>
                <%: Html.TextBoxFor(model => model.strEndereco) %>
                <%: Html.ValidationMessageFor(model => model.strEndereco) %>
            </td>
            <td>
                <%: Html.TextBoxFor(model => model.strTelefone) %>
                <%: Html.ValidationMessageFor(model => model.strTelefone) %>
            </td>
            <td>
                <input type="submit" value="Incluir" />
            </td>
        </tr>
    </table>
    <p>
    </p>
</fieldset>
<% } %>