$(document).ready(function () {
    $(".mapboxgl-control-container").attr("hidden", true);
});

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
    var mapLocation = $(".map-location").text();
    geocoder.query(mapLocation, showMap);
    //geocoder.reverseQuery('Rachelsmolen 1, 5612 Eindhoven, Netherlands', reverseQuery)
    onMapLoad();
});

/*unction reverseQuery(err, data) {
    map.flyTo({
        center: data,
        zoom: 0,
        bearing: 0
    });
}*/

function showMap(err, data) {
    if (data.lbounds) {
        map.fitBounds(data.lbounds);
    } else if (data.latlng) {
        map.setView([data.latlng[0], data.latlng[1]], 0);
    }

    /*map.flyTo({
        center: [data.latlng[0], data.latlng[1]],
        zoom: 0,
        bearing: 0
    });*/
}

function onMapLoad() {
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