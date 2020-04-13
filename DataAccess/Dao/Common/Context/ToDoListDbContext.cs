using Microsoft.EntityFrameworkCore;
using ToDoListWebAPI.Data.Common.ApiSession;

namespace ToDoListWebAPI.DataAccess.Dao.Common.Context
{
    class ToDoListDbContext : DbContext
    {
        public DbSet<Data.Entity.Account> Accounts { get; set; }

        public DbSet<Data.Entity.AccountStatus> AccountStatuses { get; set; }

        public DbSet<Data.Entity.Alert> Alerts { get; set; }

        public DbSet<Data.Entity.AlertStatus> AlertStatuses { get; set; }

        public DbSet<Data.Entity.Category> Categories { get; set; }

        public DbSet<Data.Entity.Note> Notes { get; set; }

        public DbSet<Data.Entity.NoteStatus> NoteStatuses { get; set; }

        public DbSet<Data.Entity.NoteTask> NoteTasks { get; set; }

        public DbSet<Data.Entity.NoteType> NoteTypes { get; set; }

        public DbSet<Data.Entity.Notification> Notifications { get; set; }

        public DbSet<Data.Entity.NotificationStatus> NotificationStatuses { get; set; }

        public DbSet<Data.Entity.Share> Shares { get; set; }

        public DbSet<Data.Entity.ShareStatus> ShareStatuses { get; set; }

        public DbSet<Data.Entity.User> Users { get; set; }

        public DbSet<Data.Entity.UserGroup> UserGroups { get; set; }

        public DbSet<Data.Entity.UserGroupStatus> UserGroupStatuses { get; set; }

        public DbSet<Data.Entity.UserStatus> UserStatuses { get; set; }

        public DbSet<Data.Entity.UsersUserGroup> UsersUserGroups { get; set; }

        public DbSet<Data.Common.ApiSession.ApiSession> ApiSessions { get; set; }

        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data.Entity.Account>()
                .HasIndex(acc => acc.Email)
                .IsUnique();

            modelBuilder.Entity<Data.Entity.User>()
                .HasIndex(user => user.UserName)
                .IsUnique();

            modelBuilder.Entity<Data.Common.ApiSession.ApiSession>()
                .HasIndex(session => session.AuthToken)
                .IsUnique();
        }
    }
}
