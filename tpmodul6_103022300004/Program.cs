// See https://aka.ms/new-console-template for more information
class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount (int count)
    {
        if (count < 0)
        {
            Console.WriteLine("Jumlah play count tidak boleh negatif.");
            return;
        }

        playCount += count;
    }
    public void printVideoDetails()
    {
        Console.WriteLine("Video ID     : " + id);
        Console.WriteLine("Video Title  : " + title);
        Console.WriteLine("Play Count   : " + playCount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – [DESWITA_PRAKTIKAN]");

        video.IncreasePlayCount(100);
        video.printVideoDetails();
    }
}