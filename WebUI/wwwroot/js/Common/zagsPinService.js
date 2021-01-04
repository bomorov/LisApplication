function ZagsMotherPin() {
    var pin = $('#MotherPIN').val();
    $("#MotherLastName").val('');
    $("#MotherFirstName").val('');
    $("#MotherPatronymic").val('');
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/ZagsDataByPin',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    $("#MotherLastName").val(data.surname);
                    $("#MotherFirstName").val(data.name);
                    $("#MotherPatronymic").val(data.patronymic);
                },
                400: function (error) {
                    var alertResult = error.responseJSON;
                    var htmlText = "";
                    alertResult.messages.forEach(element => htmlText += element + "<br>");
                    toastr.error(htmlText);
                }
            }
        });
    }
    else {
        ajaxRequestMade = false;
    }
};

function ZagsFatherPin() {
    var pin = $('#FatherPIN').val();
    $("#FatherLastName").val('');
    $("#FatherFirstName").val('');
    $("#FatherPatronymic").val('');
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/ZagsDataByPin',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    $("#FatherLastName").val(data.surname);
                    $("#FatherFirstName").val(data.name);
                    $("#FatherPatronymic").val(data.patronymic);
                },
                400: function (error) {
                    var alertResult = error.responseJSON;
                    var htmlText = "";
                    alertResult.messages.forEach(element => htmlText += element + "<br>");
                    toastr.error(htmlText);
                }
            }
        });
    }
    else {
        ajaxRequestMade = false;
    }
};