var privacyBtnSuccess;
var privacyBtnDanger;
var privacyBtnSuccessHidden = false;

$(document).ready(function () {
    privacyBtnSuccess = $(".privacy-button-success");
    privacyBtnDanger = $(".privacy-button-danger");
});

$(".privacy-button").click(function () {
    privacyBtnSuccessHidden = !privacyBtnSuccessHidden;

    if (privacyBtnSuccessHidden) {
        $(privacyBtnSuccess).addClass("hidden");
        $(privacyBtnDanger).removeClass("hidden");
    }
    else {
        $(privacyBtnDanger).addClass("hidden");
        $(privacyBtnSuccess).removeClass("hidden");
    }
});

$(".datetime-input").focusout(function () {
    var localTime = Date.now();
    var enteredTime = new Date($(".datetime-input").val());

    if (enteredTime <= localTime) {
        $(".datetime-input").val(null);
    }
});

$(".challenge-tag-button").click(function () {
    var tagValue = $(".challenge-tag-input").val();
    if (tagValue != "") {
        tagValue = tagValue.toLowerCase();

        $(".tag-list").append(
            '<li>' +
            '<span>' + tagValue + '   </span>' +
            '<span class="challenge-remove-tag fa fa-remove"></span>' +
            '</li>'
        );

        $(".challenge-remove-tag").click(RemoveTag);
    }

    $(".challenge-tag-input").val(null);
});

// Remove Tags
function RemoveTag() {
    FadeRemoveDOMObject($(this).parent());
}

mapboxgl.accessToken = 'pk.eyJ1IjoibWFydGlqbnZkYmVyayIsImEiOiJjanFtNDVyMncwZzE4NDNwNWdwZjZsZnJiIn0.IeOqaC2wLM5ISerMun5hXg';
var map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/streets-v9',
    center: [0, 0],
    zoom: 0
});

var geocoder = new MapboxGeocoder({
    accessToken: mapboxgl.accessToken
});

map.addControl(geocoder);

map.on('load', function () {
    OnMapLoad();
});

function OnMapLoad() {
    map.addSource('single-point', {
        "type": "geojson",
        "data": {
            "type": "FeatureCollection",
            "features": []
        }
    });

    map.addLayer({
        "id": "point",
        "source": "single-point",
        "type": "circle",
        "paint": {
            "circle-radius": 10,
            "circle-color": "#007cbf"
        }
    });

    geocoder.on('result', function (ev) {
        map.getSource('single-point').setData(ev.result.geometry);
    });
}