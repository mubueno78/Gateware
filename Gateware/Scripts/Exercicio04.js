$(function () {
    "use strict";
    $(document).ready(function () {

        $(".btnExecutar").click(function () {

            $('.ddlEstado').html("");

            $('.ddlEstado').append($('<option>', {
                value: 0,
                text: 'Selecione'
            }));

            $.getJSON("scripts/estados.json", function (data) {
                for (var i = 0; i < data.UF.length; i++) {
                    $('.ddlEstado').append($('<option>', {
                        value: data.UF[i].sigla,
                        text: data.UF[i].nome
                    }));
                }
            });
        });
    });
});