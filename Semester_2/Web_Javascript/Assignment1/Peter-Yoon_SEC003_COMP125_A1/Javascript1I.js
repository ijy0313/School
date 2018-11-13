function calc() {
    var age = document.getElementById("age").value;
    var gender = document.getElementById("gender").value;
    var height = document.getElementById("height").value;
    var weight = document.getElementById("weight").value;
    if (gender == "male") {
        bmr = 66 + (6.2 * weight) + (12.7 * height) - (6.76 * age);
    }
    else {
        bmr = 655.1 + (4.35 * weight) + (4.7 * height) - (4.7 * age);
    }
}

document.getElementsByTagName("button")[0].addEventListener("click", function () {
    calc();
    document.getElementById('lblResult').innerHTML = bmr;
})