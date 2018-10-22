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
    var faIconObj = $(this).find(".fa-settings");
    if (buttonObj.data("public-listing")) { // The button is set to true, so make it false
        buttonObj.removeClass("btn-success");
        faIconObj.removeClass("fa-check");
        buttonObj.addClass("btn-danger");
        faIconObj.addClass("fa-times");
        buttonObj.data("public-listing", false);
    }
    else { // The button is set to false, so make it true
        buttonObj.removeClass("btn-danger");
        faIconObj.removeClass("fa-times");
        buttonObj.addClass("btn-success");
        faIconObj.addClass("fa-check");
        buttonObj.data("public-listing", true);
    }
});

$(document).ready(function () {
    var progressBarArray = $(".progress-bar");

    for (var i = 0, l = progressBarArray.length; i < l; i++) { // Run through all the progress bars and check if they are full
        var actualProgressBar = $(progressBarArray[i]);
        var progressBarWidth = parseInt(actualProgressBar.css("width"), 10);
        var parentWidth = parseInt(actualProgressBar.parent().css("width"), 10);

        if (progressBarWidth >= parentWidth) { // If a progress bar is full, make its background green
            actualProgressBar.css("background-color", "green");
        }
    }
});