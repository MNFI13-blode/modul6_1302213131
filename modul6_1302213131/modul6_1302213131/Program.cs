internal class Program
{
    public class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playcount;
        public SayaTubeVideo(string title)
        {
            this.title = title;
            this.id = new Random().Next(5);
            this.playcount = 0;
        }
        public void IncreasePlayCount(int playcount)
        {
            this.playcount += playcount;
        }
        public int GetTotalVideoPlaycount()
        {
            return playcount;
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID        : " + id);
            Console.WriteLine("Title     : " + title);
            Console.WriteLine("Playcount : " + playcount);
        }
    }
    public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> UploadedVideos;
        public string Username;
        public SayaTubeUser(string Username,List<SayaTubeVideo> UploadedVideos)
        {
            this.Username = Username;
        }
        public void addVideo(SayaTubeVideo video)
        {
            this.UploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + Username);

            Console.WriteLine();
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}