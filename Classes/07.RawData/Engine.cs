

namespace _07.RawData
{
    public class Engine
    {
        private int engineSpeed;
        private int enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }

        public int EngineSpeed
        {
            get { return engineSpeed; }
            set { engineSpeed = value; }
        }
        
        public int EnginePower
        {
            get { return enginePower; }
            set { enginePower = value; }
        }


        //public string Model { get; set; }
        //public int Engine { get; set; }
        //public int Cargo { get; set; }
        //public List<int> Tires { get; set; }

        //public Car(int engine, int cargo, List<int> tires)
        //{
        //    this.Engine = engine;
        //    this.Cargo = cargo;
        //    this.Tires = tires;
        //}
    }
}
