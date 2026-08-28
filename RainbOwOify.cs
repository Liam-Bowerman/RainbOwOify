using System.Threading.Tasks;
using Rainbows;
using Owoify;
namespace RainbOwOs
{
    public class RainbOwOify
    {
        public static void Write(string s)
        {
            Rainbowify.Write(Owoifier.Owoify(s));
        }
        public static void WriteLine(string s)
        {
            Rainbowify.WriteLine(Owoifier.Owoify(s));
        }
        public static void Write(string s, bool uwu)
        {
            bool isCool = uwu;
            Rainbowify.Write(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uvu));
        }
        public static void WriteLine(string s, bool uwu)
        {
            bool isCool = uwu;
            Rainbowify.WriteLine(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uvu));
        }
    }
}