using System;
using DBfirstStudents.Models;

namespace DBfirstStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            using(DBStudentsContext db = new DBStudentsContext())
            {
                // создаем два объекта Student
                Student student1 = new Student { StudentID = 1, LastName = "Tom", FirstName = "Smith" };
                Student student2 = new Student { StudentID = 2, LastName = "Sam", FirstName = "Hook" };
 
                // добавляем их в бд
                db.Student.Add(student1);
                db.Student.Add(student2);
                db.SaveChanges();
                Console.WriteLine("Объекты успешно сохранены");
 
                // получаем объекты из бд и выводим на консоль
                var users = db.Student;
                Console.WriteLine("Список объектов:");
                foreach(Student u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.StudentID, u.FirstName, u.LastName);
                }
            }
            Console.Read();           
        }
    }
}
