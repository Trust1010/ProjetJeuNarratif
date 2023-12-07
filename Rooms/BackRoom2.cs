using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetNarratif.Rooms
{
    
    internal class BackRoom2:Room
    {
        
        internal override string CreateDescription() =>
@"Les murs sont remplit de sang et d'inscriptions incompréhensible pour toi.
Au bout de la piece, il a une table avec un [couteau].De l'autre coté,il a 
un hotel pour faire des sacrifices [inspecter].
";

        internal override void ReceiveChoice(string choice)
        {//s $
         //a@
         //c%
         //r!
         //i^
         //f*
         //i^
         //c%
         //e+
            switch (choice)
            {
                case "couteau":
                    IsCouteau = true;
                    Console.WriteLine("Tu prend le couteau pour pouvoir te defendre des hommes masque");
                    break; 

                case "inspecter":
                    Console.WriteLine("Tu y decouvre la phrase suivante : $@%!^*^%+ .\n Des bruits de pas viennent dans ta direction tu peux [partir] ou le [confronter]");
                    if (Isplan==true)
                    {
                        Console.WriteLine("Tu prend l'hotel et retourne dans la cuisine pour l'installer.");
                        Game.Transition<cuisine>();
                    }
                    string option = Console.ReadLine();
                    switch (option)
                        {
                        case "partir":

                            break;
                        case "confronter":
                            if (IsCouteau == true)
                            {
                                Console.WriteLine("L'homme masqué essaye de te tuer parceque tu ne devais pas voir cet hotel. ");
                                Console.WriteLine("Tu tue l'homme avec ton couteau.Pour te défendre.");
                                Console.WriteLine("Apres avoir fait ceci, tu cours jusqu'a la chambre.");
                                Game.Transition<Bedroom>();
                            }
                            else
                            {
                                Console.WriteLine("Sans arme tu ne peux rien contre l'homme\n\n");
                                Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄" +
                                              "\r\n█▄▄░▄▄█░██░███░▄▄█░▄▄███░▄▀▄░█▀▄▄▀█░▄▄▀█▄░▄" +
                                              "\r\n███░███░██░███░▄▄█▄▄▀███░█▄█░█░██░█░▀▀▄██░█" +
                                              "\r\n███░████▄▄▄███▄▄▄█▄▄▄███▄███▄██▄▄██▄█▄▄██▄█" +
                                              "\r\n▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                                Game.Finish();
                            }
                            
                         break;
                    }break;
                    
                     
                    break;

            }
        }
    }
}
