/****************************************
 ************CHALLENGE*AGENDA************
 ****************************************/

// The object container for the view model and api controller related data.
var objects =
{
    public:
        [
            {
                id: 1,
                private: true,
                title: "45x Opdrukken",
                description: "We gaan lekker 45x opdrukken. Het maakt niet uit hoeveel sets je er over doet als je het maar 45x doet.",
                datum: new Date(),
                location: "Laan Ten Rode 5, Eindhoven",
                goals:
                    [
                        {
                            goal: "Opdrukken",
                            amount: 45,
                            measurement: "x"
                        }
                    ],
                tags:
                    [
                        "Opdrukken",
                        "Fitness"
                    ]
            },
            {
                id: 2,
                private: false,
                title: "1KM Hardlopen",
                description: "Iedere maandag is jog dag. Doe je ook mee?",
                datum: new Date(),
                location: "Europaweg 45a, Veldhoven",
                goals:
                    [
                        {
                            goal: "Opdrukken",
                            amount: 1000,
                            measurement: "m"
                        }
                    ],
                tags:
                    [
                        "Hardlopen",
                        "Rennen",
                        "Fitness"
                    ]
            },
            {
                id: 3,
                private: false,
                title: "Baantjes Zwemmen",
                description: "Ga je ook mee zwemmen? Tijd om even de beentjes te strekken en 80 baantjes door te halen.",
                datum: new Date(),
                location: "Antoon Coolenlaan 1, Eindhoven",
                goals:
                    [
                        {
                            goal: "Baantjes",
                            amount: 80,
                            measurement: ""
                        }
                    ],
                tags:
                    [
                        "Zwemmen",
                        "Baantjes",
                        "Water"
                    ]
            }
        ],
    personal:
        [
            {
                id: 3,
                private: false,
                title: "Baantjes Zwemmen",
                description: "Ga je ook mee zwemmen? Tijd om even de beentjes te strekken en 80 baantjes door te halen.",
                datum: new Date(),
                location: "Antoon Coolenlaan 1, Eindhoven",
                goals:
                    [
                        {
                            goal: "Baantjes",
                            amount: 80,
                            measurement: ""
                        }
                    ],
                tags:
                    [
                        "Zwemmen",
                        "Baantjes",
                        "Water"
                    ]
            }
        ]
};

$(document).ready(function () {
    // Date Time
    $("#challenge-agenda-listing-date").val(new Date(Date.now() - timeOffset).toISOString().slice(0, -14));
    let initTimer = setInterval(function () {
        if (new Date().getSeconds() === 0) {
            UpdateTime();
            setInterval(UpdateTime, 60000);
            clearInterval(initTimer);
        }
    }, 1000);

    // Swap challenge agenda tabs on click
    $("#challenge-agenda-privacy-selector").change(function () {
        switch ($(this).find(":selected").val()) {
            case "public":
                LoadAgenda(objects.public);
                break;
            case "personal":
                LoadAgenda(objects.personal);
                break;
        }
    });

    // Load default agenda
    LoadAgenda(objects.personal);
});

// Load Agenda
function LoadAgenda(agenda) {
    $("#challenge-listing").empty();
    $.each(agenda,
        function (index, value) {
            $("#challenge-listing").append("<a href='#' class='list-group-item' data-id='" + value.id + "'>" + value.title + "</a>");
        });

    $('#challenge-listing a').click(LoadAgendaItem);
}

// Load Agenda Item (On-Click Function)
function LoadAgendaItem(e) {
    e.preventDefault();

    let objId = $(this).data("id");

    // Don't invoke on the agenda details object
    if (objId === -1)
        return;

    // Get current object
    SlideRemoveDOMObject($(this).parent().find('a #challenge-agenda-item-details'));

    // Get object list
    let objectPool;

    switch ($("#challenge-agenda-privacy-selector").find(":selected").val()) {
        case "public":
            objectPool = objects.public;
            break;
        case "personal":
            objectPool = objects.personal;
            break;
        default:
            objectPool = null;
            break;
    }

    // Load correct object
    let obj;

    for (let i = 0; i < objectPool.length; i++) {
        if (objectPool[i].id === objId) {
            obj = objectPool[i];
        }
    }

    // Slide open a new agenda details item
    $(this).after(
        '<a href="#" class="list-group-item" data-id="-1" id="challenge-agenda-item-details-wrapper" hidden>' +
            '<div class="container text-wrapper">' +
                '<h1 id="challenge-challenge-title">' + obj.title + '</h1>' +
                '<p id="challenge-challenge-description">' +
                    obj.description +
                '</p>' +
            '</div>' +
                
            '<div class="container text-wrapper3">' +
                '<h4><b>Locatie</b></h4>' +
                '<p id="challenge-challenge-location">' +
                    obj.location +
                '</p>' +
            '</div>' +
                
            '<div class="container centerbutton">' +
                '<div class="input-group progressinput">' +
                    '<input class="form-control" type="text" placeholder="Geef aantal km" />' +
                    '<span class="input-group-btn">' +
                        '<button class="btn btn-group">' +
                            '<span class="glyphicon glyphicon-plus"></span>' +
                        '</button>' +
                    '</span>' +
                '</div>' +
                    
                '<div class="progress" style="height: 30px;">' +
                    '<div class="progress-bar" style="width: 40%; background-color: #3fc661; line-height: 240%;" aria-valuenow="4" aria-valuemin="0" aria-valuemax="10">4 km</div>' +
                    '<div class="progress-bar" style="width: 60%; background-color: #e9ecef; line-height: 240%; color: black" aria-valuenow="6" aria-valuemin="0" aria-valuemax="10">6 km</div>' +
                '</div>' +
                    
                '<div class="btn-group btnspecial">' +
                    '<a class="btn btn-info" role="button">Aanpassen</a>' +
                    '<a class="btn btn-info" role="button" asp-controller="movement" asp-action="invite" asp-area="">Uitdagen</a>' +
                    '<a class="btn btn-info" role="button">Verwijderen</a>' +
                '</div>' +
            '</div>' +
        '</a >');

    $("#challenge-agenda-item-details-wrapper").slideDown(1000);
}

// Authorisation Functions
// TODO: Implement owner check
function IsOwner(challengeId) {
    return true;
}

/****************************************
 ************CREATE*CHALLENGE************
 ****************************************/

// Document variables
var challengeGoalId = 0;
var timeOffset = new Date().getTimezoneOffset() * 60000;

/*
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
});*/

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
    if ($("#challenge-goals-list").children().length <= 2)
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