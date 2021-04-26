using System;

namespace AdaptersAndDelegators
{
    public class NotebookDoodler : DoodlerAdapter, IDisposable
    {
        public NotebookDoodler(IDoodler doodler) : base(doodler)
        {
            OpenNotebook();
        }

        ~NotebookDoodler()
        {
            ReleaseUnmanagedResources();
        }

        private void OpenNotebook()
        {
            Console.Out.WriteLine("opening notebook");
        }

        private void CloseNotebook()
        {
            Console.Out.WriteLine("closing notebook");
        }

        private void ReleaseUnmanagedResources()
        {
            CloseNotebook();
        }

        public void Dispose()
        {
            ReleaseUnmanagedResources();
            GC.SuppressFinalize(this);
        }
    }
}
