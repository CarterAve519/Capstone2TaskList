using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Task Manager!");

            List<Task> TaskList = new List<Task>();

            TaskList.Add(new Task("Brian", "Update calendar"));
            TaskList.Add(new Task("Pai'Tyn", "Alpabatize files"));
            TaskList.Add(new Task("Kylie", "Order supplies"));
            TaskList.Add(new Task("Karter", "Perform student count"));
            TaskList.Add(new Task("Kennedi", "Start new client list"));


            while (true)
            {
                //display list of options
                string input = showMenu();
                if (input == "1")
                {
                    //display list of tasks and their information
                    Task.DisplayList(TaskList);
                }
                //what conditions need to be met
                else if(input == "2")
                {
                    //create a new task and add it to the list
                    Task ToAdd = Task.CreateTask();
                    TaskList.Add(ToAdd);
                }
                else if(input == "3")
                {
                    //delete a task based on user input
                    TaskList = Task.DeleteTask(TaskList);
                }
                else if(input == "4")
                {
                    //complete a task based on user input
                    TaskList = Task.CompleteTask(TaskList);
                   
                }
                else if(input == "5")
                {
                    //exit program
                    break;
                }
            }

            Console.WriteLine("Goodbye!");


        }

        static string showMenu()
        {
            Console.WriteLine("1. List tasks\n2. Add task\n3. Delete task\n4. Mark task complete\n5. Quit\n" );

            Console.WriteLine("What do you want to do?");

            string input = Console.ReadLine();
            return input;
        }
         
        

        
    }
}
