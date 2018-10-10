$(document).ready(function () {
    // Date Time
    var timeOffset = new Date().getTimezoneOffset() * 60000;
    var localTime = new Date(Date.now() - timeOffset).toISOString().slice(0, -8);
    $("#challenge-date-time-input").val(localTime);

    // Toggle Listing
    $("#challenge-listing-area").click(function () {
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
    });

    // Add Tags
    $("#challenge-tag-button").click(AddTag);
    $("#challenge-tag-input").keypress(function (e) {
        if (e.keyCode === 13) {
            AddTag();
        }
    });

    // Submit Challenge
    $("#challenge-submit-button").click(function () {
        window.location.href = "/movement";
    });
});

// Add Tags
function AddTag() {
    var label = $("#challenge-tag-input").val();

    // TODO: Validate label

    if (label !== "" && typeof (label) !== "undefined") {
        label = label.toLowerCase().replace(/^\w/, c => c.toUpperCase());

        $("#tag-list").append(
            '<li>' +
            '<span class="challenge-tag-label">' + label + '&nbsp;&nbsp;&ensp;</span>' +
            '<span class="challenge-remove-tag glyphicon glyphicon-remove"></span>' +
            '</li> '
        );

        $(".challenge-remove-tag").click(AddTagRemovalOnClick);
    }

    $("#challenge-tag-input").val(null);
}

// Remove Tags
function AddTagRemovalOnClick() {
    $(this).parent().fadeOut(250);
}