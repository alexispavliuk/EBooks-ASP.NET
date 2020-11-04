window.onload = function () {
    document.getElementById("up_button").addEventListener("click", topFunction);
    document.getElementById("lang_panel").addEventListener("click", chooseLang);
    document.querySelectorAll("p.lang")[0].style.color = "#4e6cbc";
}

function topFunction() {
    document.documentElement.scrollTop = 0;
    document.body.scrollTop = 0;
}

function chooseLang(e) {
    if (e.target.className != "lang") {
        return;
    }
    let languges = document.querySelectorAll("p.lang");
    languges.forEach(lang => lang.style.color = "#a4a9ba");
    e.target.style.color = "#4e6cbc";
}