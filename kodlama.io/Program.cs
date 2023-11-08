using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(1," Diana Kaynak ","diana@gmail.com ","123 ","bahçelievler ","resim.jpeg ",1);

            Console.WriteLine(student.Id+student.FullName+student.Email+student.Password+student.Address+student.ImagePath+student.CourseId);
            


            Course course = new Course
            {
                Id = 1,
                Title = "CSharp+ Angular",
                Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan" +
                "yazılım geliştirme öğreniyoruz.",
                Teacher = "Engin Demiroğ",
                Price = "Ücretsiz",
                ImagePath = "CSharp.jpg"

                
            };

            Console.WriteLine(course.Id + course.Title + course.Description+course.Teacher+course.Price+course.ImagePath);
            

            CourseOfTeacher courseofteacher = new CourseOfTeacher();

            courseofteacher.Id = 1;
            courseofteacher.CourseId = 1;
            courseofteacher.TeacherId = 1;

            Console.ReadLine();



        }
    }
}
