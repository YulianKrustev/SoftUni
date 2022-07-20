function foo(arr) {
   let result = arr.reduce((acc, currElement) => {

    let lastElement = acc[acc.length - 1];

    if (lastElement <= currElement || lastElement == undefined) {
        acc.push(currElement);
    }
    return acc;

   }, [])

   return result;
}

console.log(foo([1, 
    3, 
    8, 
    4, 
    10, 
    12, 
    3, 
    2, 
    24]));