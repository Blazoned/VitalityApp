$(document).ready(function () {
    $('#focus').ready(function () {
        var isSelected = false;
        $(this).click(function () {
            isSelected = !isSelected;
            if (isSelected) {
                $(this).css('background-color', 'red');
            }
            else {
                $(this).css('background-color', 'green');
            }
        });
    });
});