using System;

namespace dotnetDisassembler
{
    public abstract class Person
    {
        public string name, gender, address;
        public DateTime dob;
        public long contactno;

        public Person(string address1)
        {
            address = address1;
        }

        public abstract void Acceptdetails();

        public abstract void Printdetails();

        public int CalculateAge(DateTime dob)
        {
            int age = 0;
            age = DateTime.Now.Year - dob.Year;
            if (DateTime.Now.DayOfYear < dob.DayOfYear)
                age = age - 1;

            return age;
        }
    }

    public class Student : Person
    {
        public int rollno, gradeno, sub1, sub2, sub3, average, total, result;

        public Student(string address1, int rollno1) : base(address1)
        {
            rollno = rollno1;
        }

        public override void Acceptdetails()
        {
            Console.WriteLine("Enter the name of the person:");
            name = Console.ReadLine();

            Console.WriteLine("Enter the dob of the person (yyyy-MM-dd):");
            dob = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the gender of the person:");
            gender = Console.ReadLine();

            Console.WriteLine("Enter the contact of the person:");
            contactno = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("Enter score in maths:");
            sub1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter score in science:");
            sub2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter score in History:");
            sub3 = Convert.ToInt32(Console.ReadLine());
        }

        public void Calculate()
        {
            total = sub1 + sub2 + sub3;
            Console.WriteLine("Total of the person is: " + total);

            average = (sub1 + sub2 + sub3) / 3;
            Console.WriteLine("Average of three subjects: " + average);

            if (total > 40)
            {
                Console.WriteLine("Successfully passed the exam :) ");
            }
            else
            {
                Console.WriteLine("Failed :(");
            }
        }

        public override void Printdetails()
        {
            Console.WriteLine("Details of the person:");
            Console.WriteLine(name + "\n " + dob.ToString("yyyy-MM-dd") + "\n " + gender + "\n " + address + " \n" + contactno);
            Console.WriteLine("Details of the student:");
            Console.WriteLine(rollno + " \n " + sub1 + "\n " + sub2 + "\n " + sub3);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Coimbatore", 112);
            s.Acceptdetails();
            s.Printdetails();
            int age = s.CalculateAge(s.dob);
            Console.WriteLine("Age: " + age);
        }
    }
}


