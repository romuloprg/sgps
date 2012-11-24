<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.material>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Estoque de Material
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <% Html.RenderPartial("MenuBarNav"); %>
    </div>
    <h3>
        Excluir registro</h3>
    <h4>
        Você quer mesmo excluir esse registro?</h4>
    <fieldset>
        <legend>Fields</legend>
        <table>
            <tr>
                <th>
                    Descrição do Material
                </th>
                <th>
                    Quantidade do Material
                </th>
            </tr>
            <% if (Model != null)
               { %>
            <tr>
                <td>
                    <%: Model.strDesMat%>
                </td>
                <td>
                    <%: Model.strQtdMat%>
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
