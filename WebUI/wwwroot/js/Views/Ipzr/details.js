$(document).ready(function () {
	$('.finishIpzrEventBtn').click(function () {
		let selectedIpzrEventId = $(this).data("id");
		$('#ipzrEventIdInput').val(selectedIpzrEventId);
	});

	$('.notFinishIpzrEventBtn').click(function () {
		let selectedIpzrEventId = $(this).data("id");
		$('#ipzrEventNotExecutedIdInput').val(selectedIpzrEventId);
	});
});