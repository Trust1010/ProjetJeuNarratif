using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class salon :Room 
    {
        internal override string CreateDescription() =>
@"Dans le salon il y a une drole d,odeur.Plus tu tavance vers le sofa plus l,odeur s,intensifit une fois arriver
au sofa tu y remarque un jeune homme mort coucher dessus.[inspecter].Tu peux retourner de le [couloir] 
";

        internal override void ReceiveChoice(string choice)
        {
            switch (choice)
            {
                case "inspecter":
                    Console.WriteLine("Tu regarde dans sa poche et y trouve un petit papier de convertion.");
                    Console.WriteLine("/s $ a=@  c=%  r=!  i=^  f=*  e=+  ");
                    
                    break;
                case "couloir":
                    Console.WriteLine("Tu retourne dans le couloir");
                    Game.Transition<corridor>();
                    break;
                default:
                    Console.WriteLine("Commande invalide.");
                    break;
            }
        }
    }
}

    

