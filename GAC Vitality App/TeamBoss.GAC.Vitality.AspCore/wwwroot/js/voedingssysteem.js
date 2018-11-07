var eggCounter = 0;
var audioElement;

/* Memes */
$(document).ready(function () {
    changeWidth();
    window.onresize = function () { changeWidth(); };

    // Filters
    $("#food-search-filters-btn").click(function () {
        $("#food-search-filters-div").slideToggle(500);
    });

    // Eggs
    $("#food-search-filters-div").click(function () {
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
                    $("#food-search-filters-div").click(function () {
                        if (eggCounter < 12)
                            eggCounter++;

                        if (eggCounter === 12) {
                            audioElement.play();
                        }
                    });
                }
            });
        }
    });
});

/* Changes the width of the '.navbar-food' object based on the width of the row */
/* NOT IDEAL! NEEDS CHANGING! */
function changeWidth() {
    var challengeWrapper = $(".navbar-food");
    var rowWidth = $(".row").width();

    challengeWrapper.css("width", rowWidth);
}

/* Handles the switch between an object becoming 'visible' and/or 'hidden' */
$(".favourite-btn").click(function () {
    var btnVisible = $(".visible");
    var btnHidden = $(".hidden");

    btnVisible.removeClass("visible");
    btnVisible.addClass("hidden");

    btnHidden.removeClass("hidden");
    btnHidden.addClass("visible");
});

/* For selecting image files */
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

/* MODAL RELATED FUNCTIONS */
// When the user clicks anywhere in the html document it checks if it hit the modal and if not it closes the modal
$(document).click(function (event) {
    if (event.target.classList.contains("pop-up-modal")) {
        $(".pop-up-modal").css("display", "none");
    }
});

// When the user clicks the button, open the modal 
$(".modal-button").click(function () {
    $(".pop-up-modal").css("display", "block");
});

// When the user clicks on <span> (x), close the modal
$(".close").click(function () {
    $(".pop-up-modal").css("display", "none");
});
/* MODAL RELATED FUNCTIONS */