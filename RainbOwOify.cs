using System.Threading.Tasks;
using Rainbows;
using Owoify;
namespace RainbOwOs
{
    public class RainbOwOify
    {
        /// <summary>
        /// A function used to write rainbow colored and uwu speach text in the last active line in the terminal. 
        /// </summary>
        /// <param name="s">A string whose letters will be changed to sound like uwu speach as well as colored like a rainbow.</param>
        public static void Write(string s)
        {
            Rainbowify.Write(Owoifier.Owoify(s));
        }
        /// <summary>
        /// A function used to write rainbow colored and uwu speach text in a new line in the terminal. 
        /// </summary>
        /// <param name="s">A string whose letters will be changed to sound like uwu speach as well as colored like a rainbow.</param>
        public static void WriteLine(string s)
        {
            Rainbowify.WriteLine(Owoifier.Owoify(s));
        }

        public static void Write(string s, bool uwu)
        {
            if (uwu == false)
            {
                Rainbowify.Write(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uwu));
            }
            else if (uwu == true)
            {
                Rainbowify.Write(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uvu));
            }
            else
            {
                if (uwu == false)
            {
                Rainbowify.Write(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uwu));
            }
            }
        }

        public static void WriteLine(string s, bool uwu)
        {
            bool isCool = uwu;
            Rainbowify.WriteLine(Owoifier.Owoify(s, Owoifier.OwoifyLevel.Uvu));
        }
        //
        public static string Store(string s)
        {
            string returnS = Rainbowify.Store(Owoifier.Owoify(s));
            return returnS;
        }
    }
}