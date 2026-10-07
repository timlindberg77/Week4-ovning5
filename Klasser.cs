using System;
using System.Collections.Generic;
using System.Text;

namespace Week4_ovning5
{
    public class Klasser
    {
        public static void AddText(Stack<string> TextInmatning)
        {
            //✏️ Lägga till text(Push)
            Console.WriteLine($"Add Text");
            string PushUserInPut = Console.ReadLine()!;
            TextInmatning.Push(PushUserInPut);
        }

        public static void RegretText(Stack<string> TextInmatning)
        {
            //↩️ Ångra senaste inmatningen(Pop)
            Console.WriteLine($"Removing: {TextInmatning.Peek()}");
            string FirstText = TextInmatning.Pop();
            //Efter en “ångra”-åtgärd, visa hur texten ser ut nu.
            if (TextInmatning.Count > 0)
            {
                Console.WriteLine($"Currently top of the Stack {TextInmatning.Peek()}");
            }
            else
            {
                Console.WriteLine("Stack is empty");
            }
        }

        public static void ShowAllStacks(Stack<string> TextInmatning)
        {
            //👁️ Visa aktuell text(allt som finns i stacken)
            //Skriv ut stacken med foreach för att se ordningen.
            foreach (var Stacks in TextInmatning)
            {
                Console.WriteLine(Stacks);
            }

        }

        public static void MenuMethod()
        {

            //Skapa en konsolapplikation som lagrar textinmatningar med en “ångra”-funktion.
            //I menyn ska användaren kunna:
            Console.WriteLine($"Welcome \n" +
                $"1: To add text\n" +//✏️ Lägga till text(Push)
                $"2: To remove text\n" +//↩️ Ångra senaste inmatningen(Pop)
                $"3: To show all text\n" +//👁️ Visa aktuell text(allt som finns i stacken)
                $"4: Close program");
        }

        public static void ClearText()
        {
            Console.WriteLine($"Press enter to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static bool IfStackIsEmpty (string UserMenuInput, Stack<string> TextInmatning)
        {
            if ((UserMenuInput == "2" || UserMenuInput == "3") && TextInmatning.Count == 0)
                {
                Console.WriteLine($"Stack is empty");
                return true;
                }
            return false;
        }
    }
}
