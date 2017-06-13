(function (Application, $, undefined) {
    'use strict';
    Application.culture = 'de-CH';
    Application.init = function () {
        Globalize.culture(this.culture);

        $.validator.methods.number = function (value, element) {
            return this.optional(element) || jQuery.isNumeric(Globalize.parseFloat(value));
        };

        $.validator.methods.date = function (value, element) {
            return (this.optional(element) || Globalize.parseDate(value));
        };

        jQuery.extend(jQuery.validator.methods, {
            range: function (value, element, param) {
                var val = Globalize.parseFloat(value);
                return this.optional(element) || (val >= param[0] && val <= param[1]);
            }
        });
    };

}(window.Application = window.Application || {}, jQuery));