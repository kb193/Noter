using Noter.Data.Interfaces;
using Noter.Data.Repositories;
using Notes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public INoteRepository Notes {get; private set;}
        private readonly NoteContext _context;

        public UnitOfWork(NoteContext context)
        {
            _context = context;
            Notes = new NoteRepository(_context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
          _context.Dispose();
        }
    }
}
