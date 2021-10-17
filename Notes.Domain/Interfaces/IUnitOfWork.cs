using Noter.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        INoteRepository Notes { get; }
        int Complete();
    }
}
