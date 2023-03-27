using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5SingleResponsibilityAndOpenClosePrinciples
{
    public class GraduationService
    {
        public bool CanGraduate(Student student)
        {
            if (student.GradeAvarage >= 2.0)
                return true;
            else
                return false;
        }
    }
}
