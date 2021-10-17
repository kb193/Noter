using Noter.Data.Interfaces;
using Noter.Domain;
using Notes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter.Data.Repositories
{
    public class NoteRepository : GenericRepository<Note>, INoteRepository
    {
        private readonly NoteContext context;

        public NoteRepository(NoteContext context) : base(context)
        {
            this.context = context;
        }
    }
}
