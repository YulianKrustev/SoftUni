using System.Collections.Generic;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private List<Tire> tires;
        private cargo cargo;

        public Car(cargo cargo, List<Tire> tires, Engine engine, string model)
        {
            Cargo = cargo;
            Tires = tires;
            Engine = engine;
            Model = model;
        }

        public cargo Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }

        public List<Tire> Tires
        {
            get { return tires; }
            set { tires = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
    }
}
