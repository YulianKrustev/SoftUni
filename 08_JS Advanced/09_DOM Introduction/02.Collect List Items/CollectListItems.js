function extractText() {
    const liElements = document.querySelectorAll('#items li')
    const textArea = document.getElementById('result')

    console.log(liElements.valueOf())

    const elementText = [...liElements].map(e => e.textContent)
    console.log(elementText)

    textArea.value = elementText.join('\n')
}