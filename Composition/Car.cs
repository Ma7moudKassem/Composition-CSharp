namespace Composition
{
    public class Car
    {
        private string model;
        private string color;
        private int door;

        private Engine engine;



        public Car(string model, string color, int door , Engine engine)
        {
            this.model = model;
            this.color = color;
            this.door = door;
           this.engine = engine;
        }

       

        public Car()
        {
        }

        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Door { get => door; set => door = value; }
        public Engine Engine { get => engine; set => engine = value; }
    }



}