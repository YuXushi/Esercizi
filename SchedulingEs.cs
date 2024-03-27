using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
 
namespace SchedulingEs
{
    struct Processi
    {
        public string NomeProcesso;
        public int CostoProcesso;
        public int PercentualeCPU;
        public bool Eseguito;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Processi[] processi = new Processi[5];
            Processi[] copia = new Processi[5];
            Console.WriteLine("Algoritmo Di Scheduling");
            Console.WriteLine();
            //chiediProcesso();
            int selezione;
            processi[0].NomeProcesso = "Processo 1";
            processi[1].NomeProcesso = "Processo 2";
            processi[2].NomeProcesso = "Processo 3";
            processi[3].NomeProcesso = "Processo 4";
            processi[4].NomeProcesso = "Processo 5";
            Random Casuale = new Random();
            for (int i = 0; i < processi.Length; i++)
            {
                processi[i].CostoProcesso = Casuale.Next(1, 51);
                processi[i].Eseguito = false;
            }
            for (int i = 0; i < processi.Length; i++)
            {
                processi[i].PercentualeCPU = Casuale.Next(0, 101);
            }
            Console.WriteLine("Selezionare una delle seguenti opzioni di algoritmo:");
            Console.WriteLine("1. First Comes First Served");
            Console.WriteLine("2. Shortest Job First");
            Console.WriteLine("3. Longest Job First");
            Console.WriteLine("4. Round Robin con livelli di priorità fissi");
            Console.WriteLine("5. Round Robin con priorità variabile");
            while (!(int.TryParse(Console.ReadLine(), out selezione) && selezione > 0 && selezione < 6))
            {
                Console.WriteLine("Selezionare una delle seguenti opzioni di algoritmo:");
                Console.WriteLine("1. First Comes First Served");
                Console.WriteLine("2. Shortest Job First");
                Console.WriteLine("3. Longest Job First");
                Console.WriteLine("4. Round Robin con livelli di priorità fissi");
                Console.WriteLine("5. Round Robin con priorità variabile");
            }
            ProcessiOriginali(processi, copia);
            if (selezione == 1)
            {
                FCFS(processi);
            }
            else if (selezione == 2)
            {
                SJF(processi);
            }
            else if (selezione == 3)
            {
                LJF(processi);
            }
            else if (selezione == 4)
            {
                RRLPF(processi, copia);
            }
            else if (selezione == 5)
            {
                RRLPV(processi);
            }
 
 
            //First Comes First Served
 
            //Shortest Job First
 
            //Longest Job First
 
            //Round Robin con livelli di priorità fissi
 
            //Round Robin con priorità variabile in base al tempo di CPU(si utilizzerà la funzione rand per generare la % CPU per ogni processo durante l’esecuzione)
 
 
        }
        static void ProcessiOriginali(Processi[] processi, Processi[] Copy)
        {
            for (int i = 0;  i < processi.Length; i++)
            {
                Copy[i].NomeProcesso = processi[i].NomeProcesso;
                Copy[i].CostoProcesso = processi[i].CostoProcesso;
                Copy[i].PercentualeCPU = processi[i].PercentualeCPU;
            }
        }
        static void FCFS(Processi[] processi)
        {
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"Eseguendo {processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentual di CPU utilizzato: %{processi[i].PercentualeCPU}");
                processi[i].Eseguito = true;
                Thread.Sleep(processi[i].CostoProcesso);
                Console.WriteLine();
            }
        }
        static void SJF(Processi[] processi)
        {
            Processi[] processi1 = new Processi[1];
            for (int i = 0; i < processi.Length; i++)
            {
                for (int j = 0; j < processi.Length; j++)
                {
                    if (processi[i].CostoProcesso < processi[j].CostoProcesso)
                    {
                        processi1[0].CostoProcesso = processi[j].CostoProcesso;
                        processi1[0].NomeProcesso = processi[j].NomeProcesso;
                        processi1[0].PercentualeCPU = processi[j].PercentualeCPU;
 
                        processi[j].CostoProcesso = processi[i].CostoProcesso;
                        processi[j].NomeProcesso = processi[i].NomeProcesso;
                        processi[j].PercentualeCPU = processi[i].PercentualeCPU;
 
                        processi[i].CostoProcesso = processi1[0].CostoProcesso;
                        processi[i].NomeProcesso = processi1[0].NomeProcesso;
                        processi[i].PercentualeCPU = processi1[0].PercentualeCPU;
                    }
                }
            }
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"Eseguendo {processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentual di CPU utilizzato: %{processi[i].PercentualeCPU}");
                processi[i].Eseguito = true;
                Thread.Sleep(processi[i].CostoProcesso);
                Console.WriteLine();
            }
        }
        static void LJF(Processi[] processi)
        {
            Processi[] processi1 = new Processi[1];
            for (int i = 0; i < processi.Length; i++)
            {
                for (int j = 0; j > processi.Length; j++)
                {
                    if (processi[i].CostoProcesso > processi[j].CostoProcesso)
                    {
                        processi1[0].CostoProcesso = processi[j].CostoProcesso;
                        processi1[0].NomeProcesso = processi[j].NomeProcesso;
                        processi1[0].PercentualeCPU = processi[j].PercentualeCPU;
 
                        processi[j].CostoProcesso = processi[i].CostoProcesso;
                        processi[j].NomeProcesso = processi[i].NomeProcesso;
                        processi[j].PercentualeCPU = processi[i].PercentualeCPU;
 
                        processi[i].CostoProcesso = processi1[0].CostoProcesso;
                        processi[i].NomeProcesso = processi1[0].NomeProcesso;
                        processi[i].PercentualeCPU = processi1[0].PercentualeCPU;
                    }
                }
            }
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"Eseguendo {processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentual di CPU utilizzato: %{processi[i].PercentualeCPU}");
                processi[i].Eseguito = true;
                Thread.Sleep(processi[i].CostoProcesso);
                Console.WriteLine();
            }
        }
        static void RRLPF(Processi[] processi, Processi[] Copy)
        {
            Console.WriteLine();
            int TT = 0;
            int B = 0;
            int x = 0;
            for (int i = 0; i < processi.Length; i++)
            {
                while (Copy[i].CostoProcesso % 5 == 0)
                {
                    Copy[i].CostoProcesso++;
                }
                Copy[i].CostoProcesso -= processi[i].CostoProcesso;
                TT += processi[i].CostoProcesso;
                TT += Copy[i].CostoProcesso;
            }
            while (TT > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Tempo: {TT}");
                Console.WriteLine($"Eseguendo {processi[B].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[B].CostoProcesso}");
                Console.WriteLine($"Percentual di CPU utilizzato: %{processi[B].PercentualeCPU}");
                if (processi[B].CostoProcesso > 0)
                {
                    processi[B].CostoProcesso -= 5;
                    processi[B].Eseguito = true;
                }
                else
                {
                    for (int i = 0; i < processi.Length; i++)
                    {
                        for (int j = 0; j < processi.Length; j++)
                        {
                            if (processi[i].CostoProcesso < processi[j].CostoProcesso)
                            {
                                for (int k = 0; k < processi.Length; k++)
                                {
                                    processi[k].Eseguito = false;
                                }
                                processi[i].Eseguito = true;
                            }
                        }
                    }
                    for (int i = 0; i < processi.Length; i++)
                    {
                        if (processi[i].Eseguito == true)
                        {
                            processi[i].CostoProcesso -= 5;
                        }
                    }
                }
 
                for (int i = 0; i < processi.Length; i++)
                {
                    processi[i].Eseguito = false;
                }
 
                if (processi[B].CostoProcesso < 0)
                {
                    x = 0;
                    x = processi[B].CostoProcesso;
                    processi[B].CostoProcesso = 0;
 
 
                    for (int i = 0; i < processi.Length; i++)
                    {
                        for (int j = 0; j < processi.Length; j++)
                        {
                            if (processi[i].CostoProcesso < processi[j].CostoProcesso)
                            {
                                for (int o = 0; o < processi.Length; o++)
                                {
                                    processi[o].Eseguito = false;
                                }
                                processi[i].Eseguito = true;
                            }
                        }
                    }
                    for (int i = 0; i < processi.Length; i++)
                    {
                        if (processi[i].Eseguito == true)
                        {
                            processi[i].CostoProcesso += x;
                        }
                    }
                }
                TT -= 5;
                B++;
                if ( B == 4 )
                {
                    B = 0;
                }
            }
        }
        static void RRLPV(Processi[] processi)
        {
 
 
 
        }
 
 
 
 
 
 
        //static void chiediProcesso()
        //{
        //    bool finito0 = false;
        //    while (finito0 == false)
        //    {
        //        Console.WriteLine("Inserire il nome di un processo");
 
        //        Console.WriteLine("Inserire il costo del processo (in millisecondi)");
 
        //        Console.WriteLine();
 
        //        bool trueFinito0 = false;
        //        while (trueFinito0 == false)
        //        {
 
        //            Console.WriteLine("Vuole inserire un'altro processo? [Y/N]");
        //            char finito1 = Console.ReadLine().ToLower()[0];
        //            if (finito1 == 'y')
        //            {
        //                trueFinito0 = true;
        //                finito0 = true;
        //            }
        //            else if (finito1 == 'n')
        //            {
        //                trueFinito0 = true;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Inserire una risposta valida.");
        //            }
        //        }
 
        //    }
        //}
    }
}
