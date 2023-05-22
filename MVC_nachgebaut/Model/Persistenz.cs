using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace MVC_Nachgebaut.Model
{
    public  static class Persistenz
    {
       public static void SpeicherErstellen()
        {
            FileStream fs = File.Open("Speichern.txt",FileMode.OpenOrCreate);
            StreamReader fr = new StreamReader(fs);
            fs.Close();
            fr.Close();
        }

        public static void Speichern(string n)
        {
            FileStream fs = File.Open("Speichern.txt",FileMode.Append);
            using (StreamWriter fr = new StreamWriter(fs))
            {
                fr.WriteLine(n);
            }
            fs.Close ();
        }
        public static string Lesen()
        {
            string ret;
            FileStream fs = File.Open("Speichern.txt", FileMode.Open);
            StreamReader fr = new StreamReader(fs);
            ret= fr.ReadToEnd(); 
            fs.Close();
            fr.Close() ;
            return ret;
        }
    }
}
