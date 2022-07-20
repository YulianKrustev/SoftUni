function negativePostive(params) {
    let result = [];
    params.map(x=> (x < 0 ? result.unshift(x) : result.push(x)));
    result.map(x=> console.log(x))
}

negativePostive([7, -2, 8, 9]);