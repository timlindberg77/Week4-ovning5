using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Week4_ovning5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Förstå LIFO-principen(Last In, First Out) med Stack<string>.
            Stack<string> TextInmatning = new Stack<string>();
            bool KeepRunning = true;
            while (KeepRunning)
            {
                //💻 Uppgift:
                //Skapa en konsolapplikation som lagrar textinmatningar med en “ångra”-funktion.
                //I menyn ska användaren kunna:
                //✏️ Lägga till text(Push)
                //↩️ Ångra senaste inmatningen(Pop)
                //👁️ Visa aktuell text(allt som finns i stacken)
                Klasser.MenuMethod();
                string UserMenyInput = Console.ReadLine()!;
                if (Klasser.IfStackIsEmpty(UserMenyInput, TextInmatning))
                continue;

                switch (UserMenyInput)
                {
                    case "1":
                        //✏️ Lägga till text(Push)
                        Klasser.AddText(TextInmatning);
                        Klasser.ClearText();
                        break;

                    case "2":
                        //Skriv ut stacken med foreach för att se ordningen.
                        Klasser.RegretText(TextInmatning);
                        Klasser.ClearText();
                        break;

                    case "3":
                        //👁️ Visa aktuell text(allt som finns i stacken)
                        Klasser.ShowAllStacks(TextInmatning);
                        Klasser.ClearText();
                        break;
                    case "4":
                        KeepRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{UserMenyInput} is not an option");
                        break;


                    
                }
            }
        }
    }
}
