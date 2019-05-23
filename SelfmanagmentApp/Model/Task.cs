using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfmanagmentApp.Context
{
    public class Task
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }

        public string TaskOneValue { get; set; }

        public string TaskTwoValue { get; set; }

        public string TaskThreeValue { get; set; }

        public string LearningValue { get; set; }

        public string ThanksValue { get; set; }

        public string UpValue { get; set; }

        public Task()
        {
            TaskOneValue = "1";
            TaskTwoValue = "1";
            TaskThreeValue = "1";
            LearningValue = "1";
            ThanksValue = "1";
            UpValue = "1";
        }
    }
}
