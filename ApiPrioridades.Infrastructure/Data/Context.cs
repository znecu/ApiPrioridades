using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiPrioridades.Core.Entities;

namespace ApiPrioridades.Infrastructure.Data;

public class Context : DbContext
{
    public Context(DbContextOptions options) : base(options){}

    public DbSet<Prioridades> Prioridades { get; set; }
}
