function carFactory(car) {
    let newCar = {};
    newCar.model = car.model;

    if (car.power <= 90) {
        newCar.engine = { power: 90, volume: 1800 };
    } else if (car.power <= 120) {
        newCar.engine = { power: 120, volume: 2400 };       
    } else {
        newCar.engine = { power: 200, volume: 3500 };   
    }

    if (car.carriage === 'hatchback') {
        newCar.carriage = { type: 'hatchback', color: car.color }
    } else {
        newCar.carriage ={ type: 'coupe', color: car.color }
    }

    if (car.wheelsize % 2 == 0) {
        newCar.wheels = [car.wheelsize - 1, car.wheelsize - 1, car.wheelsize - 1, car.wheelsize - 1]
    } else {
        newCar.wheels = [car.wheelsize, car.wheelsize, car.wheelsize, car.wheelsize]
    }

    return newCar;
}

console.log(carFactory({ model: 'Opel Vectra',
power: 110,
color: 'grey',
carriage: 'coupe',
wheelsize: 17 }))