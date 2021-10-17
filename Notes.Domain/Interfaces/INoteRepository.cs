using Noter.Domain;
using Notes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noter.Data.Interfaces
{
    public interface INoteRepository : IGenericRepository<Note>
    {
    }
}
