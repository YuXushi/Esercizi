namespace Esercizio_Voice_Synthesiser_Casa
{
    //Ricorda di aggiungere il pacchetto NuGet Speech Synthesiser
    // Per aggiungerlo vai su Progetto -> Gestisci Pacchetto NuGet -> Sfoglia -> cerca Speech
    using System;
    using System.Speech.Synthesis;
    internal class Program
    {
        static void Main(string[] args)
        {
            using (SpeechSynthesizer synthesizer = new SpeechSynthesizer())
            {
                synthesizer.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Senior);

                string Testo = Console.ReadLine();

                synthesizer.Speak(Testo);

            }
        }
    }
}
