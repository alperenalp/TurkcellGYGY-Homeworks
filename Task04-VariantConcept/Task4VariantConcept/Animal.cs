using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4VariantConcept
{
    //kovaryant
    public class Animal
    {
        public virtual void Feed()
        {
            Console.WriteLine("Animal is being fed.");
        }
    }

    public class Dog : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("Dog is being fed.");
        }
    }

    public class Cat : Animal
    {
        public override void Feed()
        {
            Console.WriteLine("Cat is being fed.");
        }
    }



    //kontravaryant
    public class HayvanBarinagi
    {
        private List<Animal> hayvanlar = new List<Animal>();

        public virtual void EvcilHayvanEkle(Animal hayvan)
        {
            hayvanlar.Add(hayvan);
        }
    }

    public class KediBarinagi : HayvanBarinagi
    {
        public override void EvcilHayvanEkle(Animal hayvan)
        {
            if (hayvan is Cat)
            {
                base.EvcilHayvanEkle(hayvan);
            }
            else
            {
                throw new ArgumentException("Kedi barınağına sadece Kedi nesneleri ekleyebilirsiniz.");
            }
        }
    }


    interface IAnimal<in T>
    {
        void MakeSound(T animal);
    }

    class AnimalSound<T> : IAnimal<T>
    {
        public void MakeSound(T animal)
        {
            Console.WriteLine("The animal made a sound.");
        }
    }

}
