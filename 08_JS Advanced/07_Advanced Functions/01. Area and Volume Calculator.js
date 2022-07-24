function foo(area, volume, inputs) {
    return JSON.parse(inputs).reduce((a, v) => {
        a.push({
            area: area.call(v),
            volume: volume.call(v),
        })
        return a
    }, [])
}




area, vol, `[
    {"x":"1","y":"2","z":"10"},
    {"x":"7","y":"7","z":"10"},
    {"x":"5","y":"2","z":"10"}
    ]`