$(document).ready(function () {
	function autocomplete(inp, arr) {
		var currentFocus;
		inp.addEventListener("input", function (e) {
			var a, b, i, val = this.value;
			closeAllLists();
			if (!val) { return false; }
			currentFocus = -1;
			a = document.createElement("DIV");
			a.setAttribute("id", this.id + "autocomplete-list");
			a.setAttribute("class", "autocomplete-items");
			this.parentNode.appendChild(a);
			for (i = 0; i < arr.length; i++) {
				if (arr[i].fullName.includes(val)) {
					b = document.createElement("DIV");
					b.innerHTML = arr[i].fullName.substr(0, val.length);
					b.innerHTML += arr[i].fullName.substr(val.length);
					b.innerHTML += "<input type='hidden' value='" + arr[i].id + "'>";
					b.addEventListener("click", function (e) {
						$.ajax({
							type: 'GET',
							url: '/Detection/GetQuestionnaireById',
							dataType: 'json',
							data: {
								id: this.getElementsByTagName("input")[0].value
							},
							success: function (response) {
								$("#LastName").val(response.lastName);
								$("#FirstName").val(response.firstName);
								$("#Patronymic").val(response.patronymic);
								$("#Street").val(response.street);
								$("#House").val(response.house);
								$("#Flat").val(response.flat);
								$("#SiteNumber").val(response.site);
							}
						});
						closeAllLists();
					});
					a.appendChild(b);
				}
			}
		});
		inp.addEventListener("keydown", function (e) {
			var x = document.getElementById(this.id + "autocomplete-list");
			if (x) x = x.getElementsByTagName("div");
			if (e.keyCode == 40) {
				currentFocus++;
				addActive(x);
			} else if (e.keyCode == 38) {
				currentFocus--;
				addActive(x);
			} else if (e.keyCode == 13) {
				e.preventDefault();
				if (currentFocus > -1) {
					if (x) x[currentFocus].click();
				}
			}
		});
		function addActive(x) {
			if (!x) return false;
			removeActive(x);
			if (currentFocus >= x.length) currentFocus = 0;
			if (currentFocus < 0) currentFocus = (x.length - 1);
			x[currentFocus].classList.add("autocomplete-active");
		}
		function removeActive(x) {
			for (var i = 0; i < x.length; i++) {
				x[i].classList.remove("autocomplete-active");
			}
		}
		function closeAllLists(elmnt) {
			var x = document.getElementsByClassName("autocomplete-items");
			for (var i = 0; i < x.length; i++) {
				if (elmnt != x[i] && elmnt != inp) {
					x[i].parentNode.removeChild(x[i]);
				}
			}
		}
		document.addEventListener("click", function (e) {
			closeAllLists(e.target);
		});
	}

	var filldata;

	$('#LastName, #FirstName').on('keyup', function (e) {
		var lastname = $('#LastName').val();
		var noWhitespaceLastname = lastname.replace(/\s+/g, '');
		var firstname = $('#FirstName').val();
		var noWhitespaceFirstName = firstname.replace(/\s+/g, '');
		if (noWhitespaceLastname.length == 3 || noWhitespaceFirstName.length == 3) {
			$.ajax({
				type: 'GET',
				url: '/Detection/GetQuestionnaireFio',
				dataType: 'json',
				data: {
					lastName: noWhitespaceLastname,
					firstName: noWhitespaceFirstName
				},
				success: function (response) {
					filldata = response;
					if (e.target.id === 'LastName') {
						autocomplete(document.getElementById("LastName"), filldata);
					}
					else if (e.target.id === 'FirstName') {
						autocomplete(document.getElementById("FirstName"), filldata);
					}
				}
			});
		}
	});

	$('input[type="radio"]').on('click', function () {
		//this.checked = !this.checked;

		var $radio = $(this);

		// if this was previously checked
		if ($radio.data('waschecked') === true) {
			$radio.prop('checked', false);
			$radio.data('waschecked', false);
		}
		else {
			$radio.data('waschecked', true);
		}
		var name = $radio.prop('name');
		var answer;
		if ($radio.val() === "Yes") {
			answer = "No";
		} else {
			answer = "Yes";
		}
		$('input[name="' + name + '"][value="' + answer + '"]').data('waschecked', false);
	});

	$("#ChildLiveWithId").change(function () {
		$('#block-three').find(':input').each(function () {
			switch (this.type) {
				case 'text':
					$(this).val('');
					break;
				case 'radio':
					this.checked = false;
			}
		});
		$('#WithoutParentalCareId').val(null).trigger('change');
		if (this.value > 3) {
			$("#childLiveWith").removeClass("d-none");
		}
		else {
			$("#childLiveWith").addClass("d-none");
		}
	});
});