using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class corridor :Room
    {
        internal override string CreateDescription() =>
@"Rendue dans le corridor tu realise que la maison est dans un mauvais etat tout comme la piece suspecte derriere
le mirroir.Toute les portes sont barricade sauf deux la premiere est ouverte et resemble a une [cuisine] la 
deuxieme semble etre un [salon] ou du moin ce quil en reste.
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "cuisine":
                    Console.WriteLine("Tu entre dans la cuisine.");
                    Game.Transition<cuisine>();
                    break;
                case "salon":
                    Console.WriteLine("Tu entre dans le salon.");
                    Game.Transition<salon>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

    
