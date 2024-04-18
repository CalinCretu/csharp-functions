namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeri = { 2, 6, 7, 5, 3, 9 };    // Creo l'array a mio piacimento

            StampaArray(numeri);                    // Richiamo la fuzione stampaArray passando il mio array come parametro

            ElevaArrayAlQuadrato(numeri);           // Richiamo la funzione ElevaArrayAlQuadrato con l'array come parametro

            StampaArray(numeri);                    // Verifico se anche dopo che elevo al quadrato l'array originale rimane invariato

            int somma = sommaElementiArray(numeri); // Dichiaro la varabile somma per poterla richiamare nel Console.WriteLine
            Console.WriteLine("La somma di tutti i numeri è: " + somma);

            Console.WriteLine($"La somma degli elementi al quadrato è: {Quadrato(somma)}");

            void StampaArray(int[] array)           // Dichiaro la funzione con void poiche' puo' non deve restituire un valore specifico
            {                                       // Passo anche il parametro int[] array
                Console.Write("[ ");
                for (int i = 0; i < array.Length; i++)
                {
                    StampaElemento();

                    Console.Write(array[i]);
                    if (i < array.Length - 1)

                        StampaVirgolaESpazio();
                }
                Console.WriteLine(" ]");
            }

            void StampaVirgolaESpazio()             // Dichiaro la funzione void come sopra
            {
                Console.Write(", ");
            }

            void StampaElemento()
            {
                Console.Write("elemento ");
            }

            int Quadrato(int numero)                // Dichiaro la fuziona che mi calcola il quadrato nel numero intero passato come parametro
            {
                return numero * numero;
            }

            int sommaElementiArray(int[] array)
            {
                int somma = 0;
                foreach (int elemento in array)
                {
                    somma += elemento;
                }
                return somma;
            }

            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] risultato = new int[array.Length];
                    Console.WriteLine("Array al quadrato");

                for (int i = 0; i < array.Length; i++)
                {

                    risultato[i] = array[i] * array[i];
                    
                    Console.WriteLine(risultato[i]);
                }
                return risultato;
            }
        }
    }
}
