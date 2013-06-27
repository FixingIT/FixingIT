/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

console.log("UI");

var UIModelScript = (function () {
    return {
        containerDIVOpen: true,

        toggleReferencesPage: function (hide) {
            "use strict";

            //if (hide)
            //    this.containerDIVOpen = true;

            if (this.containerDIVOpen === true) {
                this.containerDIVOpen = false;
                //$('#contentContainer').toggleClass("containerDIVOpen");

                $('#contentContainer').stop(true).show().fadeOut(800, function () {
                    //$('html#index .container').css("display","none");
                });
            }
            else {
                this.containerDIVOpen = true;
                //$('#contentContainer').toggleClass("containerDIVOpen");

                //$('html#index .container').css("display","none");
                $('#contentContainer').stop(true).hide().fadeIn(800);
            }

        }
    };
});