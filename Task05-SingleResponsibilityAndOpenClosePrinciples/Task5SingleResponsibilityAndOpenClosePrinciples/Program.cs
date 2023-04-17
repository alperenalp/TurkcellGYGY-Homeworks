using Task5SingleResponsibilityAndOpenClosePrinciples;


// SOLID prensiplerinden Single Responsibility Principle (Tek Sorumluluk Prensibi)
// ve Open Closed Priciple (Açık Kapalı Prensibi) ile ilgili örnekler yapmaya çalışacağım.



// İlk olarak SRP'ye göre, bir sınıf veya fonksiyon yalnızca bir iş yapmalı ve yalnızca bir nedenle değiştirilmelidir.
// Bu şekilde kodumuz daha anlaşılır, test edilebilir ve bakımı kolay olur.

Student student = new Student();
student.Name = "Alperen";
student.LastName = "Alp";
student.Number = 45;
student.GradeAvarage = 3.47;

// ortalama hesaplama sorumluluğunu öğrenci sınıfının yapması mantıklı değildir bu nedenle başka bir sınıfta bu sorumluluğun yapılmasını sağlamalıyız.
GraduationService graduationService = new GraduationService();
bool graduation = graduationService.CanGraduate(student);
if (graduation)
    Console.WriteLine($"{student.Name} mezun oldu.\n");
else
    Console.WriteLine($"{student.Name} elbet bir gün olacak\n");




// OC'ye göre, kodumuz-bileşenimiz değişime kapalı gelişime açık olmalıdır.
// Bu şekilde yazılımın esnekliğini artırır ve değişen gereksinimlere uyum sağlamak için kodun daha az değiştirilmesini gerektirir.

CRUDService crudService = new CRUDService();

Student student1 = new Student { Name = "Ali", Number = 1 };
Student student2 = new Student { Name = "Veli", Number = 2 };
crudService.AddStudent(student1);
crudService.AddStudent(student2);

Teacher teacher1 = new Teacher { Name = "Ayşe", Branch = "Matematik" };
Teacher teacher2 = new Teacher { Name = "Fatma", Branch = "Fizik" };
crudService.AddTeacher(teacher1);
crudService.AddTeacher(teacher2);

Lesson lesson1 = new Lesson { Name = "Matematik", Code = "MAT101" };
Lesson lesson2 = new Lesson { Name = "Fizik", Code = "FIZ101" };
crudService.AddLesson(lesson1);
crudService.AddLesson(lesson2);

Console.WriteLine("Okuldaki Öğrenciler:");
crudService.ShowStudents();

Console.WriteLine("Okuldaki Öğretmenler:");
crudService.ShowTeachers();

Console.WriteLine("Okuldaki Dersler:");
crudService.ShowLessons();

Lesson lesson3 = new Lesson { Name = "Kimya", Code = "KIM101" };
crudService.AddLesson(lesson3);

Console.WriteLine("Okuldaki Dersler (Güncellendi):");
crudService.ShowLessons();

Console.ReadLine();

/*
 *
 * Bu örnekte, yeni bir ders eklemek istediğimizde sadece CRUDService sınıfına AddLesson() metodu ile yeni bir ders eklememiz yeterli olacaktır. 
 * Mevcut kodlarda herhangi bir değişiklik yapmamız gerekmez.
 * 
 * */