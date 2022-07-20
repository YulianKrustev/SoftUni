function arrOfPies(arrOfFlavors, startPie, endPie) {

    return arrOfFlavors.slice(arrOfFlavors.indexOf(startPie), arrOfFlavors.indexOf(endPie) + 1);
}

console.log(arrOfPies(['Pumpkin Pie',
'Key Lime Pie',
'Cherry Pie',
'Lemon Meringue Pie',
'Sugar Cream Pie'],
'Key Lime Pie',
'Lemon Meringue Pie'));