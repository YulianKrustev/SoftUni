function edit(el, match, replacer) {
    
    el.textContent = el.textContent.replace(new RegExp(match, 'g'), replacer)
}