using System;

namespace WrappersAndDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            using var doodler = new NotebookDoodler(new DoodlerDelegate());
            doodler.DoodleUsingPencil("peas porridge hot");
            doodler.DoodleUsingCrayon("peas porridge cold");
        }
    }
}
