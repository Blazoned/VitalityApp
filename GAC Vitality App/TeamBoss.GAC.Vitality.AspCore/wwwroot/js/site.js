$(document).ready(function () {
    // Show tooltips
    $('[data-toggle="tooltip"]').tooltip();
});

// Remove DOM Object with a fading animation
function FadeRemoveDOMObject(domObj) {
    domObj.fadeOut(250);
    setTimeout(function () {
        domObj.remove();
    }, 300);
}

// Remove DOM Object with a sliding animation
function SlideRemoveDOMObject(domObj) {
    domObj.slideUp(250);
    setTimeout(function () {
        domObj.remove();
    }, 300);
}