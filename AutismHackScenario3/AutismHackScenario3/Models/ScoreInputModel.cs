using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutismHackScenario3.Models
{

    public class ScoreInputModel
    {
        [Display(Name ="Age", Description ="Age")]
        public string Age { get; set; }

        [Display(Name = "DaysToMastery")]
        public string DaysToMastery { get; set; }

        [Display(Name = "Domain")]
        public string Domain { get; set; }

        [Display(Name = "SkillTitle")]
        public string SkillTitle { get; set; }

        [Display(Name = "SkillLevel")]
        public string SkillLevel { get; set; }

        [Display(Name = "DomainOrdinal")]
        public string DomainOrdinal { get; set; }

        [Display(Name = "SkillOrdinal")]
        public string SkillOrdinal { get; set; }

        [Display(Name = "GuardianCount")]
        public string GuardianCount { get; set; }
    }
}