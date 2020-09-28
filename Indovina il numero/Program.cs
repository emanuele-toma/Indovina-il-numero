using System;

namespace Indovina_il_numero
{
    class Program
    {
        static void Main()
        {
            Random casuale = default;
            int numeroInput = default;
            int numeroCorretto = default;
            int massimo = default;
            int minimo = default;
            int tentativi = default;
            string stringaInput = default;
            bool replay = default;

            replay = false;
            Console.Title = "Indovina il numero!";
            do
            {
                casuale = new Random();
                numeroCorretto = casuale.Next(0, 100);
                massimo = 100;
                minimo = 0;
                tentativi = 0;

                Console.WriteLine("#################################################");
                Console.WriteLine(" _____          _            _               _ _ ");
                Console.WriteLine("|_   _|        | |          (_)             (_) |");
                Console.WriteLine("  | | _ __   __| | _____   ___ _ __   __ _   _| |");
                Console.WriteLine("  | || '_ \\ / _` |/ _ \\ \\ / / | '_ \\ / _` | | | |");
                Console.WriteLine(" _| || | | | (_| | (_) \\ V /| | | | | (_| | | | |");
                Console.WriteLine(" \\___/_| |_|\\__,_|\\___/ \\_/ |_|_| |_|\\__,_| |_|_|");
                Console.WriteLine("                                                 ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("    _ __  _   _ _ __ ___   ___ _ __ ___          ");
                Console.WriteLine("   | '_ \\| | | | '_ ` _ \\ / _ \\ '__/ _ \\         ");
                Console.WriteLine("   | | | | |_| | | | | | |  __/ | | (_) |        ");
                Console.WriteLine("   |_| |_|\\__,_|_| |_| |_|\\___|_|  \\___/         ");
                Console.WriteLine("                                                 ");
                Console.WriteLine("#################################################");
                Console.WriteLine("Premi un tasto per continuare...");
                Console.ReadKey();
                Console.Clear();

                do
                {
                    do
                    {
                        Console.Write("Inserisci un numero [" + minimo + ", " + massimo + "]: ");
                        stringaInput = Console.ReadLine();
                    } while (!int.TryParse(stringaInput, out numeroInput));

                    if (numeroInput < numeroCorretto)
                    {
                        minimo = numeroInput;
                        Console.WriteLine("Il numero è più grande...\n");
                    }
                    else if (numeroInput > numeroCorretto)
                    {
                        massimo = numeroInput;
                        Console.WriteLine("Il numero è più piccolo...\n");
                    };
                    tentativi++;
                } while (numeroInput != numeroCorretto);

                Console.WriteLine("Hai indovinato il numero in " + tentativi +" tentativi!\n");
                Console.WriteLine("Vuoi rigiocare? (S/N)");

                if(Console.ReadKey().Key == ConsoleKey.S)
                {
                    replay = true;
                    Console.Clear();
                } else
                {
                    replay = false;
                }
            } while (replay == true);

        }

    }
}
