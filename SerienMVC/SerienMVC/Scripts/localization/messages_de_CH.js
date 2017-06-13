(function( factory ) {
	if ( typeof define === "function" && define.amd ) {
		define( ["jquery", "../jquery.validate"], factory );
	} else {
		factory( jQuery );
	}
}(function( $ ) {

/*
 * Translated default messages for the jQuery validation plugin.
 * Locale: DE (German, Deutsch)
 */
$.extend($.validator.messages, {
    required: "Dieses Feld ist ein Pflichtfeld.",
    remote: "Bitte diese Feld ausf�llen.",
    email: "Geben Sie bitte eine g�ltige E-Mail Adresse ein.",
    url: "Geben Sie bitte eine g�ltige URL ein.",
    date: "Bitte geben Sie ein g�ltiges Datum ein.",
    dateISO: "Bitte ein g�ltiges ISO-Datum eingeben.",
    number: "Geben Sie bitte eine Nummer ein.",
    digits: "Geben Sie bitte nur Ziffern ein.",
    creditcard: "Geben Sie bitte eine g�ltige Kreditkarten-Nummer ein.",
    equalTo: "Bitte denselben Wert wiederholen.",
    extension: "Bitte ein Wert mit g�ltiger (Datei)-Endung angeben",
    maxlength: $.validator.format("Geben Sie bitte maximal {0} Zeichen ein."),
    minlength: $.validator.format("Geben Sie bitte mindestens {0} Zeichen ein."),
    rangelength: $.validator.format("Geben Sie bitte mindestens {0} und maximal {1} Zeichen ein."),
    range: $.validator.format("Geben Sie bitte einen Wert zwischen {0} und {1} ein."),
    max: $.validator.format("Geben Sie bitte einen Wert kleiner oder gleich {0} ein."),
    min: $.validator.format("Geben Sie bitte einen Wert gr��er oder gleich {0} ein."),
    nifES: "Bitte ein g�ltiges NIF angeben.",
    nieES: "Bitte ein g�ltiges NIE angeben.",
    cifES: "Bitte ein g�ltiges CIF angeben."
});

}));