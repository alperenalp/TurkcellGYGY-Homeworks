using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5SingleResponsibilityAndOpenClosePrinciples
{
    public class CRUDService
    {
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Lesson> lessons = new List<Lesson>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddLesson(Lesson lesson)
        {
            lessons.Add(lesson);
        }

        public void ShowStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine("Öğrenci Adı: " + student.Name + ", Öğrenci Numarası: " + student.Number);
            }
        }

        public void ShowTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine("Öğretmen Adı: " + teacher.Name + ", Öğretmen Branşı: " + teacher.Branch);
            }
        }

        public void ShowLessons()
        {
            foreach (var lesson in lessons)
            {
                Console.WriteLine("Ders Adı: " + lesson.Name + ", Ders Kodu: " + lesson.Code);
            }
        }
    }
}
