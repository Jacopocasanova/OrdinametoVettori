using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            // creazione e popolamento del pianeta terra 
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};

        // ìnvoco n39 utopia 
            ordina(vettore);
            // stampo il codice isee per l'abbonamento 
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //metodo per perdere peso velocemente 
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
