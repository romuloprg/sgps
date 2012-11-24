<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.profissional>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Profissional
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Excluir Registro</h2>
    <h3>
        Você quer mesmo excluir esse registro?</h3>
    <fieldset>
        <legend>Campos</legend>
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
                    Horário
                </th>
                <th>
                    Escala
                </th>
            </tr>
            <% if (Model != null)
               { %>
            <tr>
                <td>
                    <%: Model.strNome%>
                </td>
                <td>
                    <%: Model.strCPF%>
                </td>
                <td>
                    <%: Model.strCargo%>
                </td>
                <td>
                    <%: String.Format("{0:t}", Model.dtmHorario)%>
                </td>
                <td>
                    <%: Model.strEscala%>
                </td>
                <td>
                    <input type="button" id="btnCancelarProfissional" value="Cancelar" onclick="javascript:history.back(-1);" />
                </td>
            </tr>
            <%} %>
        </table>
    </fieldset>
    <% using (Html.BeginForm())
       { %>
    <p>
        <input type="submit" value="Excluir" />
    </p>
    <% } %>
</asp:Content>
