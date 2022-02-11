function changeVisibilityOfCategories() {
    var devicewidth = document.documentElement.clientWidth;
    var width = (window.innerWidth > 0) ? window.innerWidth : screen.width;

    if(devicewidth < 992 || width < 992) {
        var element = document.getElementById("category-dropdown");
        if(element.classList.contains("category-display-none")) {
            element.classList.remove("category-display-none");
            element.classList.add("category-display-block");
        }
        else if(element.classList.contains("category-display-block")) {
            element.classList.remove("category-display-block");
            element.classList.add("category-display-none");
        }
        else {
            element.classList.add("category-display-block");
        }
    }
}

function changeVisibilityInLarge() {
    var devicewidth = document.documentElement.clientWidth;
    var width = (window.innerWidth > 0) ? window.innerWidth : screen.width;
    var element = document.getElementById("category-dropdown");

    if(devicewidth  >= 992 || width >= 992) {
        if(element.classList.contains("category-display-none")) {
            element.classList.remove("category-display-none");
        }
    }
}