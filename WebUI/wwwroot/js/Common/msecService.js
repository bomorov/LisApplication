function MsecDetails() {
    var pin = $('#Pin').val();
    $('#IsDisabledYes').prop('checked', false);
    $('#IsMSEKExistYes').prop('checked', false);
    $('#IsDisabledNo').prop('checked', false);
    $('#IsMSEKExistNo').prop('checked', false);
    $('#IsNeedTechnicalAidsYes').prop('checked', false);
    $('#IsNeedTechnicalAidsNo').prop('checked', false);
    $('#IsReferralForRehabilitationExistYes').prop('checked', false);
    $('#IsReferralForRehabilitationExistNo').prop('checked', false);
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/MsecDetails',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    if (data.isDisabled) {
                        $('#IsDisabledYes').prop('checked', true);
                        $('#IsMSEKExistYes').prop('checked', true);
                        if (data.wheelchairGoal) {
                            $('#IsNeedTechnicalAidsYes').prop('checked', true);
                        }
                        if (data.hasIpr) {
                            $('#IsReferralForRehabilitationExistYes').prop('checked', true);
                        }
                        toastr.success('У ребенка имеется инвалидность.');
                    } else {
                        var htmlText = "наименование организации: " + data.organizationName + "<br>"
                            + "дата освидетельствования: " + data.examinationDate + "<br>"
                            + "тип освидетельствования: " + data.examinationType + "<br>"
                            + "группа инвалидности: " + data.disabilityGroup + "<br>"
                            + "инвалидность с: " + data.from + "<br>"
                            + "инвалидность по: " + data.to + "<br>"
                            + "время наступления инвалидности: " + data.timeOfDisability + "<br>"
                            + "дата очередного освидетельствования: " + data.reExamination + "<br>";
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
                        toastr.success(htmlText);
                    }
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