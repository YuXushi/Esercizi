// See https://aka.ms/new-console-template for more information


using System;
using System.Speech.Synthesis;
    
class Program
{
    static void Main()
    { 
        SpeechSynthesizer voce= new SpeechSynthesizer();

        voce.SelectVoice("Microsoft Elsa Desktop");

        Console.Write("Inserisci testo da far pronunciare in italiano: ");

        string testoDaLeggere = Console.ReadLine();

        voce.Speak(testoDaLeggere);
    }
}
