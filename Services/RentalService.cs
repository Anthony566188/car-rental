using car_rental.Dtos;
using car_rental.Models;

namespace car_rental.Services
{
    public class RentalService
    {
        public RentalCalculationResponse Calculate(Car car, DateTime startDate, DateTime endDate)
        {
            // Validação para impedir datas inválidas
            if (endDate <= startDate)
                throw new ArgumentException("End date must be after start date.");

            var days = (endDate - startDate).Days;
            var subtotal = car.DailyValue * days;

            decimal discount = 0;
            if (days >= 7) { discount = 0.10m; subtotal -= subtotal * discount; }
            else if (days >= 3) { discount = 0.05m; subtotal -= subtotal * discount; }

            return new RentalCalculationResponse
            {
                Model = car.Model,
                Brand = car.Brand,
                StartDate = startDate,
                EndDate = endDate,
                DailyValue = car.DailyValue,
                Subtotal = subtotal,
                Discount = discount > 0 ? $"{discount:P}" : "No discount",
                Total = subtotal
            };

        }
    }
}
