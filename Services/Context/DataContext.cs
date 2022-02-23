using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using parent_learning_resources_webapi.Models;

namespace parent_learning_resources_webapi.Services.Context
{
    public class DataContext: DbContext
    {
        public DbSet<UserModel> UserInfo {get; set;}
        public DbSet<ChildProfileModel> ChildProfile {get; set;}
        public DbSet <WeeklyChallengesModel> WeeklyChallenges {get; set;}

        public DataContext (DbContextOptions options) : base(options){}

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
        }
    }
}