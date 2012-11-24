﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<SGPS.Models.encaminhamento>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
    Gerenciar Encaminhamento
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <script type="text/javascript" src="~/Scripts/jquery-1.4.1.min.js"></script>
    <script src="~/Scripts/ListaHospital.js" type="text/javascript"></script>
    <script src="~/Scripts/ListaPaciente.js" type="text/javascript"></script>
    <script type="text/javascript">

        function PreencheCampos() {

            var agora = new Date();
            var dia = agora.getDay();
            var mes = agora.getMonth() + 1;
            var ano = agora.getFullYear();

            if (mes < 10) {
                var mes = "0" + mes;
            }

            var hora = agora.getHours();
            var min = agora.getMinutes();

            if (hora < 12) {
                var hora = "0" + hora;
            }

            if (min < 10) {
                var min = "0" + min;
            }

            var data = dia + "-" + mes + "-" + ano + " " + hora + ":" + min;

            document.getElementById("lblDataAtendimento").innerHTML = data;
            document.getElementById("iptDataAtendimento").innerHTML = data;
        }
    </script>
    <h2>
        Incluir novo Encaminhamento</h2>
    <% using (Html.BeginForm())
       {%>
    <%: Html.ValidationSummary(true) %>
    <fieldset>
        <legend>Campos</legend>
        <table>
            <tr>
                <th>
                    Nome do paciente
                </th>
                <th>
                    Motivo do Encaminhamento
                </th>
                <th>
                    Situação Atual
                </th>
                <th>
                    Data Atendimento
                </th>
                <th>
                    Hospital
                </th>
            </tr>
            <tr>
                <td>
                    <%: Html.DropDownListFor(model => model.idPaciente, this.ViewData["SelectList"] as SelectList, "Selecione um paciente") %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strMotivo) %>
                    <%: Html.ValidationMessageFor(model => model.strMotivo) %>
                </td>
                <td>
                    <%: Html.TextBoxFor(model => model.strSituacaoAtual) %>
                    <%: Html.ValidationMessageFor(model => model.strSituacaoAtual) %>
                </td>
                <td>
                    <label id="lblDataAtendimento" />
                    <input type="hidden" id="iptDataAtendimento" />
                </td>
                <td>
                    <%: Html.DropDownListFor(model => model.idHospital, this.ViewData["SelectList"] as SelectList, "Selecione um hospital") %>
                </td>
                <td>
                    <input type="button" value="Atualizar" onclick="PreencheCampos();" />
                </td>
            </tr>
        </table>
        <div id="partial">
        </div>
        <p>
            <input type="submit" value="Cadastrar" />
        </p>
    </fieldset>
    <% } %>
</asp:Content>
