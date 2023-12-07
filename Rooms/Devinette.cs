using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    internal class Devinette :Room
    {

        internal override string CreateDescription() =>
@"Bonjours mon ami!Je vais te poser une petite devinette!
Es-tu près?[oui]
";

        internal override void ReceiveChoice(string choice)
        {
          
            
                const string reponseCorrecte = "plume";
                const int essaisMax = 3;
                int essaisRestants = essaisMax;

                Console.WriteLine(" Je suis un objet que nous n'utilison pas a tout les jours?");
                Console.WriteLine("Vous avez 3 essais pour deviner.");

                while (essaisRestants > 0)
                {
                    string reponse = Console.ReadLine().ToLower();

                    if (reponse == reponseCorrecte)
                    {
                        Console.WriteLine("Bravo ! Vous avez trouvé plume !");
                        return;
                    }
                    else
                    {
                        essaisRestants--;
                        Console.WriteLine($"Ce n'est pas la bonne réponse. Il vous reste {essaisRestants} essai(s).");

                        
                        switch (essaisRestants)
                        {
                            case 2:
                                Console.WriteLine("Je suis doux au toucher,mais je suis très résistant.");
                                break;
                            case 1:
                                Console.WriteLine("Je pousse sur certain animal");
                                break;
                                case 3:
                                Console.WriteLine("Je peux venir en plusieurs couleur,mais je vais le plus souvent en blanc");
                                break;
                            default:
                                Console.WriteLine($"Dommage, vous n'avez plus d'essais. La bonne réponse était : {reponseCorrecte}.");
                            Game.Finish();
                                return;
                        }
                    }
                }
            }
        }

    }
   

