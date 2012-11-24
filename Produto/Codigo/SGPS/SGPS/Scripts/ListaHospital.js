$(document).ready(function () {
    //Assina o evento onchange do dropdownlist
    $("#Hospitais").change(Hospitais_Change);
});

function Hospitais_Change() {
    //Envia o item selecionado para Action do controller
    $.post("Encaminhamento/ListaHospital", { idHospital: $("#Hospitais").val() }, Hospitais_CallBack, "Json");
}

function Hospitais_CallBack(partial) {
    //Limpa conteúdo da div
    $("#partial").empty();

    if (partial) {

        //adiciona novo conteúdo
        $("#partial").append(partial);
    }
}