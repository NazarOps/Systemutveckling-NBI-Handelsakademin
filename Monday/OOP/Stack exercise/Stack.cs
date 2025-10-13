using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_exercise
{
    public class Stack
    {
        public string UserInput;

        Stack<string> myStack = new Stack<string>();
        
        bool Menu = true;

        

        public void Start()
        {
            while (Menu)
            {
                Console.WriteLine("                                                          \r\n _____ _           _      _____                 _         \r\n|   __| |_ ___ ___| |_   |   __|_ _ ___ ___ ___|_|___ ___ \r\n|__   |  _| .'|  _| '_|  |   __|_'_| -_|  _|  _| |_ -| -_|\r\n|_____|_| |__,|___|_,_|  |_____|_,_|___|_| |___|_|___|___|\r\n                                                          ");
                Console.WriteLine("1.) Store something in stack");
                Console.WriteLine("2.) Remove from stack");
                Console.WriteLine("3.) Show stack");
                Console.WriteLine("4.) Quit");

                Console.Write("User: ");
                int UserInputConsole = Convert.ToInt32(Console.ReadLine());

                if (UserInputConsole == 1)
                {
                    StoreInStack();
                }

                if (UserInputConsole == 2)
                {
                    UndoStack();
                }

                if (UserInputConsole == 3)
                {
                    ShowStack();
                }

                if (UserInputConsole == 4)
                {
                    break;
                }
            }
            
        }
        public void StoreInStack()
        {
            Console.WriteLine("What would you like to save in stack?");
            UserInput = Console.ReadLine();
            
            myStack.Push(UserInput);
            Console.WriteLine("Your stuff has been pushed into the stack");
        }

        // Undo stack changes

        public void UndoStack()
        {
            Console.WriteLine("Would you like to undo the stack?");
            UserInput = Console.ReadLine();

            if(UserInput == "yes")
            {
                myStack.Pop();
            }
        }

        public void ShowStack()
        {
            myStack.Count();
        }
    }
}
