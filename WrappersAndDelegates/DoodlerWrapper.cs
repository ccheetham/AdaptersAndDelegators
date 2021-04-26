namespace WrappersAndDelegates
{
    public abstract class DoodlerWrapper : IDoodler
    {
        private readonly IDoodler _doodler;

        public DoodlerWrapper(IDoodler doodler)
        {
            _doodler = doodler;
        }

        public void DoodleUsingPencil(string text)
        {
            _doodler.DoodleUsingPencil(text);
        }

        public void DoodleUsingCrayon(string text)
        {
            _doodler.DoodleUsingCrayon(text);
        }
    }
}
