using System;
using System.Collections.Generic;
using System.Text;

namespace KristaTrelloApp
{
    class Task
    {
        public string Name { get; set; }
        public string Comment { get; set; }
        public List<Subtask> Subtasks { get; set; }
        public bool IsArchieved { get; set; }
        public List<User> AssignedUsers { get; set; }
        public DateTime DueDate { get; set; }
        public string Label { get; set; }


        public void AssignUser (User x)
        {
            AssignedUsers.Add(x);
        }

        public string FormatTask () //show name, comment, assigned users, due date
        {
            string formattedTask = $"The task name:{Name} Comment: {Comment} Users Assigned: ";
            foreach(User user in AssignedUsers)
            {
                formattedTask += $"{user.FirstName} {user.LastName}, ";

            }
            formattedTask += DueDate;
            return formattedTask;
        }

        //method that will add a task to a boards to do column

        public void AddToDo(Board b)
        {
            b.ToDo.Add(this);
        }

            


    }
}
