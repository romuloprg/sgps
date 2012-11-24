<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.hospital>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Hospital
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Script para exbibir nova linha de cadastro -->
    <script src="../../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $("#btnIncluirHospital").click(Incluir);
        });

        function Incluir() {

            $.get("Hospital/IncluirHospital", null, Incluir_CallBack, "Json");
        }
        function Incluir_CallBack(partial) {
            //Limpa o conteúdo da div
            $("#parcial").empty();

            if (partial) {
                //adiciona o novo conteúdo
                $("#parcial").append(partial);
            }
        }
    </script>
    <h2>
        Gerenciar Hospital</h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <!-- Filtro de pesquisa de cadastro de hospitais -->
    <div id="pesquisar">
        <% Html.RenderPartial("ControlePesquisa"); %>
    </div>
    <% } %>
    <!-- Caso haja novo cadastro -->
    <div>
        <%: ViewData["Message"] %>
    </div>
    <!-- Campos de exibição do cadastro de hospitais -->
    <fieldset>
        <legend>Hospitais Cadastrados</legend>
        <table>
            <tr>
                <th>
                </th>
                <th>
                    Razao Social
                </th>
                <th>
                    CNPJ
                </th>
                <th>
                    Endereco
                </th>
                <th>
                    Telefone
                </th>
                <td>
                    <input type="submit" id="btnIncluirHospital" value="Adicionar Cadastro" onclick="Incluir()" />
                </td>
            </tr>
            <% if (Model != null)
               { %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.ActionLink("Alterar", "AlterarHospital", new { id = item.idHospital })%>
                    |
                    <%: Html.ActionLink("Excluir", "ExcluirHospital", new { id = item.idHospital })%>
                </td>
                <td>
                    <%: item.strRazaoSocial%>
                </td>
                <td>
                    <%: item.strCNPJ%>
                </td>
                <td>
                    <%: item.strEndereco%>
                </td>
                <td>
                    <%: item.strTelefone%>
                </td>
            </tr>
            <% }
               }%>
        </table>
    </fieldset>
    <div id="parcial">
    </div>
</asp:Content>
