using Firstproject1.Models;
using Microsoft.EntityFrameworkCore;

namespace Firstproject1.Data
{
    public class ApplicationDbcontext :DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options):base(options)
        {
            
        }
        public DbSet<MembershipStudent> MembershipStudents { get; set; }    
    }
}
