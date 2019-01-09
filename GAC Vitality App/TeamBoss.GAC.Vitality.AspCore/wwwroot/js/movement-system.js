$(".select-privacy").on('change', function () {
    var selectPrivacy = $(".select-privacy");
    var option = $(selectPrivacy).find('option:selected').text();

    if (option == "Publiek") {
        $(".private-list").attr('hidden', true);
        $(".public-list").attr('hidden', false);
    } else if (option == "Privaat") {
        $(".public-list").attr('hidden', true);
        $(".private-list").attr('hidden', false);
    }
});