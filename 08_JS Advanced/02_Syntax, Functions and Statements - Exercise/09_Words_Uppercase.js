function wordUpperCaseer(s) {
    return s.match(/\w+/g).join(", ").toUpperCase()
}

console.log(wordUpperCaseer('Functions in JS can be nested, i.e. hold other functions'));