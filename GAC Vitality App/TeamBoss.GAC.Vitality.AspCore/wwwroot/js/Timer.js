var clicked = false;
var sec = 0;

function Clock(button) {
    if (clicked === false) {
        clock = setInterval("stopWatch()", 1000);
        clicked = true;
        $(button).find('i').removeClass("fa fa-play");
        $(button).find('i').addClass("fa fa-pause");
        $(button).removeClass("btn btn-success");
        $(button).addClass("btn btn-warning");
    }
    else if (clicked === true) {
        $(button).find('i').removeClass("fa fa-pause");
        $(button).find('i').addClass("fa fa-play");
        $(button).removeClass("btn btn-warning");
        $(button).addClass("btn btn-success");
        pauseClock();
    }
}

function stopWatch() {
    sec++;
    document.getElementById("timer").innerHTML = sec + " s";
}

function pauseClock() {
    window.clearInterval(clock);
    sec = sec;
    document.getElementById("timer").innerHTML = sec + " s";
    clicked = false;
}

function stopClock(button) {
    window.clearInterval(clock);
    sec = 0;
    document.getElementById("timer").innerHTML = 0 + " s";
    clicked = false;
}