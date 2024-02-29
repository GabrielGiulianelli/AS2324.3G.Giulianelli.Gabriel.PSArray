namespace AS2324._3G.Giulianelli.Gabriel.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giulianelli Gavbriel 3G verifica informatica");
            StampaVotiPesi(voti, pesi, nvoti);
            
        }


        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti  Pesi");
            for(int i = 0; i < pesi.Length; i++)
            {
                Console.WriteLine(voti[i]+ pesi[i]);    
            }
        }
    }
}