<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.material>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Estoque de Materiais
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <% Html.RenderPartial("MenuBarNav"); %>
    </div>
    <h3>
        Adicionar novo registro</h3>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
        <table>
            <tr>
                <th>
                    Descrição do material
                </th>
                <th>
                    Quantidade
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
            <input type="submit" value="Criar" />
            <%: ViewData["Message"] %>
        </p>
    </fieldset>
    <% } %>
</asp:Content>
