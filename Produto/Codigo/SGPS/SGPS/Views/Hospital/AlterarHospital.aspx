<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.hospital>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Hospital
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
                <td><input type="submit" id="btnAtualizarHospital" value="Atualizar" /></td>
                <td><input type="button" id="btnCancelarHospital"  value="Cancelar" onclick="javascript:history.back(-1);"  /></td>
            </tr>
        </table>
    </fieldset>
    <% } %>
</asp:Content>
