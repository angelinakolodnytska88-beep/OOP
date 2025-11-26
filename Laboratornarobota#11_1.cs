using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_11_1
{
    class Task
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
    }
    class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        public void AddTask(Task task) 
        {
            tasks.Add(task);
        }
        public void RemoveTask(int taskId)
        {
            tasks.RemoveAll(t => t.TaskID == taskId);
        }
        public List<Task> GetAllTasks()
        {
            return tasks;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskManager myobj = new TaskManager();
            myobj.AddTask(new Task { TaskID = 1, Description = "Task 1" });
            myobj.AddTask(new Task { TaskID = 2, Description = "Task 2" });
            foreach (var task in myobj.GetAllTasks())
            {
                Console.WriteLine($"TaskID: {task.TaskID}, Description: {task.Description}");
            }
        }
    }
}
