/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />

var mainModalScript = (function () {
    return {
        setModal: function (title, url, footerurl, reload, error) {
            $('#MainModalContent').empty();
            $('#MainModalContent').hide(0);
            $('#MainModalFooter').empty();
            $('#MainModalFooter').hide(0);
            $('.MainModalLabel').empty();
            $('.MainModalLabel').text(title);

            $('#MainModal').modal('show');

            $('#circleG').css("opacity",1.0);
            $('#circleG').show(0);

            if (undefined !== footerurl) {
                var getFooter = $.get(footerurl, function (data) {
                    $('#MainModalFooter').delay(1000);
                    $('#MainModalFooter').html(data);
                    $('#MainModalFooter').show(500);
                });
            }
            var getContent = $.get(url, function (data) {
                if (undefined !== error) {
                    $('#ErrorMsgText').text(error);
                }
                $('#MainModalContent').delay(1000);
                $('#MainModalContent').html(data);
                $('#circleG').delay(700);
                $('#circleG').animate({
                    opacity: 0.0
                }, 300);
                $('#circleG').hide(0);
                $('#MainModalContent').show(500);
            });

            if (reload === true) {
                console.log('reload');
                $('#MainModal').bind('hide', function () {
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