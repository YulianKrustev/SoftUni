function foo(params) {
    let result = params.sort((a,b) => a-b).slice(-Math.ceil(params.length / 2));
    return result;
}

console.log(foo([3, 19, 14, 7, 2, 19, 6]))
