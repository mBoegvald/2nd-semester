namespace OOP
{
    class Cd : Media
    {
        private string artist;
        public Cd(string title, double length, string artist) : base(title, length)
        {
            this.artist = artist;
        }
        // public void getArtist()
        // {

        // }
    }
}