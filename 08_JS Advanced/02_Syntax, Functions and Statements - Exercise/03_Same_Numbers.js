function checkNumbers(num) {
    let numArr = Array.from(String(num));
    let sum = 0;
    let areSame = true;
    let digit = Number(numArr[0]);

    for (let index = 0; index < numArr.length; index++) {
        sum += Number(numArr[index]);
        
        if (index > 0 && Number(numArr[index]) !== digit ) {
            areSame = false;
        }
    }

    console.log(areSame);
    console.log(sum);
}

checkNumbers(2222222);