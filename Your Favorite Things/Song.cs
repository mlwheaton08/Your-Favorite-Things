namespace Your_Favorite_Things;

public class Song
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public DateTime ReleaseDate { get; set; }

    public void Play()
    {
        Console.WriteLine($"Alexa! Queue up some {Artist}! Volume 100!");
    }

    public void Era()
    {
        DateTime date = ReleaseDate;
        int year = date.Year;

        if (year < 1994)
        {
            Console.WriteLine("Before my time, but a classic nonetheless.");
        }
        else if (year > 1993 && year < 2003)
        {
            Console.WriteLine("A childhood bop.");
        }
        else if (year > 2002 && year < 2009)
        {
            Console.WriteLine("A juvenile banger.");
        }
        else if (year > 2008 && year < 2013)
        {
            Console.WriteLine("Ahh, the teen years. What a rollercoaster.");
        }
        else if (year >= 2013)
        {
            Console.WriteLine("The modern era. Where it is a challenge to find music I like. But this one made it through!");
        }
    }
}