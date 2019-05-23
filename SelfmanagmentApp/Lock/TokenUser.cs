using SelfmanagmentApp.Context;
using SelfmanagmentApp.Model;

namespace SelfmanagmentApp.Lock
{
    public static class TokenUser
    {
        public static Token Token { get; set; }

        public static void CreateToken(User user)
        {
            if (Token == null)
            {
                Token = new Token(user);
            }
        }
    }
}