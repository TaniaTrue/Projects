namespace MasterpieceStore.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MasterpieceStore.Domain.Concrete.AppIdentityDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MasterpieceStore.Domain.Concrete.AppIdentityDbContext";
        }

        protected override void Seed(MasterpieceStore.Domain.Concrete.AppIdentityDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
