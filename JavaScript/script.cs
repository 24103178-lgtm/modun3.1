function upDate(previewPic) {

    console.log("Event triggered!");
    console.log("Alt text: " + previewPic.alt);
    console.log("Image source: " + previewPic.src);

    document.getElementById("image").innerHTML = previewPic.alt;

    document.getElementById("image").style.backgroundImage =
        "url('" + previewPic.src + "')";
}


function undo() {

    document.getElementById("image").style.backgroundImage =
        "url('')";

    document.getElementById("image").innerHTML =
        "Hover over an image below to display here.";
}
function addTabFocus() {
    console.log("addTabFocus function triggered!");

    let images = document.querySelectorAll(".gallery img");

    for (let i = 0; i < images.length; i++) {
        images[i].setAttribute("tabindex", "0");
    }

    console.log("Tabindex added to " + images.length + " images.");
}

window.addEventListener("load", addTabFocus);