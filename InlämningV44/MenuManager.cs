using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InlämningV44
{
    public class MenuManager
    {
        public void printMainText()
        {
            Console.WriteLine("Välj ett alternativ:\n");
            Console.WriteLine("1. Registrera ny elev");
            Console.WriteLine("2. Ändra en student");
            Console.WriteLine("3. Lista alla studenter");
            Console.WriteLine("4. Avsluta programme");
        }

        public void menuSelector()
        {
            StudentHelper studentHelper = new StudentHelper();
            bool run = true;
            while (run == true)
            {
                printMainText();
                int.TryParse(Console.ReadLine(), out int userInput);               
                    switch (userInput)
                    {
                        case 1:
                            //Reg ny student
                            Console.Clear();
                            studentHelper.addStudent();
                            break;
                        case 2:
                            //Ändra student
                            Console.Clear();
                            studentHelper.changeStudent();
                            break;
                        case 3:
                            //Lista studenter
                            Console.Clear();
                            studentHelper.listStudents();
                            break;
                        case 4:
                            //avsluta program
                            run = false;
                            break;
                    default:
                        Console.WriteLine("Välj giltigt alternativ");
                        break;
                    }
            }
        }

        public void printEditMenu()
        {
            Console.WriteLine("Vad vill du ändra?");
            Console.WriteLine("1. Förnamn");
            Console.WriteLine("2. Efternamn");
            Console.WriteLine("3. City");
            Console.WriteLine("4. Gå tillbaka till huvudmeny");
        }

        public string getStringInput(string message)
        {
            string? input = null;
            while (string.IsNullOrEmpty(input))
            {
                Console.Write($"Lägg in {message}: ");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    Console.Clear();
                    Console.WriteLine("Kan ej vara tom, försök igen!");                    
                }
            }
            return input;
        }
    }
}
