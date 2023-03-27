using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3OOP
{
    public class Player
    {
        private string Name { get; set; }
        public Player(string name)
        {
            Name = name;
        }
        public Vehicle PlayerVehicle { get; set; }
        private bool isMoving { get; set; } = false;
        public void Move()
        {
            if (!isMoving)
            {
                PlayerVehicle.Move();
                isMoving = true;
            }
            else
            {
                Console.WriteLine("Araç zaten hareket ediyor.");
            }
        }
        public void Stop()
        {
            if (isMoving)
            {
                PlayerVehicle.Stop();
                isMoving = false;
            }
            else
            {
                Console.WriteLine("Araç zaten durdurulmuş");
            }
        }
        public void CarryLoad()
        {
            if (PlayerVehicle is ICanCarryLoads)
            {
                ICanCarryLoads canCarryLoads = (ICanCarryLoads)PlayerVehicle;
                canCarryLoads.CarryLoad();
            }
            else
            {
                Console.WriteLine($"{PlayerVehicle.Name} yük taşıyamaz");
            }
        }
    }
}
