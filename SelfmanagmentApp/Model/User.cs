using SelfmanagmentApp.IO;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Media.Imaging;

namespace SelfmanagmentApp.Context
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Hashpass { get; set; }

        public string Email { get; set; }

        public byte[] Avatar { get; set; }

        public Task Task { get; set; }

        private User()
        {

        }

        public User(string Name, string Pass, string Email, BitmapImage Avatar)
        {
            this.Name = Name;
            this.Hashpass = StringIO.GetSHA256(Pass);
            this.Email = Email;
            this.Avatar = ImageIO.BitmapImageToByte(Avatar);
            Task = new Task();
        }
    }
}
