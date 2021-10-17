using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Noter.Data;
using Noter.Domain;

namespace Noter.Data
{
    public class NoteContext : DbContext
    {
        public DbSet<Note> Notes { get; set; }
        public string DbPath { get; private set; }

        public NoteContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}NotesDB.db";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
     => options.UseSqlite($"Data Source={DbPath}");

    }
}
