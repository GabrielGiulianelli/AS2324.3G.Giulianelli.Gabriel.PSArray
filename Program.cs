namespace AS2324._3G.Giulianelli.Gabriel.PSArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giulianelli Gavbriel 3G verifica informatica");
            Console.WriteLine("Inserire il numero di voti");
            int nVoti=Convert.ToInt32(Console.ReadLine());
            double[] voti = new double[nVoti];
            int[]pesi= new int[nVoti];
            CaricaVettori(ref voti, ref pesi, nVoti);
            StampaVotiPesi(voti, pesi, nVoti);
            StampaVotiDispariMaggiori4(ref voti, ref pesi, nVoti);
            double max = 0;
            double min = 0;
            int  posmax = 0;
            int  posmin = 0;
            int voto = 0;
            double mediaponderata = MediaPonderata(voti, pesi, nVoti, ref  max,ref posmax,ref  min,ref posmin);
            Console.WriteLine($"La media ponderata è {mediaponderata} il valor emassimo è {max} in posizione {posmax}  e il valore minimo è {min} in posione {posmin}");
            ElencoVotiNellIntorno(voti, pesi, nVoti,voto);


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
        static void StampaVotiDispariMaggiori4(ref double[] voti, ref int[] pesi, int nVoti)
        {
            for (int i=0; i < nVoti; i+=2)
            {
                if (voti[i] > 4)
                {
                    Console.WriteLine($"I voti maggiori di 4 sono {voti[i]} con i relativi pesi {pesi[i]}");
                }
            }
        }
        static double MediaPonderata(double[] voti, int[] pesi, int nVoti, ref double max, ref int posmax, ref double min, ref int posmin)
        {
            double mediaponderata = 0;
            double sommatoriavotipesi = 0;
            int sommatoria = 0;
            for (int i = 0; i < nVoti; i++)
            {
                sommatoria += pesi[i];
                sommatoriavotipesi = voti[i] + pesi[i];

            }
            mediaponderata = sommatoriavotipesi / sommatoria;
            min = voti[0];
            max = voti[0];
            for (int i = 0; i < nVoti; i++)
            {
                if (voti[i]> max)
                {
                    max = voti[i];
                    posmax = i;
                }
                if (voti[i] > min)
                {
                    min = voti[i];
                    posmin = i;
                }
            }
            return mediaponderata;
        }
        static void  ElencoVotiNellIntorno(double[] voti, int[] pesi, int nVoti, int   voto)
        {
            for (int i = 0; i < nVoti; i++) {
                if (voti[i] > voto - 0.5 && voti[i] < voto + 0.5)
                {
                    Console.WriteLine($"Il voto {voti[i]} in posizione {i + 1} è compreso tra {voto - 0.5} e {voto + 0.5}");
                }
            }

        }




            }
}
