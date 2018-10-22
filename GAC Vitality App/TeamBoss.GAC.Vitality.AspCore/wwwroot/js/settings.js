/*$("#challenge-listing-area").click(function () {
    var buttonObj = $("#challenge-listing-input");

    // Check listing
    if (buttonObj.data("public-listing")) {
        // Set unlisted
        buttonObj.removeClass("btn-success");
        buttonObj.addClass("btn-danger");
        buttonObj.data("public-listing", false);
        $("#challenge-listing-button-content").slideToggle(250, function () {
            $(this).text("Verborgen").slideToggle(250);
        });
    }
    else {
        // Set listed
        buttonObj.removeClass("btn-danger");
        buttonObj.addClass("btn-success");
        buttonObj.data("public-listing", true);
        $("#challenge-listing-button-content").slideToggle(250, function () {
            $(this).text("Publiek").slideToggle(250);
        });
    }
});*/

$(".form-control-settings").click(function () {
    var buttonObj = $(this);
    if (buttonObj.data("public-listing")) {
        buttonObj.removeClass("btn-success");
        buttonObj.addClass("btn-danger");
        buttonObj.data("public-listing", false);
    }
    else {
        buttonObj.removeClass("btn-danger");
        buttonObj.addClass("btn-success");
        buttonObj.data("public-listing", true);
    }
});

$(document).ready(function () {
    var progressBarArray = $(".progress-bar");

    for (var i = 0, l = progressBarArray.length; i < l; i++) {
        var actualProgressBar = $(progressBarArray[i]);
        var progressBarWidth = parseInt(actualProgressBar.css("width"), 10);
        var parentWidth = parseInt(actualProgressBar.parent().css("width"), 10);

        if (progressBarWidth >= parentWidth) {
            actualProgressBar.css("background-color", "green");
        }
    }
});