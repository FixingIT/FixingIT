/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

var accountModelScript = (function () {
    return {
        openReferencesPage: function () {
            "use strict";

            $('body#index .container').hide()
        },
        closeReferencesPage: function (provider, displayName, returnUrl) {
            "use strict";

            console.log("provider: " + provider + "displayName: " + displayName + "returnUrl: " + returnUrl);
            return;
        }
    };
});