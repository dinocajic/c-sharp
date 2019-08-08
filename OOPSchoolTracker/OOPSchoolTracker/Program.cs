using System;
using System.Collections.Generic;

namespace OOPSchoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var adding   = true;

            students.Add( new Student("Dino", "01/01/2000", "123 Happy Lane, Happy, Happy 90210", 103, 5554443333) );
            students.Add( new Student("Frank", "02/01/2000", "124 Happy Lane, Happy, Happy 90210", 102, 5554443334) );
            students.Add( new Student("Steve", "03/01/2000", "125 Happy Lane, Happy, Happy 90210", 101, 5554443335) );

            while (adding)
            {
                var newStudent = new Student();

                newStudent.Name     = OOPUtil.Console.Ask("Student Name: ");
                newStudent.Birthday = OOPUtil.Console.Ask("Student Birthday: ");
                newStudent.Address  = OOPUtil.Console.Ask("Student Address: ");
                newStudent.Phone    = Int64.Parse( OOPUtil.Console.Ask("Student Phone: ") );
                newStudent.Grade    = int.Parse( OOPUtil.Console.Ask("Student Grade: ") );

                Console.WriteLine("Add another student? y/n");

                students.Add(newStudent);
                Student.Count++;

                if ( Console.ReadLine() != "y" )
                {
                    adding = false;
                }
            }

            Console.WriteLine("Student Count: {0}", Student.Count);

            foreach (var student in students)
            {
                Console.WriteLine("Student: {0}",    student.Name);
                Console.WriteLine("- Address: {0}",  student.Address);
                Console.WriteLine("- Birthday: {0}", student.Birthday);
                Console.WriteLine("- Phone: {0}",    student.Phone);
                Console.WriteLine("- Grade: {0}",    student.Grade);
            }
        }
    }

    class Member
    {
        public Member() { }

        public Member( string name, string birthday, string address, Int64 phone ) {
            this.Name     = name;
            this.Birthday = birthday;
            this.Address  = address;
            this.Phone    = phone;
        }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public string Address { get; set; }

        public Int64 Phone { get; set; }
    }

    class Student : Member
    {
        public static int Count = 0;

        public Student() { }

        public Student( string name, string birthday, string address, int grade, Int64 phone )
        {
            this.Name     = name;
            this.Birthday = birthday;
            this.Address  = address;
            this.Phone    = phone;
            this.Grade    = grade;
        }

        public int Grade { get; set; }
    }

    class Teacher : Member
    {
        public Teacher() { }

        public Teacher(string name, string birthday, string address, Int64 phone, string subject)
        {
            this.Name     = name;
            this.Birthday = birthday;
            this.Address  = address;
            this.Phone    = phone;
            this.Subject  = subject;
        }

        public string Subject { get; set; }
    }
}
