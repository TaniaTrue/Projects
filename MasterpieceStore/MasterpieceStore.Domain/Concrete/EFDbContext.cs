using MasterpieceStore.Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterpieceStore.Domain.Concrete
{
   public class EFDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<Product> Products { get; set; }
    }
}
