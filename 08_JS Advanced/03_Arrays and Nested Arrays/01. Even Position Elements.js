function evenPositionInArray(nums) {
    let evenPositionNumbers = [];
    counter = 0;

    for (let index = 0; index < nums.length; index++) {
        if (index == 0 || index % 2 == 0) {
            evenPositionNumbers[counter] = nums[index]; 
            counter++;
        }
        
    }

    console.log(evenPositionNumbers.join(" "));
}

function getEvens(arr) {
    arr = arr.filter((_, i) => i % 2 === 0)
    console.log(arr.join(" "))
}

evenPositionInArray(['20', '30', '40', '50', '60']);