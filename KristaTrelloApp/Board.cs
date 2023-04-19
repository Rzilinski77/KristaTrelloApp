using System;
using System.Collections.Generic;
using System.Text;

namespace KristaTrelloApp
{
    class Board
    {
        public List<Task> ToDo { get; set; }
        public List<Task> InProgress { get; set; }
        public List<Task> Done { get; set; }
    }
}
