var map = L.map('map').setView([52.202194573669736, 19.45071399550726], 7);

var tiles = L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);

function addPin(cityName, color) {
    var geocodingAPI = 'https://nominatim.openstreetmap.org/search?format=json&limit=1&q=' + encodeURIComponent(cityName);

    fetch(geocodingAPI)
        .then(response => response.json())
        .then(data => {
            if (data && data.length > 0) {
                var latlng = [data[0].lat, data[0].lon];
                var marker = L.marker(latlng, {
                    icon: L.divIcon({
                        className: 'custom-pin',
                        html: '<span style="color: ' + color + '; font-size: 32px;">&#x1F4CD;</span>',
                        iconSize: [48, 48] 
                    })
                }).addTo(map);
                map.panTo(latlng);
            } else {
                alert('Nie można znaleść lokalizacji dla ' + cityName);
            }
        })
        .catch(error => console.error('Error:', error));
}

function findRoute() {
    var startCity = document.getElementById('startCity').value;
    var endCity = document.getElementById('endCity').value;

    if (startCity && endCity) {
        addPin(startCity, 'blue');
        addPin(endCity, 'red');

        geocodeCityAndUpdateRoute(startCity, endCity);
    } else {
        alert('Oba pola powinny być prawidłowo wypełnione');
    }
}

function geocodeCityAndUpdateRoute(startCity, endCity) {
    var startGeocodingAPI = 'https://nominatim.openstreetmap.org/search?format=json&limit=1&q=' + encodeURIComponent(startCity);
    var endGeocodingAPI = 'https://nominatim.openstreetmap.org/search?format=json&limit=1&q=' + encodeURIComponent(endCity);

    Promise.all([fetch(startGeocodingAPI), fetch(endGeocodingAPI)])
        .then(responses => Promise.all(responses.map(response => response.json())))
        .then(data => {
            var startLatLng = [data[0][0].lat, data[0][0].lon];
            var endLatLng = [data[1][0].lat, data[1][0].lon];

            L.Routing.control({
                waypoints: [
                    L.latLng(startLatLng),
                    L.latLng(endLatLng)
                ],
                routeWhileDragging: true,
                show: false 
            }).addTo(map);
        })
        .catch(error => console.error('Error:', error));
}
//function geocodeCityAndUpdateRoute(startCity, endCity) {
//    var startGeocodingAPI = 'https://nominatim.openstreetmap.org/search?format=json&limit=1&q=' + encodeURIComponent(startCity);
//    var endGeocodingAPI = 'https://nominatim.openstreetmap.org/search?format=json&limit=1&q=' + encodeURIComponent(endCity);

//    Promise.all([fetch(startGeocodingAPI), fetch(endGeocodingAPI)])
//        .then(responses => Promise.all(responses.map(response => response.json())))
//        .then(data => {
//            var startLatLng = [data[0][0].lat, data[0][0].lon];
//            var endLatLng = [data[1][0].lat, data[1][0].lon];

//            L.Routing.control({
//                waypoints: [
//                    L.latLng(startLatLng),
//                    L.latLng(endLatLng)
//                ],
//                routeWhileDragging: true
//            }).addTo(map);
//        })
//        .catch(error => console.error('Error:', error));
//}