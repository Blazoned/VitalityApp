var calorieCounterProgressCircle; // A reference to the calorie counter progress circle object.
var maxCalorieCount; // The maximum daily amount of calories.
var maxCaloriePercentage; // The calories to add per percentage.

$(document).ready(function () {
    calorieCounterProgressCircle = $(".progress-circle");

    SetMaxCalorieCount($(calorieCounterProgressCircle).data("max-calories"));
    setInterval(UpdateCalorieCounterCircle, 33);
});

// Sets the maxCalorieCount to the given value and updates the maxCaloriePercentage variable accordingly.
function SetMaxCalorieCount(newMaxCalorieCount) {
    maxCalorieCount = newMaxCalorieCount;
    maxCaloriePercentage = maxCalorieCount / 100;
}

function UpdateCalorieCounterCircle() {
    var currentCalories = $(calorieCounterProgressCircle).attr("data-current-calories"); // The current calories being displayed.
    var targetCalories = $(calorieCounterProgressCircle).attr("data-target-calories"); // The number of calories that should be displayed.
    
    if (currentCalories != targetCalories) {
        var currentCaloriesInt = parseFloat(currentCalories);
        var targetCaloriesInt = parseFloat(targetCalories);

        var targetPercentageInt = parseInt((targetCaloriesInt * 100) / maxCalorieCount); // The percentage that should be displayed.
        var currentPercentage = $(calorieCounterProgressCircle).attr("data-progress"); // The percentage actually being displayed.
        var currentPercentageInt = parseInt(currentPercentage);
        
        if (currentPercentageInt < targetPercentageInt) {
            currentPercentageInt += 1;
            currentCaloriesInt += maxCaloriePercentage;

            if (currentCaloriesInt > targetCaloriesInt) {
                currentPercentageInt = 100;
                currentCaloriesInt = targetCaloriesInt;
            }
        }
        else {
            currentPercentageInt -= 1;
            currentCaloriesInt -= maxCaloriePercentage;

            if (currentCaloriesInt < targetCaloriesInt) {
                currentPercentageInt = 0;
                currentCaloriesInt = targetCaloriesInt;
            }
        }

        $(calorieCounterProgressCircle).attr("data-current-calories", currentCaloriesInt);
        $(calorieCounterProgressCircle).attr("data-progress", currentPercentageInt);
    }
}