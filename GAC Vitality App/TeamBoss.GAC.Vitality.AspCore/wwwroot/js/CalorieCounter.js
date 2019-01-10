var calorieCounterProgressCircle; // A reference to the calorie counter progress circle object.
var oldMaxCalorieCount = 0;

$(document).ready(function () {
    calorieCounterProgressCircle = $(".progress-circle");
    setInterval(UpdateCalorieCounterCircle, 33);
});

function UpdateCalorieCounterCircle() {
    var maxCalorieCount = $(calorieCounterProgressCircle).attr("data-max-calories");

    if (maxCalorieCount != oldMaxCalorieCount) {
        oldMaxCalorieCount = maxCalorieCount;
        $(calorieCounterProgressCircle).attr("data-current-calories", 0);
        $(calorieCounterProgressCircle).attr("data-progress", 0);
    }

    var currentCalories = $(calorieCounterProgressCircle).attr("data-current-calories"); // The current calories being displayed.
    var targetCalories = $(calorieCounterProgressCircle).attr("data-target-calories"); // The number of calories that should be displayed.

    if (currentCalories != targetCalories) {
        var currentCaloriesInt = parseFloat(currentCalories);
        var targetCaloriesInt = parseFloat(targetCalories);

        var targetPercentageInt = parseInt(targetCaloriesInt / maxCalorieCount * 100); // The percentage that should be displayed.
        var currentPercentage = $(calorieCounterProgressCircle).attr("data-progress"); // The percentage actually being displayed.
        var currentPercentageInt = parseInt(currentPercentage);

        var maxCaloriePercentage = maxCalorieCount / 100;

        if (currentPercentageInt < targetPercentageInt) {
            currentPercentageInt += 1;
            currentCaloriesInt += maxCaloriePercentage;

            if (currentCaloriesInt > targetCaloriesInt) {
                currentCaloriesInt = targetCaloriesInt;
            }
            if (currentPercentageInt > 100) {
                currentPercentageInt = 100;
            }
        }
        else {
            currentPercentageInt -= 1;
            currentCaloriesInt -= maxCaloriePercentage;

            if (currentCaloriesInt < targetCaloriesInt) {
                currentCaloriesInt = targetCaloriesInt;
            }
            if (currentPercentageInt < 0) {
                currentPercentageInt = 0;
            }
        }

        $(calorieCounterProgressCircle).attr("data-current-calories", currentCaloriesInt);
        $(calorieCounterProgressCircle).attr("data-progress", currentPercentageInt);
    }
}