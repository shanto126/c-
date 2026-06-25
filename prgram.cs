using System;
namespace shanto
{
   class grade
    {
        
        char gr = Console.ReadKey().KeyChar;
        public void show_comment()
        {
            switch (gr)
            {
                case 'A':
                    Console.WriteLine("\nExcelent");
                    break;
                case 'B':
                    Console.WriteLine("\nGood");
                    break;
                case 'C':
                    Console.WriteLine("\nAvarage");
                    break;
                case 'D':
                    Console.WriteLine("\nPoor");
                    break;
                case 'F':
                    Console.WriteLine("\nVery Poor");
                    break;
                default:
                    Console.WriteLine("\nInvalid Grade");
                    break;
            }
        }
        class program
        {
            static void Main ()
            {
                Console.Write("Enter your grade (A-F): ");
                grade mygrade = new grade();
                mygrade.show_comment();
            }
            
        }
    }
}
