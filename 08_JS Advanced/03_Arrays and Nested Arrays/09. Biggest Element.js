function biggestElement(arr) {
    return arr.reduce((a, v) => (a = Math.max(...v) > a ? Math.max(...v) : a), -Infinity)
}

console.log(biggestElement([[20, 50, 10],
    [8, 33, 145]]));