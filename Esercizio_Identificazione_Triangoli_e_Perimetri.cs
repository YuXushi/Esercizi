/*
 Dati 3 numeri reali, indicare se possone essere i lati di un triangolo
ed eventualmente specificare se in triangolo è isoscere, equilatero o scaleno.

si ricorda che i lati delò triangolo sono tali che la somma di due di essi è sempre maggiore
del terzo lato.
 
- equilatero ha 3 lati uguali.
- isoscere solo 2.
- scaleno... rimanente casi, ovvero tuttie e tre i lati sono diversi
 
*/

using System;
using System.Speech.Synthesis;
class Program
{
    static void Main()
    {
        SpeechSynthesizer voce = new SpeechSynthesizer();
        voce.SelectVoice("Microsoft Elsa Desktop");

        try
        { 

            Console.WriteLine("Qual'è il primo lato del triangolo?");
            voce.Speak("Qual'è il primo lato del triangolo?");
            double l1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual'è il secondo lato del triangolo?");
            voce.Speak("Qual'è il secondo lato del triangolo?");
            double l2 = Double.Parse(Console.ReadLine());

            Console.WriteLine("Qual'è il terzo lato del triangolo?");
            voce.Speak("Qual'è il terzo lato del triangolo?");
            double l3 = Double.Parse(Console.ReadLine());

            if (l1 + l2 > l3 && l2 + l3 > l1 && l3 + l1 > l2)
            {
                Console.WriteLine("Il poligono è un triangolo e");
                voce.Speak("Il poligono è un triangolo e");
                if (l1 == l2 && l2 == l3)
                {
                    Console.WriteLine("Il triangolo è equilatero");
                    voce.Speak("Il triangolo è equilatero");
                    Console.ReadLine();
                }
                else if(l1 == l2 || l2 == l3 || l3 == l1)
                {
                    Console.WriteLine("Il triangolo è isoscere");
                    voce.Speak("Il triangolo è isoscere");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Il triangolo è scaleno");
                    voce.Speak("Il triangolo è scaleno");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Il Poligono non è un triangolo");
                voce.Speak("Il Poligono non è un triangolo");
                Console.ReadLine();
            }

        }
        catch(Exception ex)
        {
            Console.WriteLine("Il Valore Inserito non è valido");
            voce.Speak("Il Valore Inserito non è valido");
            Console.ReadLine();
        }


    }
}
