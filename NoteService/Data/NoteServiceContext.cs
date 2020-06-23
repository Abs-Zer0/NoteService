using Microsoft.EntityFrameworkCore;
using NoteService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoteService.Data
{
    public class NoteServiceContext : DbContext
    {
        public NoteServiceContext(DbContextOptions<NoteServiceContext> options) : base(options) { }

        public DbSet<Note> Notes { get; set; }
    }
}
