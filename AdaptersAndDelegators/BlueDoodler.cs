using System;

namespace WrappersAndDelegates
{
    public class BlueDoodler : IDoodler
    {
        public void DoodleUsingPencil(string text)
        {
            throw new NotImplementedException();
        }

        public void DoodleUsingCrayon(string text)
        {
            DoodleInBlue($"doodling using crayon");
        }

        private static void DoodleInBlue(string text)
        {
            var save = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ForegroundColor = save;
        }
    }
}
