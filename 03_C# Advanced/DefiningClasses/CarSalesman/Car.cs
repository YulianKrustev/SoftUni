﻿namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine, string weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

        public string Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override string ToString()
        {
            return $"{Model}:\n  {engine.Model}:\n    Power: {engine.Power}\n    Displacement: {engine.Displacement}\n    Efficiency: {engine.Efficiency}\n  Weight: {Weight}\n  Color: {Color}";
        }
    }
}
