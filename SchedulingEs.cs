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
            Console.WriteLine("Algoritmo Di Scheduling");
            Console.WriteLine();
            Console.WriteLine("Inserire numero di processi");
            int numProcessi;
            while (!int.TryParse(Console.ReadLine(), out numProcessi))
            {
                Console.WriteLine("Inserire un valore valido per il numero di processi");
            }
            Console.WriteLine();
            Processi[] processi = new Processi[numProcessi];
            chiediProcesso(processi, numProcessi);
            int selezione;
            Random Casuale = new Random();
            for (int i = 0; i < processi.Length; i++)
            {
                processi[i].Eseguito = false;
                processi[i].PercentualeCPU = Casuale.Next(1, 101);
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
                RRLPF(processi);
            }
            else if (selezione == 5)
            {
                RRLPV(processi, Casuale);
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
                for (int j = 0; j < processi.Length; j++)
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
                Console.WriteLine($"Percentuale di CPU utilizzato: %{processi[i].PercentualeCPU}");
                processi[i].Eseguito = true;
                Thread.Sleep(processi[i].CostoProcesso);
                Console.WriteLine();
            }
        }
        static void RRLPF(Processi[] processi)
        {
            int x = 0;
            for (int i = 0; i < processi.Length; i++)
            {
                x += processi[i].CostoProcesso;
            }
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"{processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentuale di CPU utilizzato: %{processi[i].PercentualeCPU}");
                Console.WriteLine();
            }
            for (int i = 0; x > 0; i++)
            {
                int sortConta = 0;
                if (sortConta == 1)
                {
                    Console.WriteLine("sorting dei processi");
                    Console.WriteLine();
                    Processi[] processi1 = new Processi[1];
                    for (int sort = 0; sort < processi.Length; sort++)
                    {
                        for (int j = 0; j < processi.Length; j++)
                        {
                            if (processi[sort].CostoProcesso < processi[sort].CostoProcesso)
                            {
                                processi1[0].CostoProcesso = processi[sort].CostoProcesso;
                                processi1[0].NomeProcesso = processi[sort].NomeProcesso;
                                processi1[0].PercentualeCPU = processi[sort].PercentualeCPU;

                                processi[j].CostoProcesso = processi[sort].CostoProcesso;
                                processi[j].NomeProcesso = processi[sort].NomeProcesso;
                                processi[j].PercentualeCPU = processi[sort].PercentualeCPU;

                                processi[sort].CostoProcesso = processi1[0].CostoProcesso;
                                processi[sort].NomeProcesso = processi1[0].NomeProcesso;
                                processi[sort].PercentualeCPU = processi1[0].PercentualeCPU;
                            }
                        }
                    }
                }
                int y = 0;
                bool pass = false;
                bool passX = false;
                if (processi[i].Eseguito == false)
                {
                    processi[i].CostoProcesso -= 5;
                    Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                    if (processi[i].CostoProcesso <= 0)
                    {
                        processi[i].Eseguito = true;
                    }
                    if (processi[i].CostoProcesso < 0)
                    {
                        pass = true;
                        y = processi[i].CostoProcesso;
                        processi[i].CostoProcesso = 0;
                    }
                    Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                    Console.WriteLine();
                }
                else if (processi[i].Eseguito == true)
                {
                    int conta = 0;
                    while (passX == false)
                    {
                        if (processi[i].Eseguito == false)
                        {
                            processi[i].CostoProcesso -= 5;
                            Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                            passX = true;
                            if (processi[i].CostoProcesso <= 0)
                            {
                                processi[i].Eseguito = true;
                            }
                            if (processi[i].CostoProcesso < 0)
                            {
                                pass = true;
                                y = processi[i].CostoProcesso;
                                processi[i].CostoProcesso = 0;
                            }
                            Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                            Console.WriteLine();
                        }
                        i++;
                        if (i >= processi.Length)
                        {
                            i = 0;
                        }
                        if (conta >= processi.Length + 1)
                        {
                            passX = true;
                        }
                        conta++;
                    }
                }
                bool trovato = false;
                if (pass == true)
                {
                    int conta = 0;
                    while (trovato == false)
                    {
                        if (processi[i].Eseguito == false)
                        {
                            Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                            processi[i].CostoProcesso += y;
                            if (processi[i].CostoProcesso < 0)
                            {
                                processi[i].CostoProcesso = 0;
                            }
                            Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                            Console.WriteLine();
                            trovato = true;
                            conta++;
                        }
                        i++;
                        if (i >= processi.Length)
                        {
                            i = 0;
                        }
                        if (conta >= processi.Length + 1)
                        {
                            trovato = true;
                        }
                        conta++;
                    }
                }
                if (i >= processi.Length - 1)
                {
                    i = 0;
                }
                x -= 5;
                sortConta++;
            }
            Console.WriteLine("Fine delle esecuzioni");
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"{processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentuale di CPU utilizzato: %{processi[i].PercentualeCPU}");
                Console.WriteLine();
            }
        }
        static void RRLPV(Processi[] processi, Random Casuale)
        {
            int x = 0;
            for (int i = 0; i < processi.Length; i++)
            {
                x += processi[i].CostoProcesso;
            }
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"{processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentuale di CPU utilizzato: %{processi[i].PercentualeCPU}");
                Console.WriteLine();
            }
            for (int i = 0; x > 0; i++)
            {
                Console.WriteLine("---------------------------------------------------------");
                Console.WriteLine("sorting dei processi (In base alla percentuale della CPU)");
                Processi[] processi1 = new Processi[1];
                for (int sort = 0; sort < processi.Length; sort++)
                {
                    for (int j = 0; j < processi.Length; j++)
                    {
                        if (processi[sort].PercentualeCPU < processi[sort].PercentualeCPU)
                        {
                            processi1[0].CostoProcesso = processi[sort].CostoProcesso;
                            processi1[0].NomeProcesso = processi[sort].NomeProcesso;
                            processi1[0].PercentualeCPU = processi[sort].PercentualeCPU;

                            processi[j].CostoProcesso = processi[sort].CostoProcesso;
                            processi[j].NomeProcesso = processi[sort].NomeProcesso;
                            processi[j].PercentualeCPU = processi[sort].PercentualeCPU;

                            processi[sort].CostoProcesso = processi1[0].CostoProcesso;
                            processi[sort].NomeProcesso = processi1[0].NomeProcesso;
                            processi[sort].PercentualeCPU = processi1[0].PercentualeCPU;
                        }
                    }
                }
                Console.WriteLine("---------------------------------------------------------");
                int y = 0;
                bool pass = false;
                bool passX = false;
                if (processi[i].Eseguito == false)
                {
                    processi[i].CostoProcesso -= 5;
                    Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                    if (processi[i].CostoProcesso <= 0)
                    {
                        processi[i].Eseguito = true;
                    }
                    if (processi[i].CostoProcesso < 0)
                    {
                        pass = true;
                        y = processi[i].CostoProcesso;
                        processi[i].CostoProcesso = 0;
                    }
                    Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                    Console.WriteLine($"Costo CPU: {processi[i].PercentualeCPU}%");
                    Console.WriteLine();
                }
                else if (processi[i].Eseguito == true)
                {
                    int conta = 0;
                    while (passX == false)
                    {
                        if (processi[i].Eseguito == false)
                        {
                            processi[i].CostoProcesso -= 5;
                            Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                            passX = true;
                            if (processi[i].CostoProcesso <= 0)
                            {
                                processi[i].Eseguito = true;
                            }
                            if (processi[i].CostoProcesso < 0)
                            {
                                pass = true;
                                y = processi[i].CostoProcesso;
                                processi[i].CostoProcesso = 0;
                            }
                            Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                            Console.WriteLine($"Costo CPU: {processi[i].PercentualeCPU}%");
                            Console.WriteLine();
                        }
                        i++;
                        if (i >= processi.Length)
                        {
                            i = 0;
                        }
                        if (conta >= processi.Length + 1)
                        {
                            passX = true;
                        }
                        conta++;
                    }
                }
                bool trovato = false;
                if (pass == true)
                {
                    int conta = 0;
                    while (trovato == false)
                    {
                        if (processi[i].Eseguito == false)
                        {
                            Console.WriteLine($"Eseguo {processi[i].NomeProcesso}");
                            processi[i].CostoProcesso += y;
                            if (processi[i].CostoProcesso < 0)
                            {
                                processi[i].CostoProcesso = 0;
                            }
                            Console.WriteLine($"Timeslice del processo dopo esecuzione: {processi[i].CostoProcesso}");
                            Console.WriteLine($"Costo CPU: {processi[i].PercentualeCPU}%");
                            Console.WriteLine();
                            trovato = true;
                            conta++;
                        }
                        i++;
                        if (i >= processi.Length)
                        {
                            i = 0;
                        }
                        if (conta >= processi.Length + 1)
                        {
                            trovato = true;
                        }
                        conta++;
                    }
                }
                if (i >= processi.Length - 1)
                {
                    i = 0;
                }
                x -= 5;
                for (int r = 0; r < processi.Length; r++)
                {
                    processi[r].PercentualeCPU = Casuale.Next(1, 101);
                }
            }
            Console.WriteLine("Fine delle esecuzioni");
            for (int i = 0; i < processi.Length; i++)
            {
                Console.WriteLine($"{processi[i].NomeProcesso}");
                Console.WriteLine($"Timeslice di esecuzione: {processi[i].CostoProcesso}");
                Console.WriteLine($"Percentuale di CPU utilizzato: %{processi[i].PercentualeCPU}");
                Console.WriteLine();
            }
        }
        static void chiediProcesso(Processi[] processi, int numProcessi)
        {
            for (int i = 0; i < numProcessi; i++)
            {
                Console.WriteLine("Inserire il nome del processo");
                processi[i].NomeProcesso = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Inserire la lunghezza in millisecondi del processo");
                while (!int.TryParse(Console.ReadLine(), out processi[i].CostoProcesso))
                {
                    Console.WriteLine("Inserire una durata valida per il processo");
                }
                Console.WriteLine();
            }
        }
    }
}
