using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12
{
    class Program
    {
        static List<Person> people = new List<Person>()
        {

            //student order string degreeProgram, int year, double fee, string name, string address)
            //staff order string school, double pay, string name, string address
            new Student("Dentistry", 2008, 8889.98, "P. Sherman", "42 Wallaby Way Sydney"),
            new Staff("Hogwarts", 120000, "S.Black", "12 Grimmauld Place"),
            new Staff("Project Mayhem", 0, "Tyler Durden", "420 Paper St."),
            new Student("Quantum Physics", 2021, 9823.23, "Stewie Griffin", "31 Spooner Street"),
            new Student("Boating License", 2001, 55, "SpongeBob SquarePants","124 Conch Street")};


        static void Main(string[] args)
        {
            Pathway();
            Console.ReadKey();
        }

        static void Pathway()
        {
            Console.WriteLine("What would you like to do? Press:");
            Console.WriteLine("1 to Add a Student\n2 to Add a Staff Member\n3 to Show the List\n4 To Update Staff" +
                "\n5 To Update Student\n6 to Delete a Student\n7 to Delete a Staff member\n8 to Leave");
            int choosePath = int.Parse(Console.ReadLine());
            if (choosePath == 1)
            {
                //add student
                AddStudent();

            }
            if (choosePath == 2)
            {// add staff memeber 

            }
            if (choosePath == 3)
            {
                //print list 
                PrintMe();
            }
            if (choosePath == 4)
            {
                //update staff 

            }
            if (choosePath == 5)
            {// update student 

            }
            if (choosePath ==6)
            {
                //Delete a student
            }
            if (choosePath == 7)
            {
                // delete a staff 

            }
            if (choosePath == 8)
            {
                //leave 
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
            }
            Looper();
        }

        static void AddStudent()
        {
            Console.WriteLine("Would you like to add a student? y/n");
            string addStudinput = Console.ReadLine().ToLower();

            if (addStudinput == "yes" || addStudinput == "y")
            {
                //student order string degreeProgram, int year, double fee, string name, string address)
                Console.WriteLine("What is the students name?");
                string studNameInput = Console.ReadLine();
                Console.WriteLine($"What is {studNameInput}\'s address?");
                string studAddressInput = Console.ReadLine();
                Console.WriteLine($"What is {studNameInput}\'s program or degree?");
                string studprogInput = Console.ReadLine();
                Console.WriteLine($"what is {studNameInput}\'s graduating year?");
                int studyearinput = int.Parse(Console.ReadLine());
                Console.WriteLine($"What is {studNameInput}\'s tuition cost?");
                double studfeeInput = double.Parse(Console.ReadLine());
               people.Add(new Student(studprogInput, studyearinput, studfeeInput, studNameInput, studAddressInput ));
                Console.WriteLine($"{studNameInput} has been added successfully!");
                Console.WriteLine();
                Pathway();

            }
            else if (addStudinput == "no" || addStudinput == "n")
            {
                Pathway();
            }
            else
            {
                Console.WriteLine("That was nonsense, again");
                AddStudent();
            }

        }

        static void AddStaff()
        {

        }

        static void UpdateStaff()
        {
        }

        static void UpdateStudent()
        {

        }

        static void DeleteStudent()
        {

        }

        static void DeleteStaff()
        {

        }   

        static void PrintMe()
        {
            foreach (Person p in people)
            {
                Console.WriteLine(p.ToString());
                Console.WriteLine();
            }
        }

        static void Looper()
        {
            Console.WriteLine("Continue? y/n: ");
            string goAgain = Console.ReadLine().ToLower();
            if (goAgain == "yes" || goAgain == "y")
            {

            }
            else if (goAgain == "no" || goAgain == "n")
            {
                Console.WriteLine("Goodbye");
                Environment.Exit(0);
               
            }
            else
            {
                Console.WriteLine("That was pure nonsense");
                Looper();
            }
        }
    }
}
