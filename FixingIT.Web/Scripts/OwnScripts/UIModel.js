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
                //$('#backgroundCarousel iframe').toggleClass("modal-backdrop");
                $("#backgroundCarouselBackdrop").remove();
                $('#backgroundCarousel').carousel('pause');
                //$('#backgroundCarousel').carousel({ pause: true, interval: false });

                $('#contentContainer').stop(true).show().fadeOut(800, function () {
                    //$('html#index .container').css("display","none");
                });
            }
            else {
                this.containerDIVOpen = true;
                //$('#backgroundCarousel iframe').toggleClass("modal-backdrop");
                $('<div id="backgroundCarouselBackdrop" class="modal-backdrop"></div>').appendTo('#backgroundCarousel');
                $('#backgroundCarousel').carousel('cycle');
                //$('#backgroundCarousel').carousel({ pause: false, interval: 7000 });

                //$('html#index .container').css("display","none");
                $('#contentContainer').stop(true).hide().fadeIn(800);
            }

        }
    };
});