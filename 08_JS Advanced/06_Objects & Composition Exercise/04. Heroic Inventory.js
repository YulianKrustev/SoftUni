function library(arr){
    const collection = [];

    for (let i = 0; i < arr.length; i++) {
        let tokens = arr[i].replace(' / ', ', ').replace(' / ', ', ').split(', ')
        let currentHero = {
            name: tokens[0],
            level: Number(tokens[1]),
            items: tokens.slice(2)
        } 

        collection.push(currentHero)
    }

   console.log(JSON.stringify(collection))
}

library(['Isacc / 25 / Apple, GravityGun',
'Derek / 12 / BarrelVest, DestructionSword',
'Hes / 1 / Desolator, Sentinel, Antara'])