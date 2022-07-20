function foo(arr) {
    arr = arr.sort((a, b) => a - b);
    let result = [];
    let index = arr.length - 1;

    for (let i = 0; i < arr.length; i++) {

        if (i === index-i) {
            result.push(arr[i]);
            break;
        }

        if (result.length == arr.length) {
            break;
        }

        result.push(arr[i]);
        result.push(arr[index- i]);
        
    }

    return result;

}

console.log(foo([22,1,2,5]));