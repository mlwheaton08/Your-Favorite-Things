namespace Your_Favorite_Things;

public class Shoe
{
    public string Brand { get; set; }
    public string Type { get; set; }

    public void Purchase()
    {
        Console.WriteLine($"Cha-ching. {Type} {Brand} shoes purchased.");
    }

    public void LetsGo()
    {
        switch (Type.ToLower())
        {
            case "athletic":
                Console.WriteLine("Hit the pavement!");
                break;
            case "climbing":
                Console.WriteLine("Up and at 'em Mr. Honnold!");
                break;
            case "dress":
                Console.WriteLine("Dress to impress!");
                break;
            case "lounge":
                Console.WriteLine("Nothing like a comfy shoe.");
                break;
            case "boot":
                Console.WriteLine("Git er donneee.");
                break;
            default:
                Console.WriteLine("Put shoe on.");
                break;
        }
    }
}
