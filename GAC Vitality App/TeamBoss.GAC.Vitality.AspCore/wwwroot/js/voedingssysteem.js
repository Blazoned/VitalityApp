var eggCounter = 0;
var audioElement;

$(document).ready(function () {
    changeWidth();
    window.onresize = function () { changeWidth(); };

    $("#food-search-text").keypress(function (e) { console.log(e.which) });

    // Eggs
    $("#food-search-allergies").click(function () {
        if (eggCounter < 3)
            eggCounter++;

        if (eggCounter === 3) {
            $("#food-search-text").keypress(function (e) {
                if (eggCounter === 3 && e.which === 109 || e.which === 77)
                    eggCounter++;

                if (eggCounter === 4 && e.which === 111 || e.which === 79)
                    eggCounter++;

                if (eggCounter === 5 && e.which === 110 || e.which === 78)
                    eggCounter++;

                if (eggCounter === 6 && e.which === 115 || e.which === 83)
                    eggCounter++;

                if (eggCounter === 7 && e.which === 116 || e.which === 84)
                    eggCounter++;

                if (eggCounter === 8 && e.which === 101 || e.which === 69)
                    eggCounter++;

                if (eggCounter === 9 && e.which === 114 || e.which === 82)
                    eggCounter++;


                if (eggCounter === 4) {
                    audioElement = document.createElement('audio');
                    audioElement.setAttribute('src', '/audio/eggSound.mp3');
                }

                if (eggCounter === 9) {
                    $("#food-search-allergies").click(function () {
                        if (eggCounter < 12)
                            eggCounter++;

                        if (eggCounter === 12) {
                            audioElement.play();
                            $("#food-search-allergies").off("click");
                        }
                    });
                }
            });
        }
    });
});

function changeWidth() {
    var challengeWrapper = $(".navbar-food");
    var rowWidth = $(".row").width();

    challengeWrapper.css("width", rowWidth);
}

$(".favourite-btn").click(function () {
    var btnVisible = $(".visible");
    var btnHidden = $(".hidden");

    btnVisible.removeClass("visible");
    btnVisible.addClass("hidden");

    btnHidden.removeClass("hidden");
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