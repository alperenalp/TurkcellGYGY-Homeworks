using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7InterfaceSegregationPrinciple
{
    interface IDocumenter
    {
        void Save();
        void Edit();
        void Print();
    }

    class Word : IDocumenter
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

    class PowerPoint : IDocumenter
    {
        public void Print() => throw new NotSupportedException();

        public void Save()
        {
            Console.WriteLine("Kaydetme işlemleri...");
        }

        public void Edit()
        {
            Console.WriteLine("Düzenleme işlemleri...");
        }
    }

    class AdobeAcrobat : IDocumenter
    {
        public void Print()
        {
            Console.WriteLine("Yazdırma işlemleri...");
        }

        public void Save() => throw new NotSupportedException();

        public void Edit() => throw new NotSupportedException();
    }
}
