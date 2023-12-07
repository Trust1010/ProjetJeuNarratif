namespace ProjetNarratif.Rooms
{
    internal class Backroom : Room
    {
        internal static bool Isrepéreré;
        internal static bool Ismasque;
        internal override string CreateDescription() =>
    @"Tu rentre dans la piece il n'y a aucun bruit.Tu vois une lueur au loin et tu décide de t'y en approcher.
Tu commence a entendre des murs murs qui vien de la pièce élluminé.Tu hésite a te rapprocher d'avantage pour comprendre se qu'ils disent [avancer]
ou bien a rester ou tu est a chercher des indices sur l'endroit ou tu es.[rester]";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "avancer":
                    if (Ismasque != true)
                    {
                      
                        Console.WriteLine("Tu avance un peu trop et un homme te repère et avance dans ta direction[courir] ou le [confronter] ");
                        string choix = Console.ReadLine();

                        switch(choix)
                        {
                            case "courir":
                                Game.Transition<Bedroom>();
                                break;

                            case "confronter":
                                Console.WriteLine("L'homme s'approche de vous et vous attrape pour vous enmenez au millieu de ses congénère.Ils te sacrifit pour un de rituel.");

                                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄" +
                                              "\r\n█▄▄░▄▄█░██░███░▄▄█░▄▄███░▄▀▄░█▀▄▄▀█░▄▄▀█▄░▄" +
                                              "\r\n███░███░██░███░▄▄█▄▄▀███░█▄█░█░██░█░▀▀▄██░█" +
                                              "\r\n███░████▄▄▄███▄▄▄█▄▄▄███▄███▄██▄▄██▄█▄▄██▄█" +
                                              "\r\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                                Game.Finish();
                                Console.ReadKey();
                                break;

                        }
                    }else
                    {
                        Console.WriteLine("Tu mets le masque et entre dans une piece remplit d'homme masqué.Tu reste a l'écart en les observant");
                        Console.WriteLine("Tu t'avanture plus loin et realisant que les hommes qui tentour sont en realite des creature démoniaque. ");
                        Game.Transition<BackRoom2>();
                    }
                    break;
                case "rester":
                    Ismasque = true;
                    Console.WriteLine("Tu cherche la piece dans la quelle tu es et tu y trouve un masque avec des inscriptions dans une langue inconnue écrite sur une de ses faces.");
                    Console.WriteLine("[avancer]");
                    break;
                
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}
