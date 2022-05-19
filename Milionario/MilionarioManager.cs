using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.IO;

namespace Milionario
{
    public class MilionarioManager
    {
        //le proprietà
        public string Domanda;
        public char RispostaEsatta;
        private Timer timer;
        public int Livello;
        private int livelloMax;
        public bool seiInGioco = true;
        public string file;
        

        //costruttore
        public MilionarioManager()
        {
            this.livelloMax = 4;
            this.Livello = 0;
            ImpostaGioco();

        }
        //funzioni...
        //questo funzione serve per incrementare il livello del gioco e cambiare file delle domande
        public void ImpostaGioco()
        {
            
            this.file = GetFile();
            this.Domanda = GetDomanda();
            this.RispostaEsatta = GetRisposta();



        }
        public string GetFile()
        {
            var rand = new Random();
            var files = Directory.GetFiles(@"C:\Milionario\LivelliMilionario\Livello" + Livello, "*.txt");
            return files[rand.Next(files.Length)];
        }
        public string GetDomanda()
        {
            string Domanda = System.IO.File.ReadAllText(file);
            return Domanda;
        }
        public char GetRisposta()
        {
            string nomeFile = Path.GetFileNameWithoutExtension(file);
            char RispostaEsatta = nomeFile[nomeFile.Length - 1];
            return RispostaEsatta;

        }
        public bool ControlloRisposta(char rispostaInserita)
        {

            return RispostaEsatta == rispostaInserita;

        }
        public void IncrementoLivello()
        {
            Livello += 1;
            
            timer.Stop();
            
            //SetTimer();

        }
        public bool LimiteLivelloRaggiunto()
        {
            return Livello > livelloMax;
        }
        public System.Timers.Timer SetTimer()
        {
            
            timer = new System.Timers.Timer();
            timer.Interval = 30000;
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            return timer;
        }
        public void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Tempo Scaduto!");
            Console.WriteLine("");
            Console.WriteLine("Mi dispiace... Hai perso!");
            seiInGioco = false;
            
        }

    }
}