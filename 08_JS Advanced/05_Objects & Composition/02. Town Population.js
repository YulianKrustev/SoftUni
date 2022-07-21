function foo(arr) {

    let output = {};
    for (let i = 0; i < arr.length; i++) {
        arr[i] = arr[i].split(' <-> ')

        if (output[arr[i][0]] != undefined) {
            output[arr[i][0]] = Number(output[arr[i][0]]) + Number(arr[i][1])
        } else {
            output[arr[i][0]] = arr[i][1]
        }  
    }
    
    for (const key in output) {
        console.log(`${key} : ${output[key]}`)
    }
}

foo(['Istanbul <-> 100000',
'Honk Kong <-> 2100004',
'Jerusalem <-> 2352344',
'Mexico City <-> 23401925',
'Istanbul <-> 1000']);