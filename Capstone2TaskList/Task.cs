using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2TaskList
{
    class Task
    {
        public string TaskOwner { get; set; }
        public string TaskName { get; set; }
        public DateTime DueDate { get; set; }
        public bool completeTask { get; set; }

        //Constructor
        public Task(string taskOwner, string taskName)
        {
            TaskOwner = taskOwner;
            TaskName = taskName;
            completeTask = false;
            DueDate = DateTime.Now.AddDays(14);
        }

        //no ; bc it's a method (it stands alone)
        //List of type task
        public static void DisplayList(List<Task> TaskList)
        {
            Console.WriteLine("Done?\t\tDue Date\t\tTeam Member\tDescription");
            //display each task on a new line
            foreach (Task item in TaskList)
            {
                Console.WriteLine($"{item.completeTask}\t\t {item.DueDate:MM/dd/yyyy}\t\t{item.TaskOwner}\t\t{item.TaskName}");

            }
            Console.WriteLine();
        }

        //returns a task object
        public static Task CreateTask()
        {
            //take input for the new task
            Console.WriteLine("Team Member Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Description");
            string description = Console.ReadLine();
            //return the new task
            return new Task(name, description);
        }

        public static List<Task> DeleteTask(List<Task> TaskList)
        {
            //display each task on a new line
            int count = 1;
            foreach(Task item in TaskList)
            {
                Console.WriteLine($"{count}\t\t{item.TaskOwner}\t\t{item.TaskName}");
                count++;
            }
            //take input from user
            Console.WriteLine("What task do you want to delete");

            //Starting at 1 for user/ -1 is to retrieve index
            int input = int.Parse(Console.ReadLine())-1;
            //initializing input as a parsed value of what the user puts into the Console
            //remove task from list based on user's input
            TaskList.RemoveAt(input);
            return TaskList;
        }

        public static List<Task> CompleteTask(List<Task> TaskList)
        {
            //display each task on a new line
            int count = 1;
            foreach (Task item in TaskList)
            {
                Console.WriteLine($"{count}\t\t{item.TaskOwner}\t\t{item.TaskName}");
                count++;
            }
            //take input from user
            Console.WriteLine("What task do you want to mark complete");

            //Starting at 1 for user/ -1 is to retrieve index
            int input = int.Parse(Console.ReadLine()) - 1;
            //initializing input as a parsed value of what the user puts into the Console
            //Referencing an index of the List
            //change completion status of task based on user input
            TaskList[input].completeTask = true;
            return TaskList;
        }
    }
}
