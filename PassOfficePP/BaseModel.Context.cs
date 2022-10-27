namespace PassOfficePP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PassOfficePPDBEntities : DbContext
    {
        private static PassOfficePPDBEntities _context;

        public PassOfficePPDBEntities()
            : base("name=PassOfficePPDBEntities")
        {
        }

        public static PassOfficePPDBEntities GetContext()
        {
            if (_context == null)
            {
                _context = new PassOfficePPDBEntities();
            }

            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AccessLevel> AccessLevel { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Visitor> Visitor { get; set; }
        public virtual DbSet<WorkPlace> WorkPlace { get; set; }
        public virtual DbSet<WorkSchedule> WorkSchedule { get; set; }
    }
}
