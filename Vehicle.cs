namespace Etapa3Programacion
{
    public class Vehicle
    {
        //Campos
        int IdCounter = 0;
        private int id;
        private string licensePlate;
        private string brand;
        private string line;
        private string model;
        private string color;
        private int capacity;
        //Constructor
        public Vehicle(int id, string licensePlate, string brand, string line,string model, string color, int capacity)
        {
            this.id = id;
            this.licensePlate = licensePlate;
            this.brand = brand;
            this.line = line;
            this.model = model;
            this.color = color;
            this.capacity = capacity;
        }
        //Propiedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string LicensePlate
        {
            get { return licensePlate; }
            set { licensePlate = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Line
        {
            get { return line; }
            set { line = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Capacity
        { 
            get { return capacity; }
            set { capacity = value; }
        }



    }
}
