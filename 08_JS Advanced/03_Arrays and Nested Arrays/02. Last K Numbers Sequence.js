function arr(n, k) {
    const result = [1];
    
    for (let i = 1; i < n; i++) {
        result.push(result.slice(-k).reduce((a, v) => a+v, 0));
    }
    return result;
}

arr(6, 3);

