function foo(arr) {
    const collection = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].split(' | ');
        let productName = tokens[1];
        let price = +tokens[2];
        let town = tokens[0];

        if (collection[productName] === undefined || collection[productName].price > price) { 

            collection[productName] = {
            price: price,
            town: town
            };

        }    
    }

    for (const key in collection) {

        console.log(`${key} -> ${collection[key].price} (${collection[key].town})`)
    }
}

foo(['Sofia City | Audi | 100000',
'Sofia City | BMW | 100000',
'Sofia City | Mitsubishi | 10000',
'Mexico City | BMW | 99999',
'Mexico City | Audi | 1000',
'Sofia City | NoOffenseToCarLovers | 0',
'Sofia City | Mercedes | 10000'])