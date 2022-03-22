namespace Composition
{
    public class Engine
    {

        private string type;
        private string power;

        public Engine(string type, string power)
        {
            this.type = type;
            this.power = power;
        }

        public Engine()
        {
        }

        public string Type { get => type; set => type = value; }
        public string Power { get => power; set => power = value; }
    }



}