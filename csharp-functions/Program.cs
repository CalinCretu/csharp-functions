namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void StampaArray(int[] array)       // Dichiaro la funzione con void poiche' puo' non deve restituire un valore specifico
            {                                   // Passo anche il parametro int[] array
                Console.Write("(");
                for (int i = 0; i < array.Length; i++)
                {
                    StampaElemento();

                    Console.Write(array[i]);
                    if (i < array.Length - 1)

                        StampaVirgolaESpazio();
                }
                Console.Write(")");
            }
            void StampaVirgolaESpazio()         // Dichiaro la funzione void come sopra
            {
                Console.Write(", ");
            }
            void StampaElemento()
            {
                Console.Write("elemento ");
            }

            int[] numeri = { 1, 2, 3, 4, 5, 6 };    // Creo l'array a mio piacimento
            StampaArray(numeri);                    // Richiamo la fuzione stampaArray passando il mio array come parametro
        }
    }
}
