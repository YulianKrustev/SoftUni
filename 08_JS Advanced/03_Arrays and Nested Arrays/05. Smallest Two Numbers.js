function twoSmallestNumbers(params) {
    let result = [];
    result = params.sort((a,b) => a-b).slice(0,2);
    console.log(result.join(' '));
}

twoSmallestNumbers([30, 15, 50, 5]);