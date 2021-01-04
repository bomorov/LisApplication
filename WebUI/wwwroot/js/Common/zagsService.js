$('#Pin').on('keyup', function () {
    if ($(this).val().length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/ZagsDataByPin',
            dataType: 'json',
            data: {
                Pin: $(this).val()
            },
            statusCode: {
                200: function (data) {
                    $("#LastName").val(data.surname);
                    $("#FirstName").val(data.name);
                    $("#Patronymic").val(data.patronymic);
                },
                400: function (error) {
                    var alertResult = error.responseJSON;
                    var htmlText = "";
                    alertResult.messages.forEach(element => htmlText += element + "<br>");
                    toastr.error(htmlText);
                    $("#LastName").val('');
                    $("#FirstName").val('');
                    $("#Patronymic").val('');
                }
            }
        });
    }
    else {
        ajaxRequestMade = false;
    }
});