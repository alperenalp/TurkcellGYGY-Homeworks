using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7InterfaceSegregationPrincipleIdealCode
{
    interface Savable
    {
        void Save();
    }
    interface Editable
    {
        void Edit();
    }
    interface Printable
    {
        void Print();
    }

    class Word : Savable, Editable, Printable
    {
        public void Print()
        {
            Console.WriteLine("Yazdırma işlemleri...");
        }

        public void Save()
        {
            Console.WriteLine("Kaydetme işlemleri...");
        }

        public void Edit()
        {
            Console.WriteLine("Düzenleme işlemleri...");
        }
    }

    class PowerPoint : Savable,Editable
    {
        public void Save()
        {
            Console.WriteLine("Kaydetme işlemleri...");
        }

        public void Edit()
        {
            Console.WriteLine("Düzenleme işlemleri...");
        }
    }

    class AdobeAcrobat : Printable
    {
        public void Print()
        {
            Console.WriteLine("Yazdırma işlemleri...");
        }
    }
}
