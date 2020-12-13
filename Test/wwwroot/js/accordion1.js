$(document).ready(function () {

	enableAccordions(); // Accordion

	/* Accordions */
	function enableAccordions() {

		$('.accordions').each(function () {

			// Set First Accordion As Active
			$(this).find('.accordion-content').hide();
			//if(!$(this).hasClass('toggles')){
			//	$(this).find('.accordion:first-child').addClass('accordion-active');
			//	$(this).find('.accordion:first-child .accordion-content').show();
			//}

			// Set Accordion Events
			$(this).children().children('.accordion-header').click(function () {

				if (!$(this).parent().hasClass('accordion-active')) {

					// Close other accordions
					if (!$(this).parent().parent().hasClass('toggles')) {
						//$(this).parent().parent().find('.accordion-active').removeClass('accordion-active').find('.accordion-content').slideUp(300);
						$(this).parent().siblings('.accordion-active').children('.accordion-content').slideUp(300);
						$(this).parent().siblings('.accordion-active').removeClass('accordion-active');

					}

					// Open Accordion
					$(this).parent().addClass('accordion-active');
					$(this).siblings('.accordion-content').slideDown(300);
					//$(this).parent().find('.accordion-content').slideDown(300);

				} else {

					// Close Accordion
					$(this).parent().removeClass('accordion-active');
					$(this).siblings('.accordion-content').slideUp(300);
					//$(this).parent().find('.accordion-content').slideUp(300);

				}

			});

		});



		/* Link Toggles */
		$('.toggle-link').each(function () {

			var target = $(this).attr('href');
			$(target).hide();

			$(this).click(function (e) {

				e.preventDefault();

				var target = $(this).attr('href');
				$(target).slideToggle(300);

			});

		});



		/* Payment Options Accordion */
		$('.payment-options').each(function () {

			$(this).find('.payment-content').hide();
			$(this).find('input[type="radio"]:checked').parent().parent().addClass('active').find('.payment-content').show();

			$(this).find('.payment-header').click(function () {

				if ($(this).find('input[type="radio"]').is(':checked')) {

					$(this).parent().parent().find('.payment-content').slideUp(300);
					$(this).parent().parent().find('li.active').removeClass('active');
					$(this).parent().addClass('active').find('.payment-content').slideDown(300);

				}

			});

		});


	}


}
