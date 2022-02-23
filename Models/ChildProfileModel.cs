using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parent_learning_resources_webapi.Models
{
    public class ChildProfileModel
    {
        public int Id { get; set; } 
        public int UserId { get; set; }
        public string? ChildName { get; set; }
        public int ChildAge { get; set; }
        public string? ChildGrade { get; set; }
        
    }
}