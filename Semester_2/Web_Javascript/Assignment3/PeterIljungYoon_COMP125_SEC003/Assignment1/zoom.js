"use strict"; // interpret document contents in JavaScript strict mode

/* global variables */
var imageUrl = window.location.search.substring(1).split('=')[1];

/* populate img element and create event listener */
function pageSetup() {
    document.getElementsByTagName("img")[0].src = imageUrl; // assign filename to img element
    createEventListener();
}

/* close window */
function closeWin() {
    window.close();
}

function addToFavs() {
    window.opener.postMessage(imageUrl, '*');
}

/* create event listener for close button */
function createEventListener() {
    var closeWindowDiv = document.getElementsByTagName("p")[0];
    if (closeWindowDiv.addEventListener) {
        closeWindowDiv.addEventListener("click", closeWin, false);
    } else if (closeWindowDiv.attachEvent) {
        closeWindowDiv.attachEvent("onclick", closeWin);
    }

    var addToFavsDiv = document.getElementsByTagName("p")[1];
    if (addToFavsDiv.addEventListener) {
        addToFavsDiv.addEventListener("click", addToFavs, false);
    } else if (addToFavsDiv.attachEvent) {
        addToFavsDiv.attachEvent("onclick", addToFavs);
    }
}

/* add img src value and create event listener when page finishes loading */
window.onload = pageSetup;
