function factory(library, orders) {
    let result = [];

    for (let i = 0; i < orders.length; i++) {
        
        let obj = {};
        obj['name'] = orders[i].template.name;

        for (let index = 0; index < orders[i].parts.length; index++) {
            obj[orders[i].parts[index]] = library[orders[i].parts[index]];
            
        }      
        result.push(obj);
    }
    return result
}



const library = {
    print: function () {
      console.log(`${this.name} is printing a page`);
    },
    scan: function () {
      console.log(`${this.name} is scanning a document`);
    },
    play: function (artist, track) {
      console.log(`${this.name} is playing '${track}' by ${artist}`);
    },
  };
  const orders = [
    {
      template: { name: 'ACME Printer'},
      parts: ['print']      
    },
    {
      template: { name: 'Initech Scanner'},
      parts: ['scan']      
    },
    {
      template: { name: 'ComTron Copier'},
      parts: ['scan', 'print']      
    },
    {
      template: { name: 'BoomBox Stereo'},
      parts: ['play']      
    }
  ];
  const products = factory(library, orders);
  console.log(products);
  

