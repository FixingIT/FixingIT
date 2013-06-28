/// <reference path="../jquery-2.0.0.min.js" />
/// <reference path="../jquery-ui-1.10.3.js" />
/// <reference path="../jquery.validate.min.js" />
/// <reference path="../bootstrap.min.js" />
/// <reference path="../../Views/Shared/_Layout.cshtml" />
/// <reference path="UIModel.js" />
/// <reference path="MainModalModel.js" />
/// <reference path="AccountModel.js" />
/*global UIModelScript:true*/
/*global mainModalScript:true*/
/*global accountModelScript:true*/

$(document).ready(function () {
    "use strict";
    var accountScript = accountModelScript();
    var UI = UIModelScript();
    //UI.containerDIVOpen = false;
    //UI.toggleReferencesPage();

    $('<div id="backgroundCarouselBackdrop" class="modal-backdrop"></div>').appendTo('#backgroundCarousel');

    $('#backgroundCarousel').carousel({
        pause: false,
        interval: 7000
    });

    $('html').click(function (event) {
        UI.toggleReferencesPage();
    });
    $('#backgroundCarousel íframe').click(function (event) {
        UI.toggleReferencesPage();
    });

    //$('.referencesBtn').click(function (event) {
    //    UI.toggleReferencesPage();
    //});

    $('html#index #contentContainer').not('.referencesBtn').click(function (event) {
        //console.log($(this).hasClass('referencesBtn'));

        //if ($(this).find('.referencesBtn'))
        //    UI.containerDIVOpen = true;
        //else
            UI.containerDIVOpen = true;

        UI.toggleReferencesPage();
    });

    $('#MainModal').bind('hide', function () {
        UI.containerDIVOpen = true;
        UI.toggleReferencesPage();
    });

    //$(".term").autocomplete({
    //    source: function (request, response) {
    //        $.ajax({
    //            url: "/UserLink/AutoComplete",
    //            type: "GET",
    //            //cache: false,
    //            data: request,
    //            dataType: "json",
    //            success: function (data) {
    //                // call autocomplete callback method with results
    //                response($.map(data, function (item) {
    //                    console.log(item);
    //                    return {
    //                        label: item,
    //                        value: item
    //                    };
    //                }));
    //            },
    //            error: function (xmlHttpRequest, textStatus, errorThrown) {
    //                console.log('error', textStatus, errorThrown);
    //                mainModalScript().ErrorMsg('Error! Status: ' + textStatus + ' ErrorThrown: ' + errorThrown);
    //            }
    //        });
    //    },
    //    messages: {
    //        noResults: '',
    //        results: function () { }
    //    },
    //    minLength: 1,
    //    select: function (event, ui) {
    //        $(this).val(ui.item.value);
    //        console.log(ui.item.value);
    //        $.ajax({
    //            url: "/UserLink/AutoCompletePost/",
    //            type: "POST",
    //            //cache: false,
    //            data: { userLinkName: ui.item.value },
    //            dataType: "json",
    //            success: function (data) {
    //                window.location.href = data.redirectTo;
    //            },
    //            error: function (xmlHttpRequest, textStatus, errorThrown) {
    //                console.log(ui.item.value);
    //                console.log('error', textStatus, errorThrown);
    //                mainModalScript().ErrorMsg('Error! Status: ' + textStatus + ' ErrorThrown: ' + errorThrown);
    //            }
    //        });
    //    },
    //    open: function () {
    //        $('.ui-corner-all').removeClass('ui-corner-all');
    //        $('.ui-menu').attr('role', 'listbox');
    //        $('.ui-menu').addClass('dropdown-menu');
    //        $('.ui-menu-item').attr('role', 'menu-item');
    //        $('.ui-menu-item').addClass('btn-small');
    //    },
    //    close: function () {
    //        console.log('Autocomplete closed!');
    //    }
    //});

    //$('.searchBtn').click(function (event) {
    //    $(this).closest("form").submit();
    //});

    //$('#changeUserThemeCarousel').carousel('pause');

    //$('.changeUserThemeCarouselImage').click(function () {
    //    var ThemeName = $(this).data("themename");
    //    console.log(ThemeName);
    //    $.ajax({
    //        url: "/UserTheme/SetUserTheme/",
    //        type: "POST",
    //        //cache: false,
    //        data: { ThemeName: ThemeName },
    //        dataType: "json",
    //        success: function (data) {
    //            location.reload();
    //        },
    //        error: function (xmlHttpRequest, textStatus, errorThrown) {
    //            console.log('error', textStatus, errorThrown);
    //            mainModalScript().ErrorMsg('Error! Status: ' + textStatus + ' ErrorThrown: ' + errorThrown);
    //        }
    //    });
    //});

    //$('#WebBoxLoginRegisterTypeBtn').click(function (event) {
    //});
    //$('.externalLoginBtn').click(function (event) {
    //    $(this).closest("form").submit();

    //    //event.preventDefault();
    //    //var provider = $(this).parent().data('providername');
    //    //var displayName = $(this).parent().data('displayname');
    //    //var returnUrl = $(this).parent().data('returnurl');

    //    //console.log("provider: " + provider + "displayName: " + displayName + "returnUrl: " + returnUrl);

    //    //accountScript.externalLogin(provider, displayName, returnUrl);
    //});
});