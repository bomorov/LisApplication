function ZagsPinBirthAct() {
    var pin = $('#Pin').val();
    $('#IsBirthCertificateExistNo').prop('checked', false);
    $('#IsMedicalCertificateExistNo').prop('checked', false);
    $('#IsBirthCertificateExistYes').prop('checked', false);
    $('#IsMedicalCertificateExistYes').prop('checked', false);
    $('#LastName').val('');
    $('#FirstName').val('');
    $('#Patronymic').val('');
    $('#DateOfBirth').val('');
    $('#Gender').val(1);
    $('#BirthCertificate').val('');
    $('#MotherPIN').val('');
    $('#MotherLastName').val('');
    $('#MotherFirstName').val('');
    $('#MotherPatronymic').val('');
    $('#FatherPIN').val('');
    $('#FatherLastName').val('');
    $('#FatherFirstName').val('');
    $('#FatherPatronymic').val('');
    if (pin.length === 14) {
        ajaxRequestMade = true;
        $.ajax({
            type: 'POST',
            url: '/Pin/ZagsPinBirthAct',
            dataType: 'json',
            data: {
                Pin: pin
            },
            statusCode: {
                200: function (data) {
                    if (data.child) {
                        var dFrom = moment(data.child.dfrom, 'DD-MM-YYYY');
                        $('#LastName').val(data.child.surname);
                        $('#FirstName').val(data.child.firstName);
                        $('#Patronymic').val(data.child.patronymic);
                        $('#DateOfBirth').val(dFrom.format('YYYY-MM-DD'));
                        if (data.child.gender == 1) {
                            $('#Gender').val(2);
                        }
                        else if (data.child.gender == 2) {
                            $('#Gender').val(1);
                        }
                    }
                    if (data.crtf) {
                        var crtfStr = data.crtf.docSeries + ' ' + data.crtf.docNumber + ', ' + data.crtf.docDate + ', ' + data.crtf.govUnit;
                        $('#BirthCertificate').val(crtfStr);
                        $('#IsBirthCertificateExistYes').prop('checked', true);
                        $('#IsMedicalCertificateExistYes').prop('checked', true);
                    }
                    else {
                        $('#IsBirthCertificateExistNo').prop('checked', false);
                        $('#IsMedicalCertificateExistNo').prop('checked', false);
                    }
                    if (data.mother) {
                        $('#MotherPIN').val(data.mother.pin);
                        $('#MotherLastName').val(data.mother.surname);
                        $('#MotherFirstName').val(data.mother.firstName);
                        $('#MotherPatronymic').val(data.mother.patronymic);
                    }
                    if (data.father) {
                        $('#FatherPIN').val(data.father.pin);
                        $('#FatherLastName').val(data.father.surname);
                        $('#FatherFirstName').val(data.father.firstName);
                        $('#FatherPatronymic').val(data.father.patronymic);
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