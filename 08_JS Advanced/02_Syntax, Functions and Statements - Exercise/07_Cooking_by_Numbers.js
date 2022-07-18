function cookingFunc(number, operation01, operation02, operation03, operation04,operation05) {
    let n = Number(number);
    let arrOperations = [operation01, operation02, operation03, operation04, operation05];
    let actions = {
        chop: (x)=> x/2,
        dice: (x)=> Math.sqrt(x),
        spice: (x)=> x+1,
        bake: (x)=> x*3,
        fillet: (x)=> 0.8 * x
    }

   for (let i = 0; i < arrOperations.length; i++) { 
     n = actions[arrOperations[i]](n)
     console.log(n);
   }
}

cookingFunc('32', 'chop', 'chop', 'chop', 'chop', 'chop');