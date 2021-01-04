$(document).ready(function () {
    $('.showAuditBtn').click(function () {
        $('#auditRecordDiv').empty();
        $('tr').removeClass('shadow-lg bg-white');

        let element = $(this);
        let recordId = element.data("id");
        let auditType = element.data("type");

        $.ajax({
            type: 'Get',
            url: '/AuditRecord/GetAuditRecords?recordId=' + recordId + '&auditRecordType=' + auditType,
            dataType: 'html',
            success: function (result) {
                $('#auditRecordDiv').html(result);

                let row = element.closest("tr");
                row.addClass('shadow-lg bg-white');
            }
        });
    });
});