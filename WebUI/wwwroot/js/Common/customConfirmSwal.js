$('.confirm-alert').click(function () {

	let elem = $(this);
	let item_id = elem.data('itemid');
	let item_url = elem.data('itemurl');
	swal({
		title: "Вы уверены?",
		text: "Сбросить пароль этого пользователя!",
		type: "warning",
		showCancelButton: true,
		cancelButtonText: "Отмена",
		confirmButtonColor: "#663399",
		confirmButtonText: "Да, сбросить пароль!",
		closeOnConfirm: false
	}, function () {
		$.ajax({
			type: 'POST',
			url: item_url,
			dataType: 'json',
			data: {
				Id: item_id
			},
			statusCode: {
				200: function () {
					swal({
						title: "Успешно!",
						text: "Пароль успешно сброшен.",
						type: "success",
						timer: 1250,
						showConfirmButton: false
					});
				},
				400: function (error) {
					var htmlText = "";
					error.responseJSON.messages.forEach(element => htmlText += element + "<br />");
					swal({ html: true, title: 'Ошибка!', text: htmlText, type: "error" });
				}
			}
		});
	});

});