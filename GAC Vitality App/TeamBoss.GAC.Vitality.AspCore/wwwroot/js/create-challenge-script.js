var challengeGoalId = 0;
var timeOffset = new Date().getTimezoneOffset() * 60000;

$(document).ready(function () {
    // Goals
    $("#challenge-goals-button-add").click(AddGoal);
    $(".challenge-goal-button-remove").click(RemoveGoal);

    // Location
    $("#challenge-location-input").geocomplete();

    // Date Time
    $("#challenge-date-time-input").val(new Date(Date.now() - timeOffset).toISOString().slice(0, -8));
    let initTimer = setInterval(function () {
        if (new Date().getSeconds() === 0) {
            UpdateTime();
            setInterval(UpdateTime, 60000);
            clearInterval(initTimer);
        }
    }, 1000);

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
        let lastGoalIsEmpty = IsGoalEmpty(challengeGoalId);

        if (!lastGoalIsEmpty) {
            challengeGoalId++;

            $("#challenge-goals-list").append(
                '<li class="list-group-item list-group-item-text list-group-item-lose challenge-goal-group-item row" id="challenge-goal-' + challengeGoalId + '">' +
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

            $(".challenge-goal-button-remove").click(RemoveGoal);
        }

        // TODO: Implement challenge flash
        let flashTime = 1000;

        let flashInterval = setInterval(function () {
            $("#challenge-goal-" + challengeGoalId).children().first().toggleClass("border-flash");
        }, flashTime / 4);

        setTimeout(function () {
            clearInterval(flashInterval);
        }, flashTime);
    }
}

// Remove Goal
function RemoveGoal() {
    if ($("#challenge-goals-list").children().length <= 1)
        return;

    let htmlObj = $(this).closest("li");

    // If you remove the last item, the newest id needs to be set to one lower as for checking if the last item is empty.
    if (htmlObj.attr("id") === $("#challenge-goals-list").find("li").last().attr("id")) {
        challengeGoalId--;
    }

    SlideRemoveDOMObject($(this).closest("li"));
}

// Check if a goal is left empty
function IsGoalEmpty(index) {
    let empty = false;
    let listItem = $("#challenge-goal-" + index);

    empty |= !(listItem.find(".challenge-goal-type").val().trim().length > 0);
    empty |= !(listItem.find(".challenge-goal-amount").val() >= 0);

    // TODO: IMPLEMENT FUNCTION
    return empty;
}

// Update date time update field
function UpdateTime() {
    let localTime = new Date(Date.now() - timeOffset).toISOString().slice(0, -8);
    if ($("#challenge-date-time-input").val() < localTime)
        $("#challenge-date-time-input").val(localTime);
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