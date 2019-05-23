using SelfmanagmentApp.Context;

namespace SelfmanagmentApp.Model
{
    public class Token
    {
        public User User;

        public Token(User User)
        {
            this.User = User;
        }
    }
}