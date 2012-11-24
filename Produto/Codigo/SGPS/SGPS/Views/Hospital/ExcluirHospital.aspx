<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.hospital>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Hospital
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Excluir registro</h2>
    <h4>
        Você quer mesmo excluir esse registro?</h4>
    <fieldset>
        <legend>Dados do registro</legend>
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
            <% if (Model != null)
               { %>
            <tr>
                <td>
                    <%: Model.strRazaoSocial%>
                </td>
                <td>
                    <%: Model.strCNPJ%>
                </td>
                <td>
                    <%: Model.strEndereco%>
                </td>
                <td>
                    <%: Model.strTelefone%>
                </td>
                <td>
                    <input type="submit" value="Excluir" />
                </td>
                <td>
                    <input type="button" id="btnCancelarHospital" value="Cancelar" onclick="javascript:history.back(-1);" />
                </td>
            </tr>
            <%} %>
        </table>
    </fieldset>
</asp:Content>
