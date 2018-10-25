function doc_keyUp(e) {
    if (e.ctrlKey && e.keyCode == 32) {
        var btnVisible = $(".btn-visible");
        var btnHidden = $(".btn-hidden");

        btnVisible.removeClass("btn-visible");
        btnVisible.addClass("btn-hidden");
        
        btnHidden.removeClass("btn-hidden");
        btnHidden.addClass("btn-visible");
    }
}
document.addEventListener('keyup', doc_keyUp, false);