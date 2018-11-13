var num = 3000;
var score = 0;
var timer;
var orcImg;
//End variable initialization

window.onload = function start() {
    orcImg = document.getElementById("bug");
    orcImg.addEventListener("click", getBug, false);
    update();
}

function resetScore() {
    score = 0;
    document.getElementById('scoreband').innerHTML = score;
    alert("Score Reset");
}
//Reset score

function resetSpeed() {
    num = 3000;
    clearInterval(timer);
    timer = window.setInterval(hopBug, num);
    alert("Speed Reset");
}
//Reset game speed

function update() {
    document.getElementById('scoreband').innerHTML = score;
    timer = window.setInterval(hopBug, num);
}

function getBug() {
    orcImg.removeEventListener("click", getBug, false);
    orcImg.style.left = Math.random() * 400 + "px";
    orcImg.style.top = Math.random() * 200 + "px";
    score = score + 1;
    document.getElementById('scoreband').innerHTML = score;
    num = num - 200;
    clearInterval(timer);
    timer = window.setInterval(hopBug, num);
    alert("You have defeated Shrek!");
}
//Score counter & speed interval reduction

function hopBug() {
    orcImg.style.left = Math.random() * 800 + "px";
    orcImg.style.top = Math.random() * 400 + "px";
    orcImg.addEventListener("click", getBug, false);
}
//Function to have Shrek move around the canvas

