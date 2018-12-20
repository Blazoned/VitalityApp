var privacyBtnSuccess;
var privacyBtnDanger;
var privacyBtnSuccessHidden = false;

$(document).ready(function () {
    privacyBtnSuccess = $(".privacy-button-success");
    privacyBtnDanger = $(".privacy-button-danger");
});

$(".privacy-button").click(function () {
    privacyBtnSuccessHidden = !privacyBtnSuccessHidden;

    if (privacyBtnSuccessHidden) {
        $(privacyBtnSuccess).addClass("hidden");
        $(privacyBtnDanger).removeClass("hidden");
    }
    else {
        $(privacyBtnDanger).addClass("hidden");
        $(privacyBtnSuccess).removeClass("hidden");
    }
});

$(".datetime-input").focusout(function () {
    var localTime = Date.now();
    var enteredTime = new Date($(".datetime-input").val());

    if (enteredTime <= localTime) {
        $(".datetime-input").val(null);
    }
});

$(".challenge-tag-button").click(function () {
    var tagValue = $(".challenge-tag-input").val();
    if (tagValue != "") {
        tagValue = tagValue.toLowerCase();

        $(".tag-list").append(
            '<li>' +
            '<span>' + tagValue + '   </span>' +
            '<span class="challenge-remove-tag fa fa-remove"></span>' +
            '</li>'
        );

        $(".challenge-remove-tag").click(RemoveTag);
    }

    $(".challenge-tag-input").val(null);
});

// Remove Tags
function RemoveTag() {
    FadeRemoveDOMObject($(this).parent());
}