function foo(arr) {
    arr.sort((a, b) => a.localeCompare(b)).map((name, i) => console.log(`${i+1}.${name}`))
}

foo(["John", "Bob", "Christina", "Ema"]);