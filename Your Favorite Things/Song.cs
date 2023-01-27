namespace Your_Favorite_Things;

public class Song
{
    public string Name { get; set; }
    public string Artist { get; set; }
    public DateTime ReleaseDate { get; set; }

    public string Play()
    {
        return $"Alexa! Queue up some {Artist}! Volume 100!";
    }

    public string Era()
    {
        DateTime date = ReleaseDate;
        int year = date.Year;

        if (year < 1994)
        {
            return "Before my time, but a classic nonetheless.";
        }
        else if (year > 1993 && year < 2003)
        {
            return "A childhood bop.";
        }
        else if (year > 2002 && year < 2009)
        {
            return "A juvenile banger.";
        }
        else if (year > 2008 && year < 2013)
        {
            return "Ahh, the teen years. What a rollercoaster.";
        }
        else if (year >= 2013)
        {
            return "The modern era. Where it is a challenge to find music I like. But this one made it through!";
        }
        else
        {
            return "Did you enter a valid year?";
        }
    }
}