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
            $("#challenge-listing").append("<a href='#' class='list-group-item' data-id='" + value.id + "'>" + value.title + "</a>");
        });
});


$(function () {
    $('.list-group a').click(function(e) {
        e.preventDefault();
        $that = $(this);
        $that.parent().find('a').removeClass('active');
        $that.addClass('active');

        // the code you're looking for
        var singleObject = $(this).data("id");

        // iterate over each element in the array
        for (var i = 0; i < objects.length; i++) {
            // look for the entry with a matching `code` value
            if (objects[i].id === singleObject) {
                $("#Challenge-Description").text(objects[i].description);
                $("#Challenge-Location").text(objects[i].location); 
            }
        }

        $("#Challenge-Title").text($('.list-group a.active').text());
       
    });
});
