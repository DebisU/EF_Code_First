namespace EF_Code_First_Try.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EF_Code_First_Try.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            SetSqlGenerator("MySql.Data.MySqlClient", new MySql.Data.Entity.MySqlMigrationSqlGenerator());

        }

        protected override void Seed(EF_Code_First_Try.Context context)
        {
        }
    }
}
