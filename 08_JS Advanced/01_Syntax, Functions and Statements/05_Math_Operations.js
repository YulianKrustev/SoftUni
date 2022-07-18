function mathOperations(num1, num2, operator) {
    let result = 0;

    switch (operator) {
        case '+': result = num1 + num2; break;
        case '%': result = num1 % num2; break;
        case '*': result = num1 * num2; break;
        case '/': result = num1 / num2; break;
        case '-': result = num1 - num2; break;
        case '**': result = num1 ** num2; break;
    

    }
    console.log(result);
}

mathOperations(1,2,'+');
mathOperations(1,2,'-');
mathOperations(1,2,'*');
mathOperations(1,2,'/');
mathOperations(1,2,'%');