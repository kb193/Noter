using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; } = DateTime.Today;
        public DateTime LastAmended { get; set; } = DateTime.Today;
        public int LastAmendedBy { get; set; }
        public bool Started { get; set; }
        public bool Completed { get; set; }

    }
}
