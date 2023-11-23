/*
   INIZIO
    leggi media
    leggi anno
    se anno = 3 allora
        se media = 6
            cediti = 7
    altrimenti se 6<media<=7 allora
        crediti = 8
....

....

....

    altrimenti

    fine se


scrivi crediti
FINE
 */

using System;
using System.Net.Http.Headers;

internal class Program
{
    private static void Main()
    {
        try
        {
            Console.WriteLine("Inserisci la media");
            double media;
            media = double.Parse(Console.ReadLine());

            int anno;
            Console.WriteLine("a che anno di superiori sei?");
            anno = int.Parse(Console.ReadLine());
            if (anno < 3)
            {
                Console.WriteLine("non puoi prendere crediti in questo anno");

            }

            else
            {

                if (media < 1)
                {

                    Console.WriteLine("Valore Non Possibile");
                    Main();
                }
                else
                {
                    if (media > 10)
                    {
                        Console.WriteLine("Valore Impossibile");
                        Main();
                    }
                    else
                    {




                    }


                }
                if (anno == 3)
                {
                    if (media < 6)
                    {
                        Console.WriteLine("non ottieni alcun credito");
                    }
                    else if (media == 6)
                    {
                        Console.WriteLine("ottieni dai 7 agli 8 crediti");
                    }
                    else if (media > 6 && media <= 7)
                    {
                        Console.WriteLine("ottieni dagli 8 ai 9 crediti");
                    }
                    else if (media > 7 && media <= 8)
                    {
                        Console.WriteLine("ottieni dai 9 ai 10 crediti");
                    }
                    else if (media > 8 && media <= 9)
                    {
                        Console.WriteLine("ottieni dai 10 agli 11 crediti");
                    }
                    else if (media > 9 && media <= 10)
                    {
                        Console.WriteLine("ottieni dagli 11 ai 12 crediti");
                    }

                }
                else
                {
                    if (anno == 4)
                    {
                        if (media < 6)
                        {
                            Console.WriteLine("non ottieni alcun credito");
                        }
                        else if (media == 6)
                        {
                            Console.WriteLine("ottieni dagli 8 ai 9 crediti");
                        }
                        else if (media > 6 && media <= 7)
                        {
                            Console.WriteLine("ottieni dai 9 ai 10 crediti");
                        }
                        else if (media > 7 && media <= 8)
                        {
                            Console.WriteLine("ottieni dai 10 agli 11 crediti");
                        }
                        else if (media > 8 && media <= 9)
                        {
                            Console.WriteLine("ottieni dagli 11 ai 12 crediti");
                        }
                        else if (media > 9 && media <= 10)
                        {
                            Console.WriteLine("ottieni dai 12 ai 13 crediti");
                        }

                    }


                    if (anno == 5)
                    {
                        if (media < 6)
                        {
                            Console.WriteLine("ottieni dai 7 agli 8 crediti");
                        }
                        else if (media == 6)
                        {
                            Console.WriteLine("ottieni dai 9 ai 10 crediti");
                        }
                        else if (media > 6 && media <= 7)
                        {
                            Console.WriteLine("ottieni dai 10 agli 11 crediti");
                        }
                        else if (media > 7 && media <= 8)
                        {
                            Console.WriteLine("ottieni dagli 11 ai 12 crediti");
                        }
                        else if (media > 8 && media <= 9)
                        {
                            Console.WriteLine("ottieni dai 13 ai 14 crediti");
                        }
                        else if (media > 9 && media <= 10)
                        {
                            Console.WriteLine("ottieni dai 14 ai 15 crediti");
                        }


                    }

                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("il valore inserito non è corretto" + ex.Message);
            Main();
        }
    }
}

