namespace Your_Favorite_Things;

public class Cymbal
{
    public string Brand { get; set; }
    public string Type { get; set; }
    public int SizeIn { get; set; }

    public void Play()
    {
        switch (Type.ToLower())
        {
            case "crash":
                Console.WriteLine("CRASH!!!");
                break;
            case "hi-hats":
                Console.WriteLine("chick.");
                break;
            case "ride":
                Console.WriteLine("ting...");
                break;
            case "effect":
                Console.WriteLine("chshh");
                break;
            default:
                Console.WriteLine("(generic cymbal sound)");
                break;
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Type: {Type}, Size: {SizeIn}in");
    }
}