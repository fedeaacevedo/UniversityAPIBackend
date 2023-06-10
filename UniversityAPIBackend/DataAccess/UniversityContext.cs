using Microsoft.EntityFrameworkCore;
using UniversityAPIBackend.Models.DataModels;

namespace UniversityAPI.DataAccess
{
    public class UniversityContext : DbContext
    {
        public UniversityContext(DbContextOptions<UniversityContext> options) : base(options) 
        {
        }


        //TODO. Add DbSet
        public DbSet<User>? Users { get; set; }


    }






}
