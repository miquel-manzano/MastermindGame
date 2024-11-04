using System;

namespace PR1ManzanoEscuderoMiquel
{
    public class Program
    {
        // VARIABLES USADAS EN TODOS LOS METODOS:

        const int MinValor = 1; // Valor minim que el usuari pot insertar
        const int MaxValor = 6; // Valor maxim que el usuari pot insertar
        const int UserNumsLength = 4; // Longitud d'array UserNums

        public static void Main ()
        {
            const int CombNums = 1234;
            int[] userNums = new int[UserNumsLength]; // Array on emmagatzem els numeros del usuari

            ArrayMaker(userNums, 0);
            ArrayMaker(userNums, 1);
        }

        public static void ArrayMaker(int[] Array, int mode)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                int returnNum = 0;
                switch (mode)
                {
                    case 0:
                        InsertUserNums(Array, i);
                        break;
                    case 1:
                        ReadArray(Array, i);
                        break;
                }
            }
        }

        public static void InsertUserNums(int[] Array, int posicion)
        {
            const string MsgEnunciat = "Introdueix el numero de la posicio:";
            const string MsgTryAgain = "Torna a probar...";
            int userNum;
            bool success;
            do
            {
                Console.WriteLine($"{MsgEnunciat} {1 + posicion}");
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
            Array[posicion] = userNum;
        }

        public static void ReadArray(int[] Array, int posicion)
        {
            Console.WriteLine("Lectura d'array:");
            Console.Write(Array[posicion]);
        }
    }
}