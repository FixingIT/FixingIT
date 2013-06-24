/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

var mainModalScript = (function () {
    return {
        setModal: function (title, url, footerurl, reload, error) {
            $('#MainModalContent').empty();
            $('#MainModalContent').hide();
            $('#MainModalFooter').empty();
            $('#MainModalFooter').hide();
            $('.MainModalLabel').empty();
            $('.MainModalLabel').text("<h1>" + title + "</h1>");

            $('#MainModal').modal('show');
            $('#circleG').show(300);

            if (undefined !== footerurl) {
                var getFooter = $.get(footerurl, function (data) {
                    $('#MainModalFooter').html(data);
                    $('#MainModalFooter').show(300);
                });
            }
            var getContent = $.get(url, function (data) {
                $('#MainModalContent').html(data);
                if (undefined !== error) {
                    $('#ErrorMsgText').text(error);
                }
                $('#circleG').hide(300);
                $('#MainModalContent').show(300);
            });

            if (reload === true) {
                console.log('reload');
                $('#my-modal').bind('hide', function () {
                    window.location.reload(true);
                });
            }
        },
        ErrorMsg: function (msg) {
            var url = "/Home/ErrorMessage/";
            var title = "Error";

            mainModalScript().setModal(title, url, undefined, false, msg);
        }
    };
});