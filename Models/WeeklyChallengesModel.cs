using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace parent_learning_resources_webapi.Models
{
    public class WeeklyChallengesModel
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public int WeekNumber { get; set; }
        public DateOnly DateEntered { get; set; }
        public string? SpellingWords { get; set; }
        public string? MathProblems { get; set; }
    }
}