using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfmanagmentApp.Context
{
    public class PlaningUser
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlaningUserID{ get; set; }

        public string NamePlaning { get; set; }

        public string TimePlaning { get; set; }
        
        public bool StatusPlaning { get; set; }

        public int UserID { get; set; }

        public PlaningUser()
        {

        }
    }
}
