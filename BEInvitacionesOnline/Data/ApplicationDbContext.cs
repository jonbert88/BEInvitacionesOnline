using BEInvitacionesOnline.Models;
using Microsoft.EntityFrameworkCore;

namespace BEInvitacionesOnline.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {

        }

        public DbSet<Profile> Profiles { get; set; }
        public DbSet<User> Users { get;set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<TypesTemplate> TypeTemplates { get; set;}   
        public DbSet<Template> Templates { get; set; }
        public DbSet<Information> Informations { get; set; }
        public DbSet<Invitation> Invitations { get;set; }
    }
}
