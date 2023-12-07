using ProjetNarratif;
using ProjetNarratif.Rooms;

var game = new Game();
game.Add(new Start());
game.Add(new Bedroom());
game.Add(new Backroom());
game.Add(new AtticRoom());
game.Add(new BackRoom2());
game.Add(new corridor());
game.Add(new cuisine());
game.Add(new salon());

while (!game.IsGameOver())
{
    Console.WriteLine("--");
    Console.WriteLine(game.CurrentRoomDescription);
    string? choice = Console.ReadLine()?.ToLower() ?? "";
    Console.Clear();
    game.ReceiveChoice(choice);
}

Console.WriteLine("FIN");
Console.ReadLine();