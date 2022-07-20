function sumFirstLast(params) {
    let result = Number(params.slice(0, 1)) + Number(params.pop());
    return result;
}

console.log(sumFirstLast(['20', '30', '40']));