namespace AdaptersAndDelegators
{
    class Program
    {
        static void Main(string[] args)
        {
            using var doodler = new NotebookDoodler(new DoodlerDelegator());
            doodler.DoodleUsingPencil("peas porridge hot");
            doodler.DoodleUsingCrayon("peas porridge cold");
        }
    }
}
