
using System.Text;

namespace StartUp
{
    public class Car
    {
        private string model;
        private Engine engine;
        private double? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            Model = model;
            Engine = engine;
           
        }
        public Car(string model, Engine engine, double weight) : this(model, engine)
        {
            Weight = weight;
        }
        public Car(string model, Engine engine, string color) : this (model, engine)
        {
            Color = color;
        }
        public Car(string model, Engine engine, double weight, string color) : this(model, engine)
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
       

        public double? Weight 
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
            StringBuilder sb = new StringBuilder();
            string weightString = this.Weight.HasValue ? this.Weight.ToString() : "n/a";
            string colorString = string.IsNullOrEmpty(this.Color) ? "n/a" : this.Color;
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($" {this.Engine}");
            sb.AppendLine($"  Weight: {weightString}");
            sb.AppendLine($"  Color: {colorString}");

            return sb.ToString();
        }

    }
}
