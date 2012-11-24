<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.material>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Estoque de Material
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <% Html.RenderPartial("MenuBarNav"); %>
    </div>
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
                    Descrição do Material
                </th>
                <th>
                    Quantidade do Material
                </th>
            </tr>
            <tr>
                <td>
                    <%: Html.TextBoxFor(model => model.strDesMat) %>
                    <%: Html.ValidationMessageFor(model => model.strDesMat) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strQtdMat) %>
                    <%: Html.ValidationMessageFor(model => model.strQtdMat) %>
                </td>
            </tr>
            </table>
                    <p>
            <input type="submit" value="Save" />
            <%: ViewData["Message"] %>
        </p>
    </fieldset>
    <% } %>
</asp:Content>
