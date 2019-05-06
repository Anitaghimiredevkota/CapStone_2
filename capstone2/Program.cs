using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CapstoneTaskList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            string response = "y";

            while (response == "y")
            {
                Console.WriteLine("1.  List tasks");
                Console.WriteLine("2.  Add task");
                Console.WriteLine("3.  Delete task");
                Console.WriteLine("4.  Mark task complete");
                Console.WriteLine("5.  Quit");
                tasks = DummyData();

                Console.WriteLine("select something from the menu!: ");
                switch (Task.CheckNumber())
                {
                    //Printing all of the list.
                    case "1":
                        foreach (Task task in tasks)
                        {
                            Console.WriteLine("----------------------------------------------------");
                            Console.WriteLine("Members: ");
                            foreach (string member in task.members)
                            {
                                Console.WriteLine(member);
                            }
                            Console.WriteLine(task.date, "MM/dd/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture);
                            Console.WriteLine(task.status);
                            Console.WriteLine(task.description);
                        }
                        break;

                    case "2":
                        string newMember = "anita";
                        Task newTask = new Task();
                        while (newMember != "")
                        {

                            Console.WriteLine("Add a member: or press to exist");
                            newMember = Console.ReadLine();
                            newTask.members.Add(newMember);
                        }
                        Console.WriteLine("Plesae enter date");
                        newTask.date = Task.GetDate().ToString();
                        Console.WriteLine("Plesae enter description");
                        newTask.description = Console.ReadLine();
                        tasks.Add(newTask);
                        break;

                    case "3":


                        if (tasks.Remove(GetTask(tasks, "What task would you like to delete")))
                        {
                            Console.WriteLine("task removed");
                        }
                        else
                        {
                            Console.WriteLine("item not found");
                        }

                        break;

                    case "4":
                        Console.WriteLine();

                        int indexofdelete = int.Parse(Console.ReadLine());
                        indexofdelete--;
                        Console.WriteLine("What task have you completed");
                        int indexofMark = int.Parse(Console.ReadLine());
                        indexofMark--;
                        tasks[indexofMark].status = true;
                        break;

                    case "5":
                        response = "n";
                        break;

                    default: break;
                }
                if (response != "n")
                {
                    Console.WriteLine("Would you like to continue?(y/n)");
                    response = Console.ReadLine();
                }
               
                Console.WriteLine("Have a great day!");
            }
        }
        public static Task GetTask(List<Task> list, string message)
        {
            Console.WriteLine(message);
            int indexofdelete = int.Parse(Console.ReadLine());
            indexofdelete--;
            return list[indexofdelete];
        }

        public static List<Task> DummyData()
        {
            List<Task> list = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                Task task = new Task();
                for (int j = 0; j < 3; j++)
                {
                    task.members.Add($"Anita{i + 1}{j + 1}");
                }
                task.date = "08/08/2019";
                task.description = $"Project{i + 1}";
                list.Add(task);
            }
            return list;
        }

    }
}





