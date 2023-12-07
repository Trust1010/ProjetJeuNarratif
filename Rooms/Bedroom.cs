namespace ProjetNarratif.Rooms
{
    internal class Bedroom : Room
    {
        internal static bool isHammerCollected;
        internal override string CreateDescription() =>
@"Tu es dans te reveil dans une chambre que tu ne reconnais pas.
Il a une [etagere] Sur ta droite, il y a une [porte] qui mene au 
reste de la maison Accrocher au mur, il y a un [mirroir].
";

        internal override void  ReceiveChoice(string choice)
        {
           
            switch (choice)
            {
                case "etagere":
                    Console.WriteLine("Tu trouve un petit marteau dans l'étagère.");
                    isHammerCollected = true;
                    
                    break;
                case "porte":
                    if (Ismort == true)
                    {
                        Console.WriteLine("Sous l'adrenaline,tu fonce dans la porte et brise le vérou qui l'a bloquait.");
                        Game.Transition<corridor>();

                    }
                    else
                    {
                        Console.WriteLine("La porte est bloque par quelque chose.");
                    }
                        

                    
                    break;
                case "mirroir":
                    if (!isHammerCollected)
                    {
                        Console.WriteLine("Tu contemple ton air fatigue et malade dans le mirroir.");
                    }
                    else
                    {
                        
                        Console.WriteLine("Tu fracasse le miroir avec le marteau.");
                        Console.WriteLine("\nTu y découvre une piece qui etait caché derrière.");
                        Console.WriteLine("\nTu entre dans la pièce secrète.");
                        Game.Transition<Backroom>();
                    }
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
