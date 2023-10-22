using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Lab8;

namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee dennis = new Employee(101, "Dennis", "Male", 800500);
            Employee sofia = new Employee(102, "Sofia", "Female", 800800);
            Employee eddie = new Employee(103, "Eddie", "Male", 800700);
            Employee ann = new Employee(104, "Ann", "Female", 700700);
            Employee erik = new Employee(105, "Erik", "Male", 700500);

            Stack<Employee> myStack = new Stack<Employee>();

            myStack.Push(dennis);
            myStack.Push(sofia);
            myStack.Push(eddie);
            myStack.Push(ann);
            myStack.Push(erik);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Display stack + counterdisplay:");

            foreach (Employee emp in myStack)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in the stack = {myStack.Count}");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrive using pop method:");

            while (myStack.Count > 0)
            {
                Employee emp = myStack.Pop();
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in the stack = {myStack.Count}");
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrive using peek method:");

            // Pushade tillbaka in för vi tog ut dom ur stacken i "pop"-koden innan.
            myStack.Push(dennis);
            myStack.Push(sofia);
            myStack.Push(eddie);
            myStack.Push(ann);
            myStack.Push(erik);

            //kollar i stacken med peek-metoden fast i en array istället för lite variation.
            if (myStack.Count >= 3) 
            {
                var array = myStack.ToArray();
                for (int counter = 0; counter < 2; counter++)
                {
                    Console.WriteLine(array[counter]);
                    Console.WriteLine($"Items left in the stack = {myStack.Count}");
                }
            }

            Console.WriteLine("---------------------------------");
            
            //Chece
            bool isEmplyoeeInStack = myStack.Contains(erik);

            if (isEmplyoeeInStack == true)
            { 
                Console.WriteLine($"Erik is in the stack."); 
            }
            else 
            { 
                Console.WriteLine("Erik is not in the stack.");
            }

            Console.WriteLine("---------------------------------");

            //The creation of the list.
            List<EmployeeList> listOfEmplyoees = new List<EmployeeList>();
            
            Console.WriteLine("A list has been created.");

            //New objects, could have made with the Employee class but I wanted to work on coding lists. (creating on Employee would have been easier)
            EmployeeList clara = new EmployeeList() { Id = 503, Name = "Clara", Gender = "Female", Salary = 40 };
            EmployeeList tarzan = new EmployeeList() { Id = 505, Name = "Tarzan", Gender = "Male", Salary = 20 };
            EmployeeList niklas = new EmployeeList() { Id = 504, Name = "Niklas", Gender = "Male", Salary = 20 };
            EmployeeList jessica = new EmployeeList() { Id = 502, Name = "Jessica", Gender = "Female", Salary = 40 };

            //New employees
            listOfEmplyoees.Add(tarzan);
            listOfEmplyoees.Add(niklas);
            listOfEmplyoees.Add(clara);
            listOfEmplyoees.Add(jessica);

            //A boolchecker that prints out the employee named tarzan, if he is added.
            bool isEmployeeInList = listOfEmplyoees.Contains(tarzan);
            if (isEmployeeInList == true) 
            {
                Console.WriteLine("\nTarzan is in the list.\n");
            }
            else
            {
                Console.WriteLine("\nTarzan is not in the list.\n");
            }

            //Prints out the first male in the list.
            EmployeeList result = listOfEmplyoees.Find(vadsomhelst => vadsomhelst.Gender == "Male");
            Console.WriteLine(result);
            Console.WriteLine();

            //Prints out every "male" that inside the list.
            List<EmployeeList> resultet = listOfEmplyoees.FindAll(male => male.Gender == "Male");
            foreach(EmployeeList employee in resultet)
            {
                Console.WriteLine($"{employee}");
            }
            
            Console.ReadKey();
        }
    }
}