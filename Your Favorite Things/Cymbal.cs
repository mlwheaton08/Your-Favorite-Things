namespace Your_Favorite_Things;

public class Cymbal
{
    public string Brand { get; set; }
    public string Type { get; set; }
    public int SizeIn { get; set; }

    public string Play()
    {
        switch (Type.ToLower())
        {
            case "crash":
                return "CRASH!!!";
            case "hi-hats":
                return  "chick.";
            case "ride":
                return  "ting...";
            case "effect":
                return  "chshh";
            default:
                return "(generic cymbal sound)";
        }
    }

    public string DisplayInfo()
    {
        return $"Brand: {Brand}, Type: {Type}, Size: {SizeIn}in";
    }
}