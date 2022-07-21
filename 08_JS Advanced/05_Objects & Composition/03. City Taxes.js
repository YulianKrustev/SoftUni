function cityTaxes(name, population, treasury) {
    return {
        name: name,
        population: population,
        treasury: treasury,
        taxRate: 10,

        collectTaxes: function(){
            this.treasury += Math.round(this.population * this.taxRate)
        },
        applyGrowth: function(precentage){
            this.population += Math.round(precentage * this.population / 100)
        },
        applyRecession: function (precentage) {
            this.treasury -= Math.round(precentage * this.treasury / 100)
        }
    }
}

const city = 
  cityTaxes('Tortuga',
  7000,
  15000);

city.applyGrowth(10);
console.log(city.population)