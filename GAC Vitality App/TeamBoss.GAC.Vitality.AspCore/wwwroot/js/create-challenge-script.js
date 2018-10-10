var challengeGoalCount = 0;

$(document).ready(function () {
    // Add Goals
    $("#challenge-goals-button-add").click(AddGoal);

    // Date Time
    let timeOffset = new Date().getTimezoneOffset() * 60000;
    let localTime = new Date(Date.now() - timeOffset).toISOString().slice(0, -8);
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

// Add Goal
function AddGoal() {
    {
        let lastGoalIsEmpty = IsGoalEmpty(challengeGoalCount);

        if (lastGoalIsEmpty) {
            challengeGoalCount++;

            $("#challenge-goals-list").append(
                '<li class="list-group-item list-group-item-text list-group-item-lose challenge-goal-group-item" id="challenge-goal-' + challengeGoalCount + '">' +
                '<div class="input-group">' +
                '<input class="form-control challenge-goal-type" type="text" maxlength="40" placeholder="Doelstelling Soort" required />' +
                '<span class="input-group-btn input-group-empty"></span>' +
                '<input class="form-control challenge-goal-amount" type="number" min="0" value="0" style="margin-left:-1px" required />' +
                '<span class="input-group-btn input-group-empty"></span>' +
                '<input class="form-control challenge-goal-measurement" type="text" maxlength="20" placeholder="Meet Eenheid (niet vereist)" style="margin-left:-2px" />' +
                '<span class="input-group-btn">' +
                '<button class="btn btn-group challenge-goal-button-remove">' +
                '<span class="glyphicon glyphicon-remove"></span>' +
                '</button>' +
                '</span>' +
                '</div>' +
                '</li>'
            );
        }

        $(".challenge-goal-button-remove").click(RemoveGoal);
    }
}

// Remove Goal
function RemoveGoal() {
    SlideRemoveDOMObject($(this).closest("li"));
    challengeGoalCount--;
}

// Check if a goal is left empty
function IsGoalEmpty(index) {
    // TODO: IMPLEMENT FUNCTION
    return true;
}


// Add Tags
function AddTag() {
    let label = $("#challenge-tag-input").val();

    // TODO: Validate label

    if (label !== "" && typeof (label) !== "undefined") {
        label = label.toLowerCase().replace(/^\w/, c => c.toUpperCase());

        $("#tag-list").append(
            '<li>' +
            '<span class="challenge-tag-label">' + label + '&nbsp;&nbsp;&ensp;</span>' +
            '<span class="challenge-remove-tag glyphicon glyphicon-remove"></span>' +
            '</li> '
        );

        $(".challenge-remove-tag").click(RemoveTag);
    }

    $("#challenge-tag-input").val(null);
}

// Remove Tags
function RemoveTag() {
    FadeRemoveDOMObject($(this).parent());
}