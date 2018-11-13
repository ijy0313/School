
/*Event Handler for Register now button*/
function createID() {
    var fname = document.getElementById("fName");
    var lname = document.getElementById("lName");
    var address = document.getElementById("address");
    var city = document.getElementById("city");
    var zip = document.getElementById("postalcode");
    var province = document.getElementById("province");
    var age = document.getElementById("age");
    var password = document.getElementById("password");
    var confirm = document.getElementById("passwordconfirm");
    var email = document.getElementById("email");
    var warning = document.getElementById("formError");

    //Warning if not all fields are input
    if (fname.value === "" || lname.value === "" ||
        address.value === "" || city.value === "") {
        warning.innerHTML = "<h3>**Fill all required fields**</h3>";
        return false;
    }

    //Warning if incorrect postal code format
    var regEx = /[a-zA-Z][0-9][a-zA-Z](-| |)[0-9][a-zA-Z][0-9]/;
    if (zip.value === "" || regEx.test(zip.value) === false) {
        warning.innerHTML = "<h3>**Postal code format is: a1a2b2**</h3>";
        return false;
    }

    //Choice between different provinces
    if (province.value === "AB" || province.value === "BC" || province.value === "MN" ||
        province.value === "ON" || province.value === "QC" || province.value === "SK" ||
        province.value === "ab" || province.value === "bc" || province.value === "mn" ||
        province.value === "on" || province.value === "qc" || province.value === "sk") {
    //Warning if incorrect province
    }
    else {
        warning.innerHTML = "<h3>**Choose one of the follwing: AB, BC, MN, ON, QC, SK**</h3>";
        return false;
    }

    //Warning if age is under 18
    if (age.value < 18) {
        warning.innerHTML = "<h3>**Required age must be 18 or over**</h3>";
        return false;
    }
    if (password.value.length < 4) {
        warning.innerHTML = "<h3>**Password length must be over 4 characters**</h3>";
        return false;

    //Warning if passwords do not match
    }
    if (password.value !== passwordconfirm.value) {
        warning.innerHTML = "<h3>**Password does not match. Please try again**</h3>";
        return false;
    }

    //Warning if email format is incorrect
    var at = email.value.search("@");
    var period = email.value.search(".");
    if (at === -1 || period === -1) {
        warning.innerHTML = "<h3>**Please input correct email address**</h3>";
        return false;
    }

    alert("You have successfully registered as a new member!");
    warning.innerHTML = "";
    return false;
}