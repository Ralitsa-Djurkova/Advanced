using System;
using System.Collections.Generic;
using System.Text;

namespace _8._1Cars
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            Model = model;
            Power = power;

        }

        public Engine(string model, int power, int displacement) : this(model, power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency) : this(model, power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        public int? Displacement
        {
            get { return displacement; }
            set { displacement = value; }
        }

        public string Efficiency
        {
            get { return efficiency; }
            set { efficiency = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string dispString = this.Displacement.HasValue ? this.Displacement.ToString() : "n/a";
            string effStr = string.IsNullOrEmpty(this.Efficiency) ? "n/a" : this.Efficiency;
            sb
                .AppendLine($" {this.Model}:")
                .AppendLine($"    Power: {this.Power}")
                .AppendLine($"    Displacement: {dispString}")
                .AppendLine($"    Efficiency: {effStr}");

            return sb.ToString().TrimEnd();
        }



    }
}
