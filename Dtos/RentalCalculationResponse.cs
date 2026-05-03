namespace car_rental.Dtos
{
    public class RentalCalculationResponse
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DailyValue { get; set; }
        public decimal Subtotal { get; set; }
        public string Discount { get; set; }
        public decimal Total { get; set; }
    }
}
