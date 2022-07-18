function agg(arr) {
    let sum1 = 0;
    let sum2 = 0;
    let sum3 = '';

    for (let index = 0; index < arr.length; index++) {
        sum1 += arr[index];
        let currentNum = 1/arr[index];
        sum2 += currentNum;
        sum3 += arr[index];
    }

    console.log(sum1);
    console.log(sum2);
    console.log(sum3);
}

agg([2,4,8, 16])