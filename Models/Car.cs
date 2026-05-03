namespace car_rental.Models
{
    public class Car
    {
        public int Id { get; private set; }
        public string Model { get; private set; }
        public string Brand { get; private set; }
        public int Year { get; private set; }
        public decimal DailyValue { get; private set; }

        protected Car() { }

        public Car(string model, string brand, int year, decimal dailyValue)
        {
            this.Model = model;
            this.Brand = brand;
            this.Year = year;
            this.DailyValue = dailyValue;
        }


    }
}
