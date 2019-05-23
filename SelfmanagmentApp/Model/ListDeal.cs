using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SelfmanagmentApp.Context
{
    public class ListDeal
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ListDealID { get; set; }

        public string Value { get; set; }

        public int UserID { get; set; }
    }
}
