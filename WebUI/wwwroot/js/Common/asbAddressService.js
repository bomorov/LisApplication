function AsbAdress() {
    var pin = $('#Pin').val();
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/AsbAddress',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    toastr.options = {
                        "closeButton": true,
                        "debug": false,
                        "newestOnTop": false,
                        "progressBar": false,
                        "preventDuplicates": false,
                        "onclick": null,
                        "showDuration": "0",
                        "hideDuration": "0",
                        "timeOut": "0",
                        "extendedTimeOut": "0",
                        "tapToDismiss": false,
                        "showMethod": "fadeIn",
                        "hideMethod": "fadeOut"
                    }
                    toastr.success(data.address);
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