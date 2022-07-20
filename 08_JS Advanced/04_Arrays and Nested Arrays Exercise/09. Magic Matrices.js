function foo(arr) {
    let isMagic = true;
    let magicSum;

    for (let row = 0; row < arr.length; row++) {
        let currentSum;

        if (row==0) {
            magicSum = arr[row].reduce((acc, current) => acc + current, 0);
        } else {
            currentSum = arr[row].reduce((acc, current) => acc + current, 0);
        }
    
        if(currentSum != magicSum && currentSum != undefined){
            isMagic = false;
            break;
        }
        
    }

    for (let col = 0; col < arr.length; col++) {
        let currentSum = 0;
        for (let row = 0; row < arr.length; row++) {
            
            currentSum += arr[row][col];
 
        }
        
        if (currentSum != magicSum) {
            isMagic = false;
            break;
        }
    }

    console.log(isMagic)
    
}

foo([[4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]]);