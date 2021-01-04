function CadastrePin() {
    var pin = $('#Pin').val();
    $('#IsChildHasOwnHomeYes').prop('checked', false);
    $('#IsChildHasOwnHomeNo').prop('checked', false);
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/Cadastre',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    toastr.success('У ребенка имеется недвижимость.')
                    $('#IsChildHasOwnHomeYes').prop('checked', true);
                    var responseArray = data.searchpinAllResult.sfp;
                    responseArray.forEach(function (arrayItem) {
                        $("#myTable").find('tbody')
                            .append("<tr><td>" + arrayItem.address + "</td><td>" + arrayItem.docNum + "</td><td>" + moment(arrayItem.regDate).format('DD-MM-YYYY') + "</td><td></tr>");
                    });
                },
                400: function (error) {
                    var alertResult = error.responseJSON;
                    var htmlText = "";
                    alertResult.messages.forEach(element => htmlText += element + "<br>");
                    $('#IsChildHasOwnHomeNo').prop('checked', true);
                    toastr.error(htmlText);
                }
            }
        });
    }
    else {
        ajaxRequestMade = false;
    }
};