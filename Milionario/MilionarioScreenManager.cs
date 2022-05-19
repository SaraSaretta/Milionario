using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Milionario
{
   

    public class MilionarioScreenManager
    {
        
        public MilionarioManager mm { get; set; }
        //costruttore
        public MilionarioScreenManager(MilionarioManager MilionarioManager)
        {
            this.mm = MilionarioManager;
        }

        public void AggiornaScherma()
        {
            
            Console.Clear();
            Console.WriteLine("Benvenuti a chi vuol essere milionario!!" + "\n");
            Console.WriteLine("\n" + $"Ti trovi nel livello {mm.Livello}");
            Console.WriteLine("\n Ecco la domanda : ");
            Console.WriteLine("");
            Console.WriteLine(mm.Domanda);
            Console.WriteLine("");
            mm.SetTimer();
            // Console.WriteLine("The application started at {0:HH:mm:ss}", DateTime.Now);
            //if (mm.seiInGioco && mm.LimiteLivelloRaggiunto())
            //{
            //    msm.AggiornaScherma();
            //    Console.WriteLine("Complimento! Sei arrivata alla fine del gioco!");
            //}


        }
    }

}









