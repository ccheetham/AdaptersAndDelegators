using System;

namespace AdaptersAndDelegators
{
    public class RedDoodler : IDoodler
    {
        public void DoodleUsingPencil(string text)
        {
            var save = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ForegroundColor = save;
        }

        public void DoodleUsingCrayon(string text)
        {
            throw new NotImplementedException();
        }
    }
}
