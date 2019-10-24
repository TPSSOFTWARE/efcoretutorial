using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreTutorial.DAL
{
    public class EfCoreContext:DbContext
    {
       public EfCoreContext(DbContextOptions<EfCoreContext> options) : base(options)
        {

        }
    }
}
