using System;
using System.Collections.Generic;

namespace KristaTrelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User> 
            { 
            new User { FirstName="Randy", LastName="Zilinski"},
            new User { FirstName="Krista", LastName="Anderson"}
            };

            Task task = new Task
            {
                Name = "Fuck Bitches",
                Comment = "Get Money",
                AssignedUsers = users,
                DueDate = DateTime.Now
            };
            
            Console.WriteLine(task.FormatTask());
        }
    }
}
