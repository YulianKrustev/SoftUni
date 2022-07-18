function sumOfElements(startNum, endNum) {
    let result = 0;

    for (let index = Number(startNum); index <= Number(endNum); index++) {
        result += index;
        
    }

    console.log(result);
}

sumOfElements('1', '5');