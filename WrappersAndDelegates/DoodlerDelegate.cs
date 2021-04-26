namespace WrappersAndDelegates
{
    public class DoodlerDelegate : IDoodler
    {
        private IDoodler _red = new RedDoodler();
        private IDoodler _blue = new BlueDoodler();

        public void DoodleUsingPencil(string text)
        {
            _red.DoodleUsingPencil(text);
        }

        public void DoodleUsingCrayon(string text)
        {
            _blue.DoodleUsingCrayon(text);
        }
    }
}
