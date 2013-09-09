/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />
/// <reference path="MainModalModel.js" />
/*global MainModalScript:true*/

$(document).ready(function () {
    "use strict";
    var mainModal = new MainModalScript();

    $('.mainModalBtn').click(function (event) {
        event.preventDefault();
        var url = $(this).data('modal-url');
        var footerurl = $(this).data('modal-footerurl');
        var title = $(this).data('modal-title');
        var reload = false;
        if ($(this).data('modal-reloadPageOnClose') === true)
            reload = true;

        mainModal.setModal(title, url, footerurl, reload);
    });
});