function foo(arr) {
    const catalouge = arr.sort()
    let currentLettter;

    const objCatalouge = [];


    for (let i = 0; i < catalouge.length; i++) {
        
        if(currentLettter === undefined || catalouge[i].slice(0, 1) !== currentLettter){
            currentLettter = catalouge[i].slice(0, 1);
            console.log(currentLettter);
        }

        console.log(`  ${catalouge[i].split(' : ')[0]}: ${catalouge[i].split(' : ')[1]}`)
        

    }
}

foo(['Appricot : 20.4',
'Fridge : 1500',
'TV : 1499',
'Deodorant : 10',
'Boiler : 300',
'Apple : 1.25',
'Anti-Bug Spray : 15',
'T-Shirt : 10']
)