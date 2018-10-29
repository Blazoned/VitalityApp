$(document).ready(function () {
    changeWidth();
    window.onresize = function () { changeWidth() };
});

function changeWidth() {
    var challengeWrapper = $(".navbar-food");
    var rowWidth = $(".row").width();

    challengeWrapper.css("width", rowWidth);
}

$(".favourite-btn").click(function () {
    var btnVisible = $(".visible");
    var btnHidden = $(".invisible");

    btnVisible.removeClass("visible");
    btnVisible.addClass("invisible");

    btnHidden.removeClass("invisible");
    btnHidden.addClass("visible");
});

// For selecting image files
$(function () {
    // We can attach the `fileselect` event to all file inputs on the page
    $(document).on('change', ':file', function () {
        var input = $(this), numFiles = input.get(0).files ? input.get(0).files.length : 1;
        input.trigger('fileselect', [numFiles]);
    });

    // We can watch for our custom `fileselect` event like this
    $(document).ready(function () {
        $(':file').on('fileselect', function (event, numFiles) {
            var input = $(this).parents('.input-group').find(':text');
            var log = numFiles > 1 ? numFiles + ' files selected' : numFiles + ' file selected';

            if (input.length) {
                input.val(log);
            } else {
                if (log) alert(log);
            }

        });
    });

});