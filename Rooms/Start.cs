using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Start : Room
    {
        internal override string CreateDescription() =>
@"Apres t'avoir fait kidnapper tu te retrouve dans une maison inconnue dans la quelle se passe des choses très douteuses.
Ton seul et unique but est de réussir a t'enfuire pour retourner chez toi.

Entrez [start] pour commencer
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "start":
                    Console.WriteLine("Début.\n");
                    Game.Transition<Bedroom>();
                    break;  
                    
                default:
                    Console.WriteLine("Commande invalide.");
                    break;

            }
        }
    }
}
