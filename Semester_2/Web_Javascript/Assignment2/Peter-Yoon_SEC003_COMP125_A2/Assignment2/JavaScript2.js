var places = ["Alberta", "British Columbia", "Manitoba", "New Brunswick", "Newfoundland",
    "Nova Scotia", "Prince Edward Island", "Ontario", "Quebec", "Saskatchewan"];
function processPlaces() {
    for (var i = 0; i < 11; i++) {
        listItem = "item" + (i + 1);
        document.getElementById(listItem).innerHTML = places[i];
    }
}
if (window.addEventListener) {
    window.addEventListener("load", processPlaces, false);
}
else if (window.addEventListener) {
    window.addEventListener("onload", processPlaces);
}