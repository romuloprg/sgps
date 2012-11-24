$(document).ready(function () {
    //Assina o evento onchange do dropdownlist
    $("#Pacientes").change(Pacientes_Change);
});

function Pacientes_Change() {
    //Envia o item selecionado para Action do controller
    $.post("Encaminhamento/ListaAtendimento", {idPaciente: $("#Pacientes").val()}, Pacientes_CallBack, "Json");
}

function Pacientes_CallBack(partial) {
    //Limpa conteúdo da div
    $("#partial").empty();

    if (partial) {

        //adiciona novo conteúdo
        $("#partial").append(partial);
    }
}