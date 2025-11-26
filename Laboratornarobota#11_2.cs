using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornarobota_11_2
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class UserManager
    {
               private List<User> users = new List<User>();
        public void AddUser(User user)
        {
            users.Add(user);
        }
        public User GetUserById(int id)
        {
            return users.FirstOrDefault(u => u.Id == id);
        }
        public List<User> GetAllUsers()
        {
            return users;
        }
        public List<User> RemoveUsersById(int id) 
        {
            users.RemoveAll(u => u.Id == id);
            return users;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManager manager = new UserManager();
            manager.AddUser(new User { Id = 1, Name = "Bogdana" });
            manager.AddUser(new User { Id = 2, Name = "Oleh" });
            User user = manager.GetUserById(1);
            Console.WriteLine($"User ID: {user.Id}, Name: {user.Name}");
            List<User> allUsers = manager.GetAllUsers();
            foreach (var u in allUsers)
            {
                Console.WriteLine($"User ID: {u.Id}, Name: {u.Name}");
            }
        }
    }
}
