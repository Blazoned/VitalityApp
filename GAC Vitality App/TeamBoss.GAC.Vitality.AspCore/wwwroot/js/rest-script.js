var minutesLabel = document.getElementById("minutes");
var secondsLabel = document.getElementById("seconds");
var totalSeconds = 0;
var timeUpdate;

function setTime() {
    ++totalSeconds;
    secondsLabel.innerHTML = pad(totalSeconds % 60);
    minutesLabel.innerHTML = pad(parseInt(totalSeconds / 60));
}

function startTime() {
    setTime();
    timeUpdate = setInterval(setTime, 1000);
}

function stopTime() {
    pauseTime();
    totalSeconds = 0;
    secondsLabel.innerHTML = pad(0);
    minutesLabel.innerHTML = pad(0);
}

function pauseTime() {
    clearInterval(timeUpdate);
}

function pad(val) {
    var valString = val + "";
    if (valString.length < 2) {
        return "0" + valString;
    } else {
        return valString;
    }
}