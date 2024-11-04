using System;

namespace PR1ManzanoEscuderoMiquel
{
    public class Program
    {
        public static void Main ()
        {
            const int MinValor = 1; // Valor minim que el usuari pot insertar
            const int MaxValor = 6; // Valor maxim que el usuari pot insertar
            const int UserNumsLength = 4; // Longitud d'array UserNums

            int[] userNums = new int[UserNumsLength]; // Array on emmagatzem els numeros del usuari


            for (int i = 0; i < userNums.Length; i++)
            {
                const string MsgEnunciat = "Introdueix el numero de la posicio:";
                const string MsgTryAgain = "Torna a probar...";
                int userNum;
                bool success;
                do
                {
                    Console.WriteLine($"{MsgEnunciat} {1 + i}");
                    success = int.TryParse(Console.ReadLine(), out userNum);
                    if (success && userNum >= MinValor && userNum <= MaxValor)
                    {
                        Console.WriteLine($"Felicitats, el numero {userNum} es valid!! \n");
                    }
                    else
                    {
                        Console.WriteLine($"Molt malament, el numero {userNum} no es valid!! \n");
                        Console.WriteLine(MsgTryAgain);
                        success = false;
                    }
                } while (!success);
                userNums[i] = userNum;
            }
        }
    }
}