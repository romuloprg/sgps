<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<SGPS.Models.materialatendimento>>" %>
<script type="text/javascript">
    $(document).ready(function () {

        $("ddlMaterialAtendimento").change(MaterialAtendimento_Change);

    });

    function MaterialAtendimento_Change() {

        $.post("MaterialAtendimento/ListaMaterial", { idMaterial: $("#ddlMaterialAtendimento").val() }, MaterialAtendimento_CallBack, "Json");
    }

    function MaterialAtendimento_CallBack() {
        $("#partial").empty();

        if (partial) {
            $("#partial").append(partial);
        }
    }
</script>
<table>
    <tr>
        <th>
            <%: Html.DropDownList("Materials", this.ViewData["material"] as SelectList, "Selecione material") %>
        </th>
    </tr>
</table>
