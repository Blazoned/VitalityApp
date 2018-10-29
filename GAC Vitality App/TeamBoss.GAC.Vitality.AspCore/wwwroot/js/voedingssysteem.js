$(document).ready(function () {
    changeWidth();
    window.onresize = function () { changeWidth() };
});

function changeWidth() {
    var challengeWrapper = $(".navbar-food");
    var rowWidth = $(".row").width();

    challengeWrapper.css("width", rowWidth);
}