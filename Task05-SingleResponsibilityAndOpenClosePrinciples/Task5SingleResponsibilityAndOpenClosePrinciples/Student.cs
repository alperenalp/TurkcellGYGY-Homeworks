using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5SingleResponsibilityAndOpenClosePrinciples
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Number { get; set; }
        public double GradeAvarage { get; set; }


        // CanGraduate metodu bu sınıfta tanımlandığı zaman bu sınıfın birden fazla sorumluluğu olacağı için Single Responsibility prensibine aykırıdır.

        //public bool CanGraduate()
        //{
        //    if (GradeAvarage >= 2.0)
        //        return true;
        //    else
        //        return false;
        //}
    }
}
