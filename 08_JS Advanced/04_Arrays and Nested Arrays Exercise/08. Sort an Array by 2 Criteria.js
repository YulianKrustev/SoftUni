function foo(arr) {
    let result = arr.sort().sort((a, b) => a.length - b.length);
    console.log(result.join('\n'))
}

foo(['Isacc', 
'Theodor', 
'Jack', 
'Harrison', 
'George']
)