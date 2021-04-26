using System;

namespace WrappersAndDelegates
{
    public class RedDoodler : IDoodler
    {
        public void DoodleUsingPencil(string text)
        {
            DoodleInRed($"doodling using pencil");
        }

        public void DoodleUsingCrayon(string text)
        {
            DoodleInRed($"doodling using crayon");
        }

        private static void DoodleInRed(string text)
        {
            var save = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = save;
        }
    }
}
