function foo(arr) {
    let result = [];

    for (let i = 0; i < arr.length; i++) {

        if (arr[i] === 'add') {
            result.push(i+1);
        } else{
            result.pop();
        }
    }

    result.length == 0 ? console.log('Empty') :
    result.forEach(element => console.log(element));
}

foo(['remove', 
'remove', 
'remove']);