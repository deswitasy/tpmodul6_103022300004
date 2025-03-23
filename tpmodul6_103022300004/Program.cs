// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null, "Judul video tidak boleh null.");
        Debug.Assert(title.Length <= 100, "Judul video tidak boleh lebih dari 100 karakter.");

        Random random = new Random();
        this.id = random.Next(10000, 100000);
        this.title = title;
        this.playCount = 0;
    }
    public void IncreasePlayCount (int count)
    {
        Debug.Assert(count > 0, "Jumlah play count harus lebih besar dari 0.");
        Debug.Assert(count <= 10000000, "Jumlah play count tidak boleh lebih dari 10.000.000.");

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("Terjadi overflow pada penambahan play count.");
        }
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

        video.IncreasePlayCount(10000000);
        video.printVideoDetails();

        for (int i = 0; i < 100000; i++) 
        {
            video.IncreasePlayCount(10000000); 
        }
        video.printVideoDetails();
    }
}