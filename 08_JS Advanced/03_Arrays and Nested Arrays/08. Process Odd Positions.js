function foo(params) {
    return params.filter((element, i) => i % 2 !== 0).map(x=>x*2).reverse()
}

console.log(foo([10, 15, 20, 25]));