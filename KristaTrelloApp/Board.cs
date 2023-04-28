using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KristaTrelloApp
{
    public class Board
    {
        public List<Task> ToDo { get; set; }
        public List<Task> InProgress { get; set; }
        public List<Task> Done { get; set; }

        public bool DeleteTask(string name)
        {
            for (int i = 0; i <= ToDo.Count - 1; i++)
            {
                if (ToDo[i].Name == name)
                {
                    ToDo.RemoveAt(i);
                    return true;
                }
            }


            int tasksRemoved = InProgress.RemoveAll(x => x.Name == name);
            if (tasksRemoved > 0)
            {
                return true;
            }

            tasksRemoved = Done.RemoveAll(x => x.Name == name);
            if (tasksRemoved > 0)
            {
                return true;
            }

            return false;
        }

        public string MoveTask(string name, string status)
        {
            List<Task> allTasks = ToDo.Concat(InProgress).Concat(Done).ToList();
            Task taskToMove = ToDo.Find(x => x.Name == name);

            if (DeleteTask(name) == true)
            {
                if (status == nameof(ToDo))
                {
                    ToDo.Add(taskToMove);
                    return "Successfully moved";
                }
                else if (status == nameof(InProgress))
                {
                    InProgress.Add(taskToMove);
                    return "Successfully moved";
                }
                else if (status == nameof(Done))
                {
                    Done.Add(taskToMove);
                    return "Successfully moved";

                }
                else
                {
                    return "That status wasn't found.";
                }

            }
            return "That task wasn't found";

        }
    }


}
