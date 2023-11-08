using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io
{
    public class Student
    {
        public int Id;
        public string FullName;
        public string Email;
        public string Password;
        public string Address;
        public string ImagePath;
        public int CourseId;

        public Student(int id,string fullName,string email,string password,string address,string imagePath,int courseId)
        {
            Id = id;
            FullName = fullName;
            Email=email;
            Password = password;
            Address = address;
            ImagePath = imagePath;
            CourseId = courseId;


        }



    }
}
