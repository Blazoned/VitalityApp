var objects =
    [
        {
            id: 1,
            private: true,
            title: "45x Opdrukken",
            description: "Bij deze challenge gaan de gebruikers 45x opdrukken. Het maakt niet uit hoeveel sets je er over doet als je het maar 45x doet.",
            location: "Laan Ten Rode 5, Eindhoven"
        },
        {
            id: 2,
            private: false,
            title: "1KM Hardlopen",
            description: "Bij deze challenge gaat de gebruiker 1km joggen. Er is geen tijd verbonden aan deze challenge.",
            location: "Europaweg 45a, Veldhoven"
        }
    ];




$(function () {
    $.each(objects,
        function(index, value) {
            $("#challenge-listing").append("<a href='#' class='list-group-item' data-id='" + value.id + "' data-title = '" + value.title + "' + data-description='" + value.description + "' + data-location='" + value.location + "'>" + value.title + "</a>");
        });
});


$(function () {
    $('.list-group a').click(function(e) {
        e.preventDefault();
        $that = $(this);
        $that.parent().find('a').removeClass('active');
        $that.addClass('active');

        $("#Challenge-Title").text($('.list-group a.active').text());
        $("#Challenge-Description").text($(this).data("description"));
        $("#Challenge-Location").text($(this).data("location"));
    });
});
