/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

console.log("UI");

var UIModelScript = (function () {
    return {
        openReferencesPage: function () {
            "use strict";

            $('body#index .container').animate({
                opacity: 0.0
            }, 800, function () {
                $('body#index .container').css("display", "none");
            });

        },
        closeReferencesPage: function (provider, displayName, returnUrl) {
            "use strict";

            $('body#index .container').animate({
                opacity: 1.0
            }, 800);
        }
    };
});