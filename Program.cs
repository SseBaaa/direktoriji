using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace systemIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            //provjera dali direktorij postoji
            if(Directory.Exists(putanja))
            {
                //ako postoji ispišemo sve datoteke
                Console.WriteLine("Datoteke: ");
                foreach(string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
            }
            string putanjaPoddirektorija = "\\Test";

            if(!Directory.Exists(putanja + putanjaPoddirektorija))
            {
                Directory.CreateDirectory(putanja + putanjaPoddirektorija);
            }
            else
            {
                Console.WriteLine("Direktorij vec postoji ");
            }
            Console.WriteLine("\n Podirektoriji: ");
            foreach(string PODdatoteka in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(PODdatoteka);
            }
            Directory.Delete(putanjaPoddirektorija);
            Console.WriteLine("\nNakon brisanja: ");
            foreach (string PODdatoteka in Directory.GetDirectories(putanja))
            {
                Console.WriteLine(PODdatoteka);
            }
            Console.ReadKey();
        }
    }
}
