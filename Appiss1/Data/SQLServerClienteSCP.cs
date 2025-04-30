using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Appiss1.Modelos;

    public class SQLServerClienteSCP : DbContext
    {
        public SQLServerClienteSCP (DbContextOptions<SQLServerClienteSCP> options)
            : base(options)
        {
        }

        public DbSet<Appiss1.Modelos.Cliente> Cliente { get; set; } = default!;
    }
