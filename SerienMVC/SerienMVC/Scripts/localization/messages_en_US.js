(function( factory ) {
	if ( typeof define === "function" && define.amd ) {
		define( ["jquery", "../jquery.validate"], factory );
	} else {
		factory( jQuery );
	}
}(function( $ ) {

/*
 * Translated default messages for the jQuery validation plugin.
 * Locale: ES (Spanish; Español)
 * Region: AR (Argentina)
 */
$.extend($.validator.messages, {
    required: "This field is required.",
    remote: "Please fix this field.",
    email: "Please enter a valid email address.",
    url: "Please enter a valid URL.",
    date: "Please enter a valid date.",
    dateISO: "Please enter a valid date (ISO).",
    number: "Please enter a valid number.",
    digits: "Please enter only digits.",
    creditcard: "Please enter a valid credit card number.",
    equalTo: "Please enter the same value again.",
    accept: "Please enter a value with a valid extension.",
	equalTo: "Por favor, escribí el mismo valor de nuevo.",
	extension: "Por favor, escribí un valor con una extensión aceptada.",
	maxlength: $.validator.format("Please enter no more than {0} characters."),
	minlength: $.validator.format("Please enter at least {0} characters.."),
	rangelength: $.validator.format("Please enter a value between {0} and {1} characters long."),
	range: $.validator.format("Please enter a value between {0} and {1}."),
	max: $.validator.format("Please enter a value less than or equal to {0}."),
	min: $.validator.format("Please enter a value greater than or equal to {0}."),
	nifES: "Por favor, escribí un NIF válido.",
	nieES: "Por favor, escribí un NIE válido.",
	cifES: "Por favor, escribí un CIF válido."
});

}));

