using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6LiskovSubstituonPrensible
{
    public static class ReservingService
    {
        public static IReservable ReserveFactory(DateTime date, int days)
        {
            return new Hotel() { ReserveDate = date, ReserveDaysCount = days };
        }

        public static IReservable ReserveFactory(DateTime date, int days, string brand)
        {
            return new Vehicle() { ReserveDate = date, ReserveDaysCount = days, Brand = brand };
        }

        public static IReservable ReserveFactory(DateTime date, int days, int capacity)
        {
            return new ConferencePlace() { ReserveDate = date, ReserveDaysCount = days, Capacity = capacity };
        }

    }

    public interface IReservable
    {
        public void CreateReserve();
    }

    public class Hotel : IReservable
    {
        public DateTime ReserveDate { get; set; }
        public int ReserveDaysCount { get; set; }

        public void CreateReserve()
        {
            Console.WriteLine($"{ReserveDate} tarihinde {ReserveDaysCount} günlük Otel odası rezervasyonu yapıldı.");
        }
    }

    public class Vehicle : IReservable
    {
        public DateTime ReserveDate { get; set; }
        public int ReserveDaysCount { get; set; }
        public string Brand { get; set; }

        public void CreateReserve()
        {
            Console.WriteLine($"{ReserveDate} tarihinde {ReserveDaysCount} günlük {Brand} marka araç rezervasyonu yapıldı.");
        }
    }

    public class ConferencePlace : IReservable
    {
        public DateTime ReserveDate { get; set; }
        public int ReserveDaysCount { get; set; }
        public int Capacity { get; set; }

        public void CreateReserve()
        {
            Console.WriteLine($"{ReserveDate} tarihinde {ReserveDaysCount} günlük {Capacity} kapasiteli konferans salonu rezervasyonu yapıldı.");
        }
    }
}
