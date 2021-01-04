$(document).ready(function () {

    $('#organization-select').on('change', function () {

        let organizationId = $(this).val();

        $.ajax({
            type: 'GET',
            url: '/User/GetDivisions',
            dataType: 'json',
            data: {
                organizationId: organizationId
            },
            success: function (result) {

                $('#division-select').empty();
                $('#position-select').empty();
                $('#district-select').empty();

                $('#division-select').append('<option>Выберите подразделение</option>');
                $('#position-select').append('<option>Выберите должность</option>');
                $('#district-select').append('<option>Выберите район</option>');

                if (result.divisions.length > 0) {
                    $.each(result.divisions, function (key, value) {
                        $('#division-select').append(new Option(value.name, value.id));
                    });
                }

                if (result.positions.length > 0) {
                    $.each(result.positions, function (key, value) {
                        $('#position-select').append(new Option(value.name, value.id));
                    });
                }

                if (result.coateRecords.length > 0) {
                    $.each(result.coateRecords, function (key, value) {
                        $('#district-select').append(new Option(value.name, value.id));
                    });
                }
            }
        });
    });
});