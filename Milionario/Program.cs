using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Milionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //abbiamo creato nuovo oggetto 
            MilionarioManager mm = new MilionarioManager();
            MilionarioScreenManager msm=new MilionarioScreenManager(mm);
            
            //abbiamo definito rispostaInserita
            char rispostaInserita;
            //finche stai al gioco e non sei raggiunto al limite del livello 
            while (mm.seiInGioco && !mm.LimiteLivelloRaggiunto())
	        {
                mm.ImpostaGioco();
                msm.AggiornaScherma();
                Console.WriteLine("Digita la lettera corrisponde alla risposta esatta: ");
                Console.WriteLine("");
                Console.WriteLine("\nATTENZIONE! Hai solo 30 secondi per indovinare...");
                //prendimao la risposta inserita
                rispostaInserita =Console.ReadKey().KeyChar;
                //se la risposta inserita è true incrementa il livello
                if (mm.ControlloRisposta(rispostaInserita))
                {
                    Console.WriteLine("");
                    Console.WriteLine("\nRisposta Esatta!");
                    Console.WriteLine("");
                    Console.WriteLine("Premi INVIO per passare alla domanda successiva");
                    mm.IncrementoLivello();
                    Console.ReadLine();
                    

                }
                //se no ...
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("\nRisposta Errata...");
                    Console.WriteLine("");
                    Console.WriteLine("\nmi dispiace! hai perso...");
                    mm.seiInGioco = false;

                }
	        }
            //if  (mm.seiInGioco)
            //{
            //    Console.WriteLine("Complimento! Sei arrivata alla fine del gioco!");
            //}
            if (mm.seiInGioco)
            {
                
                Console.WriteLine("Complimento! Sei arrivata alla fine del gioco!");
            }
            Console.ReadLine();  

        }
    }
}
