/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

var AccountModelScript = (function () {
    return {
        externalLogin: function (provider, displayName, returnUrl) {
            "use strict";

            console.log("provider: " + provider + "displayName: " + displayName + "returnUrl: " + returnUrl);
            return;

            //var errorMsg = true;
            //var newRating = 0;

            //var update = $.ajax({
            //    type: "POST",
            //    url: "/Rating/SetLinkRating",
            //    data: { id: id, value: voteValue },
            //    dataType: "json",
            //    async: false
            //});
            //// Success
            //update.done(function (result) {
            //    if (result.status !== 'Ok') {
            //        if (result.status === "Error") {
            //            console.log(result.status + ": " + result.message);
            //            errorMsg = result.message;
            //        }
            //    }
            //    else {
            //        newRating = result.newRating;
            //        parents.find('.ratingDiv').html('<strong>' + newRating + '</strong>');
            //        errorMsg = true;
            //    }
            //});
            //// Error
            //update.fail(function (jqXHR, textStatus) {
            //    console.log("Request failed: " + textStatus);
            //    errorMsg = "Request failed: " + textStatus;
            //});

            //if (newRating >= 1) {
            //    ratingColor.removeClass('minus')
            //                .addClass('plus');
            //}
            //else if (newRating <= -1) {
            //    ratingColor.removeClass('plus')
            //                .addClass('minus');
            //}
            //else {
            //    ratingColor.removeClass('plus')
            //                .removeClass('minus');
            //}

            //return errorMsg;
        }
    };
});