namespace Your_Favorite_Things;

public class Shoe
{
    public string Brand { get; set; }
    public string Type { get; set; }

    public string Purchase()
    {
        return $"Cha-ching. {Type} {Brand} shoes purchased.";
    }

    public string LetsGo()
    {
        switch (Type.ToLower())
        {
            case "athletic":
                return "Hit the pavement!";
            case "climbing":
                return "Up and at 'em Mr. Honnold!";
            case "dress":
                return "Dress to impress!";
            case "lounge":
                return "Nothing like a comfy shoe.";
            case "boot":
                return "Git er donneee.";
            default:
                return "Put shoe on.";
        }
    }
}
