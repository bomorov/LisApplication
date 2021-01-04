$(document).ready(function () {

    $('#region-select').on('change', function () {

        let regionId = $(this).val();

        $.ajax({
            type: 'GET',
            url: '/Coate/LoadDistricts',
            dataType: 'json',
            data: {
                regionId: regionId
            },
            success: function (districts) {

                $('#district-select').empty();

                $('#district-select').append('<option value="">Выберите район</option>');

                if (districts.length > 0) {
                    $.each(districts, function (key, value) {
                        $('#district-select').append(new Option(value.name, value.id));
                    });
                }

                $('#countryside-select').empty();

                $('#countryside-select').append('<option value="">Выберите айыльный аймак</option>');

                $('#village-select').empty();

                $('#village-select').append('<option value="">Выберите поселок</option>');
            }
        });
    });


    $('#district-select').on('change', function () {

        let districtId = $(this).val();

        $.ajax({
            type: 'GET',
            url: '/Coate/LoadCountrysides',
            dataType: 'json',
            data: {
                districtId: districtId
            },
            success: function (countrysides) {

                $('#countryside-select').empty();

                $('#countryside-select').append('<option value="">Выберите айыльный аймак</option>');

                if (countrysides.length > 0) {
                    $.each(countrysides, function (key, value) {
                        $('#countryside-select').append(new Option(value.name, value.id));
                    });
                }

                $('#village-select').empty();

                $('#village-select').append('<option value="">Выберите поселок</option>');
            }
        });
    });


    $('#countryside-select').on('change', function () {

        let countrysideId = $(this).val();

        $.ajax({
            type: 'GET',
            url: '/Coate/LoadVillages',
            dataType: 'json',
            data: {
                countrysideId: countrysideId
            },
            success: function (villages) {

                $('#village-select').empty();

                $('#village-select').append('<option value="">Выберите поселок</option>');

                if (villages.length > 0) {
                    $.each(villages, function (key, value) {
                        $('#village-select').append(new Option(value.name, value.id));
                    });
                }
            }
        });
    });
});