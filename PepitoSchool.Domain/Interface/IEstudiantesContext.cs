using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PepitoSchool.Domain.Interface
{
    public interface IEstudiantesContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }

        public int SaveChanges();
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
