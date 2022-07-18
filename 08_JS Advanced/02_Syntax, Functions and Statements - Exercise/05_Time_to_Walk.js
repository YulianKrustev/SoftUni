function timeToWolk(steps, stepLength, speed) {
    let length = steps * stepLength;
    let totalRestInMinutes = Math.floor(length / 500);
    let totalTime = length / speed / 1000 * 60;
    let totalTimeInSeconds = Math.ceil((totalTime + totalRestInMinutes) * 60);
    let result = new Date(null, null, null, null, null, totalTimeInSeconds)

    console.log(result.toTimeString().split(' ')[0]);
}

timeToWolk(4000, 0.6, 5);