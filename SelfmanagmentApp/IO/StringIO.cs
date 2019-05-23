using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SelfmanagmentApp.IO
{
    public static class StringIO
    {
        public static string GetSHA256(string input)
        {
            string output = "";
            SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(input)).ToList().ForEach(f => output += f);
            return output;
        }
    }
}
