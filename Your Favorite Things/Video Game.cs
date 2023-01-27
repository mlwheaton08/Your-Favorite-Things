namespace Your_Favorite_Things;

public class Video_Game
{
    public string Name { get; set; }
    public string Genre { get; set; }
    public int RatingOf10 { get; set; }


    public void Play() //doing this method as void to display another way, rather than returning a string and console writing it in program.cs (this is probably a better way actually)
    {
        Console.WriteLine($"Booting up {Name}... Get ready for some {Genre} gaming!");
        Thread.Sleep(2000);
        Console.WriteLine("Let's go!");
    }

    public void Rating()
    {
        switch (RatingOf10)
        {
            case 0:
                Console.WriteLine("Trash.");
                break;
            case 1:
                Console.WriteLine("Yeah not good.");
                break;
            case 2:
                Console.WriteLine("Nah, wouldn't recommend.");
                break;
            case 3:
                Console.WriteLine("Not very good.");
                break;
            case 4:
                Console.WriteLine("Meh.");
                break;
            case 5:
                Console.WriteLine("It's alright I guess?");
                break;
            case 6:
                Console.WriteLine("Decent.");
                break;
            case 7:
                Console.WriteLine("Pretty good honestly.");
                break;
            case 8:
                Console.WriteLine("Good game, would recommend.");
                break;
            case 9:
                Console.WriteLine("Awesome game!");
                break;
            case 10:
                Console.WriteLine("Literally the perfect game. Maybe the best I've ever played!");
                break;
            default:
                Console.WriteLine("Is this a valid rating?");
                break;
        }
    }
}