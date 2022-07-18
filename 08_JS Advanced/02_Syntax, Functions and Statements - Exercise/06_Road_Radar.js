function roadRadar(speed, area) {
    let speedInfo = {
        motorway: 130,
        interstate: 90,
        city: 50,
        residential: 20
    }

    if (speedInfo[area] >= speed) {

        console.log(`Driving ${speed} km/h in a ${speedInfo[area]} zone`)

    } else {
        let overAllowedSpeed = speed - speedInfo[area];
        let status = '';

        if (overAllowedSpeed <= 20) {
            status = 'speeding';
        } else if(overAllowedSpeed <= 40){
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }
        console.log(`The speed is ${speed - speedInfo[area]} km/h faster than the allowed speed of ${speedInfo[area]} - ${status}`);
    }
}

roadRadar(10, 'residential')