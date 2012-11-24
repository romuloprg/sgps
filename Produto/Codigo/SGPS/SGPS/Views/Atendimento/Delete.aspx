<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.atendimento>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Delete
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<div>
       <% Html.RenderPartial("MenuBarNav"); %>
   </div>
    <h2>Delete</h2>

    <h3>Are you sure you want to delete this?</h3>
    <fieldset>
        <legend>Fields</legend>
        
        <div class="display-label">idAtendimento</div>
        <div class="display-field"><%: Model.idAtendimento %></div>
        
        <div class="display-label">strNomePaciente</div>
        <div class="display-field"><%: Model.strNomePaciente %></div>
        
        <div class="display-label">intData</div>
        <div class="display-field"><%: Model.intData %></div>
        
        <div class="display-label">strMotivo</div>
        <div class="display-field"><%: Model.strMotivo %></div>
        
        <div class="display-label">strProvidencia</div>
        <div class="display-field"><%: Model.strProvidencia %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Delete" /> |
		    <%: Html.ActionLink("Back to List", "Index") %>
        </p>
    <% } %>

</asp:Content>

