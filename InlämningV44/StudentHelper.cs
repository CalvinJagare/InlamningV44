using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningV44
{
    internal class StudentHelper
    {
        StudentDbContext dbContext = new StudentDbContext();
        MenuManager menuManager = new MenuManager();
        public void addStudent()
        {
            string firstName = menuManager.getStringInput("Förnamn");
            string lastName = menuManager.getStringInput("Efternamn");
            string city = menuManager.getStringInput("Stad");
            
            Student newStudent = new Student(firstName, lastName, city);
            dbContext.Add(newStudent);
            
            trySave("Student sparad!");
        }
        public void changeStudent()
        {
            Console.Write("Ange ID på student du vill ändra information på: ");
            int.TryParse(Console.ReadLine(), out int id);
            var change = dbContext.Students.Where(s => s.StudentId == id).FirstOrDefault<Student>();
            if (change != null)
            {
                bool selecting = true;
                while (selecting == true)
                {
                    menuManager.printEditMenu();
                    int.TryParse(Console.ReadLine(), out int userInput);                   
                    switch (userInput)
                    {
                        case 1:
                            Console.Clear();
                            string newFirstName = menuManager.getStringInput("det ändrade förnamnet");                          
                            change.FirstName = newFirstName;
                            trySave("Förnamn ändrat!");
                            break;
                        case 2:
                            Console.Clear();
                            string newSecondName = menuManager.getStringInput("det ändrade efternamnet");
                            change.LastName = newSecondName;
                            trySave("Efternamn ändrat!");
                            break;
                        case 3:
                            Console.Clear();
                            string newCity = menuManager.getStringInput("den nya staden");
                            change.City = newCity;
                            trySave("Stad ändrat!");
                            break;
                        case 4:
                            selecting = false;
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Ange giltigt val!");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Student ID ej giltigt");
            }
        }
        public void listStudents()
        {
            if (dbContext.Students != null)
            {
                foreach (Student student in dbContext.Students)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Inga studenter i listan!");
            }
        }

        public void trySave(string message)
        {
            try
            {
                dbContext.SaveChanges();
                Console.WriteLine(message + "\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
