$(document).ready(function () {

    $('.showPlanBtn').click(function () {

        $('#ipzrPlanDiv').empty();
        $('tr').removeClass('shadow-lg bg-white');

        let element = $(this);
        let questionnaireId = element.data("id");

        $.ajax({
            type: 'Get',
            url: '/Ipzr/GetIpzrPlans?questionnaireId=' + questionnaireId,
            dataType: 'html',
            success: function (result) {
                $('#ipzrPlanDiv').html(result);

                let row = element.closest("tr");
                row.addClass('shadow-lg bg-white');
            }
        });

    });

});