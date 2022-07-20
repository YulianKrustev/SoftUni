function foo(arr, step) {
    let result = [];

    for (let i = 0; i < arr.length; i+=step) {

        result.push(arr[i])
    }

    return result;
}

console.log(
foo(['1', 
'2',
'3', 
'4', 
'5'], 
6));