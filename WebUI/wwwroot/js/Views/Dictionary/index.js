$('.delete-alert').click(function () {

	let elem = $(this);
	let item_id = elem.data('itemid');
	let item_dictName = elem.data('itemdictname');
	console.log(item_dictName);
	let item_url = elem.data('itemurl');
	swal({
		title: "Вы уверены?",
		text: "Выбранная запись будет удалена из системы!",
		type: "warning",
		showCancelButton: true,
		cancelButtonText: "Отмена",
		confirmButtonColor: "#663399",
		confirmButtonText: "Да, удалить запись!",
		closeOnConfirm: false
	}, function () {
		$.ajax({
			type: 'POST',
			url: item_url,
			dataType: 'json',
			data: {
				Id: item_id,
				DictName: item_dictName
			},
			statusCode: {
				200: function () {
					let row = elem.parents('tr');
					row.remove();
					swal({
						title: "Удалено!",
						text: "Запись успешно удалена.",
						type: "success",
						timer: 1250,
						showConfirmButton: false
					});
				},
				400: function (error) {
					var htmlText = "";
					error.responseJSON.messages.forEach(element => htmlText += element + "<br />");
					swal({ html: true, title: 'Не удалено!', text: htmlText, type: "error" });
				}
			}
		});
	});

});