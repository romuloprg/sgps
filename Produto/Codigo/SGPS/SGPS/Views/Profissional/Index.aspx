<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<SGPS.Models.profissional>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Profissional
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Script para exbibir nova linha de cadastro -->
    <script src="../../Scripts/jquery-1.4.1.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $("#btnIncluirProfissional").click(Incluir);
        });

        function Incluir() {

            $.get("Profissional/IncluirProfissional", null, Incluir_CallBack, "Json");
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
        Gerenciar Profissional</h2>
    <% using (Html.BeginForm())
       { %>
    <%: Html.ValidationSummary(true) %>
    <!-- Filtro de pesquisa de cadastro de hospitais -->
    <div id="pesquisar">
        <% Html.RenderPartial("ControlePesquisa"); %>
    </div>
    <% } %>
    <fieldset>
        <legend>Resultado da Pesquisa</legend>
        <table>
            <tr>
                <th>
                </th>
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
                    Horário
                </th>
                <th>
                    Escala
                </th>
                <td>
                    <input type="submit" id="btnIncluirProfissional" value="Adicionar Cadastro" onclick="Incluir()" />
                </td>
            </tr>
            <% if (Model != null)
               { %>
            <% foreach (var item in Model)
               { %>
            <tr>
                <td>
                    <%: Html.ActionLink("Alterar", "AlterarProfissional", new { id = item.idProfissional })%>
                    |
                    <%: Html.ActionLink("Excluir", "ExcluirProfissional", new { id = item.idProfissional })%>
                </td>
                <td>
                    <%: item.strNome%>
                </td>
                <td>
                    <%: item.strCPF%>
                </td>
                <td>
                    <%: item.strCargo%>
                </td>
                <td>
                    <%: String.Format("{0:t}", item.dtmHorario)%>
                </td>
                <td>
                    <%: item.strEscala%>
                </td>
            </tr>
            <% }
               } %>
        </table>
    </fieldset>
    <div id="parcial">
    </div>
</asp:Content>
