using System;
using System.Linq;

namespace EntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using AppContext db = new AppContext();
            User user1 = new User { Name = "Tom", Age = 33 };
            User user2 = new User { Name = "Ann", Age = 35 };

            db.Users.Add(user1);
            db.Users.Add(user2);
            db.SaveChanges();

            var users = db.Users.ToList();

            foreach (var u in users)
                Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
        }
    }
}
