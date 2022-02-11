function changeVisibilityOfCategories() {
    var devicewidth = document.documentElement.clientWidth;
    var width = (window.innerWidth > 0) ? window.innerWidth : screen.width;
    console.log(width + "va" + devicewidth);
    if(devicewidth < 992 || width < 992) {
        var element = document.getElementById("category-dropdown");
        if(element.classList.contains("category-display-none")) {
            element.classList.remove("category-display-none");
            element.classList.add("category-display-block");
        }
        else {
            element.classList.remove("category-display-block");
            element.classList.add("category-display-none");
        }
    }
}