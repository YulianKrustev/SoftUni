function foo(arr, n) {

    for (let i = 0; i < n; i++) {
       let last = arr.pop();
       arr.unshift(last);
        
    }

    console.log(arr.join(" "))
}

foo(['1', 
'2', 
'3', 
'4'], 
2);