function htmlTable(data){
let parseData = JSON.parse(data);
let keys = Object.keys(parseData[0]);

let firstRow = '<table>\n';
let columns = '';
let info = '';
let lastRow = '</table>';

for (let i = 0; i < keys.length; i++) {

    columns += `${`<th>${keys[i]}</th>`}`

}

for (let i = 0; i < parseData.length; i++) {

   let values = Object.values(parseData[i]);
   info += '<tr>';

   for (let i = 0; i < values.length; i++) {
        
        info += `<td>${values[i]}</td>`
   }

   info += '</tr>\n'
   
}

let trColumns = `<tr>${columns}</tr>\n`;
let result = firstRow + trColumns + info + lastRow

return result;
}

console.log(htmlTable(`[{"Name":"Pesho",
"Score":4,
"Grade":8},
{"Name":"Gosho",
"Score":5,
"Grade":8},
{"Name":"Angel",
"Score":5.50,
" Grade":10}]`));