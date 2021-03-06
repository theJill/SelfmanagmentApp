﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfmanagmentApp.Context
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }

        public string TaskOneValue { get; set; }
        public string TaskOneTargetOneValue { get; set; }
        public string TaskOneTargetTwoValue { get; set; }
        public string TaskOneTargetThreeValue { get; set; }
        public string TaskOneTargetWhyValue { get; set; }

        public string TaskTwoValue { get; set; }
        public string TaskTwoTargetOneValue { get; set; }
        public string TaskTwoTargetTwoValue { get; set; }
        public string TaskTwoTargetThreeValue { get; set; }
        public string TaskTwoTargetWhyValue { get; set; }

        public string TaskThreeValue { get; set; }
        public string TaskThreeTargetOneValue { get; set; }
        public string TaskThreeTargetTwoValue { get; set; }
        public string TaskThreeTargetThreeValue { get; set; }
        public string TaskThreeTargetWhyValue { get; set; }

        public string AwardValue { get; set; }

        public Task()
        {

        }
    }
}
