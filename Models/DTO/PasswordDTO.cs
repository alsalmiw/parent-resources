using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parent_learning_resources_webapi.Models.DTO
{
    public class PasswordDTO
    {
        public string? Salt { get; set; }
        public string? Hash { get; set; }
    }
}