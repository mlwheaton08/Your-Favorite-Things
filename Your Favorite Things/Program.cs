using Your_Favorite_Things;

Cymbal cymbal = new Cymbal
{
    Brand = "Paiste",
    Type = "Crash",
    SizeIn = 19
};

Cymbal cymbal2 = new Cymbal
{
    Brand = "Paiste",
    Type = "Hi-Hats",
    SizeIn = 15
};

Console.WriteLine(cymbal.DisplayInfo());
Console.WriteLine(cymbal.Play());
Console.WriteLine(cymbal2.DisplayInfo());
Console.WriteLine(cymbal2.Play());


Video_Game game = new Video_Game
{
    Name = "Rocket League",
    Genre = "Esports",
    RatingOf10 = 10
};

game.Play();
game.Rating();


Song song = new Song
{
    Name = "Lyin' Eyes",
    Artist = "Eagles",
    ReleaseDate = new DateTime(1975)
};

Console.WriteLine(song.Play());
Console.WriteLine(song.Era());


Shoe shoe = new Shoe
{
    Brand = "Nike",
    Type = "Athletic"
};

Console.WriteLine(shoe.Purchase());
Console.WriteLine(shoe.LetsGo());