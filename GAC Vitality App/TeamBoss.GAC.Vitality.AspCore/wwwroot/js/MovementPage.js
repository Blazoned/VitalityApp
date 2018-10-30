var objects =
    [
        {
            private: true,
            title: "45x Opdrukken",
            description: "asdkhaskjbdhjksaukdasjkhdgsjhfjsgakudgjgskdgajgdkuga"
        },
        {
            private: false,
            title: "1km joggen",
            description: "asdkhaasdsadsafydgsyafdyuasydgyuasyfdskjbdhjksaukdasjkhdgsjhfjsgakudgjgskdgajgdkuga"
        }
    ];

$(function () {
    $.each(objects, function (index, value) {
        $("#challenge-listing").append("<a href='#' OnClick='DoAction('.value.index','value.title')' class='list-group-item'>" + value.title);       
    });
});


function DoAction(id, name) {
    $.ajax({
        type: "POST",
        url: "/Movement",
        data: "id=" + id + "&name=" + name,
        success: function (msg) {
            alert("Data Saved: " + msg);
        }
    });
}


$(function () {
    $('.list-group a').click(function(e) {
        e.preventDefault();
        $that = $(this);
        $that.parent().find('a').removeClass('active');
        $that.addClass('active'); 
        if ($(this).hasClass("active")) {
            $("#Challenge-Title").text(value.text);
        }
    });
});
