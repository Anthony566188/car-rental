namespace car_rental.Dtos
{
    public class RentalCalculationRequest
    {
        public int CarroId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
