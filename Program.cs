namespace AS2324._3G.Giulianelli.Gabriel.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giulianelli Gavbriel 3G verifica informatica");
            Console.WriteLine("Inserire il numero di voti");
            int nvoti=Convert.ToInt32(Console.ReadLine());
            double[] voti = new double[nvoti];
            int[]pesi= new int[nvoti];
            CaricaVettori(ref voti, ref pesi, nvoti);
            StampaVotiPesi(voti, pesi, nvoti);
            
        }


        static void StampaVotiPesi(double[] voti, int[] pesi, int nVoti)
        {
            Console.WriteLine("Voti  Pesi");
            for(int i = 0; i < nVoti; i++)
            {
                Console.WriteLine($"{voti[i]}       {pesi[i]}");    
            }
        }
        static void CaricaVettori(ref double[] voti, ref int[] pesi, int nVoti)
        {
            Random random = new Random();
           
            for(int i=0; i <nVoti;i++)
            {
                voti[i] = random.Next(0, 11);
                pesi[i] = random.Next(0, 101);
            }
        }
    }
}