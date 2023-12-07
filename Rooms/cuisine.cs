using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class cuisine :Room
    {
        internal override string CreateDescription() =>
@"Dans la cuisine tu y trouve un [plan] de travail recouvert de tache de sang et une porte qui mene duirectement a la [salle] des sacrifices.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "plan":
                    Isplan = true;
                   if (Ishotel == true)
                    {
                        Console.WriteLine("Apres y avoir deposer l,hotel, il ne reste plus qua y inscrire le code ");
                        string code = Console.ReadLine();
                        switch (code)
                        {
                            case " sacrifice":

                                Console.WriteLine("La maison commence a trembler de plus en plus. Apres un court instant dans les hommes masque court vers lhotel pour stopper le rituel");
                                Console.WriteLine("Ils y arrivent trop tard le rituel se termine et fait disparaitre tout les hommes maques.");
                                Console.WriteLine("Sur le corp dun des hommes, il y avait une cle que tu prend et qui te permet de tenfuire.");

                                Console.WriteLine("████████ ██    ██     ████████ ███████ ███████     ███████ ███    ██ ███████ ██    ██ ██ ████████ \r\n   ██    ██    ██        ██    ██      ██          ██      ████   ██ ██      ██    ██ ██    ██    \r\n   ██    ██    ██        ██    █████   ███████     █████   ██ ██  ██ █████   ██    ██ ██    ██    \r\n   ██    ██    ██        ██    ██           ██     ██      ██  ██ ██ ██      ██    ██ ██    ██    \r\n   ██     ██████         ██    ███████ ███████     ███████ ██   ████ ██       ██████  ██    ██    \r\n                                                                                                  \r\n                                                                                                  ");
                                Game.Finish();
                                break;
                                default:
                                Console.WriteLine("Le code n,est pas le bon ");
                                break;
                        }
                    }
                    break;
                case "salle":
                    Console.WriteLine("Tu retourne dans la salle ou se trouve lhotel");
                    Game.Transition<BackRoom2>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

    

