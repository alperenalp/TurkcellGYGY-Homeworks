using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3OOP
{
    public interface ICanCarryLoads
    {
        void CarryLoad();
    }

    public abstract class Vehicle
    {
        public abstract void Move();
        public abstract void Stop();
        public string Color { get; set; } = "Beyaz";
        public string Name { get; set; }
    }

    public class Car : Vehicle
    {
        public override void Move()
        {
            Console.WriteLine($"{Name} marka {Color} renkli araba yola çıktı.");
        }

        public override void Stop()
        {
            Console.WriteLine($"{Name}, durduruldu.");
        }
    }

    public class Truck : Vehicle, ICanCarryLoads
    {
        public void CarryLoad()
        {
            Console.WriteLine($"{Name} dorsesine yük yüklendi.");
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} marka {Color} renkli tır yola çıktı.");
        }

        public override void Stop()
        {
            Console.WriteLine("Tır durduruldu.");
        }
    }


    public class Volkswagen : Car
    {
        public Volkswagen()
        {
            Name = "Volkswagen";
        }
        public Volkswagen(string color)
        {
            Name = "Volkswagen";
            Color = color;
        }
    }

    public class Scania : Truck
    {
        public Scania()
        {
            Name = "Scaina";
        }

        public Scania(string color)
        {
            Name = "Scaine";
            Color = color;
        }
    }

}
