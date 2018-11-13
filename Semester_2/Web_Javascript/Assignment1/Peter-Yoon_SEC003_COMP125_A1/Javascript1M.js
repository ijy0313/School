function calc() {
    var age = document.getElementById("age").value;
    var gender = document.getElementById("gender").value;
    var height = document.getElementById("height").value;
    var weight = document.getElementById("weight").value;
    if (gender == "male") {
        bmr = 66.5 + (13.75 * weight) + (5.003 * height) - (6.755 * age);
    }
    else {
        bmr = 655.1 + (9.563 * weight) + (1.850 * height) - (4.676 * age);
    }
}

document.getElementsByTagName("button")[0].addEventListener("click", function () {
    calc();
    document.getElementById('lblResult').innerHTML = bmr;
})



